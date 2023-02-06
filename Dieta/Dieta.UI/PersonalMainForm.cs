using Dieta.BLL;
using Dieta.DAL.Entity;
using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dieta.UI
{
    public partial class PersonalMainForm : Form
    {
        DietaEntities context { get; set; }
        User User { get; set; }
        DailyProgramme dailyProgramme { get; set; }
        public PersonalMainForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public PersonalMainForm(User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            User = user;
        }

        private void PersonalMainForm_Load(object sender, EventArgs e)
        {
            lblWaterNotification.Text = "Water is the most important part of a healthy life. As Dieta, we recommend that you drink at least 2.5 liters of water a day.";
            lblPersonalPageText.Text = "Did you know you've made your life healthier with Dieta?\nWelcome to the section with the diary summary.";
            pbUserPhoto.ImageLocation = "";
            double goalOfCalories = 0;
            double remainingCalories = 0;
            double totalCalories = 0;
            double burnedCalories = 0;
            double netCalories = 0;
            DateTime date = DateTime.Today;
            dailyProgramme = context.DailyProgrammes.Where(dp => dp.UserId == User.Id && dp.Day == date.Day && dp.Month == date.Month && dp.Year == date.Year).SingleOrDefault();
            if (dailyProgramme != null)
            {
                GetCalories(out goalOfCalories, out remainingCalories, out totalCalories, out burnedCalories, out netCalories, dailyProgramme);
                ReWriteCalories(goalOfCalories, remainingCalories, totalCalories, burnedCalories, netCalories);
                RefreshProgressBar(context.DailyProgrammes.Where(dp => dp.Id == dailyProgramme.Id).FirstOrDefault().GoalOfCal, context.DailyProgrammes.Where(dp => dp.Id == dailyProgramme.Id).FirstOrDefault().NetCal);
            }
            else
            {
                dailyProgramme = new DailyProgramme()
                {
                    Day = date.Day,
                    Month = date.Month,
                    Year = date.Year,
                    GoalOfCal = DietaController.CalculateBMR(User.Gender == "Male" ? 0 : 1, User.Weight, User.Height, User.Age, User.ActivityLevelId, User.GoalId),
                    TotalCal = 0,
                    TotalBurnedCal = 0,
                    NetCal = 0,
                    UserId = User.Id
                };
                goalOfCalories = Convert.ToInt32(dailyProgramme.GoalOfCal);
                remainingCalories = Convert.ToInt32(dailyProgramme.GoalOfCal - dailyProgramme.NetCal);
                totalCalories = Convert.ToInt32(dailyProgramme.TotalCal);
                burnedCalories = Convert.ToInt32(dailyProgramme.TotalBurnedCal);
                netCalories = Convert.ToInt32(dailyProgramme.NetCal);
                context.DailyProgrammes.Add(dailyProgramme);
                context.SaveChanges();
                GetCalories(out goalOfCalories, out remainingCalories, out totalCalories, out burnedCalories, out netCalories, dailyProgramme);
                ReWriteCalories(goalOfCalories, remainingCalories, totalCalories, burnedCalories, netCalories);
                RefreshProgressBar(context.DailyProgrammes.Where(dp => dp.Id == dailyProgramme.Id).FirstOrDefault().GoalOfCal, context.DailyProgrammes.Where(dp => dp.Id == dailyProgramme.Id).FirstOrDefault().NetCal);
            }
        }

        private void RefreshProgressBar(double goalOfCalories, double netCalories)
        {
            progressBarCurrentCal.Maximum = Convert.ToInt32(goalOfCalories);
            if (netCalories > 0 && netCalories <= goalOfCalories)
            {
                progressBarCurrentCal.Value = Convert.ToInt32(netCalories);
            }
            else if (netCalories<0)
            {
                progressBarCurrentCal.Value = progressBarCurrentCal.Minimum;
            }
            else if (netCalories > goalOfCalories)
            {
                progressBarCurrentCal.Value = progressBarCurrentCal.Maximum;
            }
            lblCurrentProgress.Text = Convert.ToInt32(netCalories).ToString();
        }

        private void ReWriteCalories(double goalOfCalories, double remainingCalories, double foodCalories, double burnedCalories, double netCalories)
        {
            lblGoalOfCalories.Text = Convert.ToInt32(goalOfCalories).ToString();
            lblRemainingCalories.Text = Convert.ToInt32(remainingCalories).ToString();
            lblFoodCalories.Text = Convert.ToInt32(foodCalories).ToString();
            lblExerciseCalories.Text = Convert.ToInt32(burnedCalories).ToString();
            lblNetCalories.Text = Convert.ToInt32(netCalories).ToString();
        }

        private static void GetCalories(out double goalOfCalories, out double remainingCalories, out double foodCalories, out double burnedCalories, out double netCalories, DailyProgramme dailyProgramme)
        {
            goalOfCalories = dailyProgramme.GoalOfCal;
            remainingCalories = dailyProgramme.GoalOfCal - dailyProgramme.NetCal;
            foodCalories = dailyProgramme.TotalCal;
            burnedCalories = dailyProgramme.TotalBurnedCal;
            netCalories = dailyProgramme.NetCal;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodForm = new AddFoodForm(dailyProgramme, User);
            addFoodForm.Show();
            this.Hide();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            AddExerciseForm addExerciseForm = new AddExerciseForm(dailyProgramme, User);
            addExerciseForm.Show();
            this.Hide();
        }

        private void btnPersonalInformation_Click(object sender, EventArgs e)
        {
            PersonalInformationForm personalInformationForm = new PersonalInformationForm(User);
            personalInformationForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(User);
            reportsForm.ShowDialog();
        }

        private void btnSafeExit_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void PersonalMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            FoodDetail foodDetail = new FoodDetail();
            foodDetail.FoodId = 1;
            foodDetail.MealId = 4;
            foodDetail.DailyProgrammeId = dailyProgramme.Id;
            foodDetail.Portion = (double)nudWater.Value;
            context.FoodDetails.Add(foodDetail);
            context.SaveChanges();
        }
    }
}
