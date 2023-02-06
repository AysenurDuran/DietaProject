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
using System.Windows.Forms.DataVisualization.Charting;

namespace Dieta.UI
{
    public partial class ReportsForm : Form
    {
        User User { get; set; }
        DietaEntities Context { get; set; }
        List<DailyProgramme> DailyProgrammes { get; set; }
        DateTime CurrentDate { get; set; }

        public ReportsForm()
        {
            InitializeComponent();
            Context = new DietaEntities();
            DateTime currentDate = DateTime.Now.Date;
            List<DailyProgramme> dailyProgrammes = Context.DailyProgrammes.Where(dp => dp.UserId == User.Id).ToList();
        }
        public ReportsForm(User user)
        {
            InitializeComponent();
            Context = new DietaEntities();
            User = user;
            CurrentDate = DateTime.Now.Date;
            DailyProgrammes = Context.DailyProgrammes.Where(dp => dp.UserId == User.Id).ToList();
        }


        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbReports.SelectedIndex = -1;
            cmbReports.Items.Add("Calories");
            cmbReports.Items.Add("Burned Calories");
            cmbReports.Items.Add("Net Calories");
            dgvBreakfast.Enabled = false;
            dgvLunch.Enabled = false;
            dgvDinner.Enabled = false;
            dgvSnacks.Enabled = false;
        }

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            List<DailyProgramme> dailyProgrammes = Context.DailyProgrammes.Where(dp => dp.UserId == User.Id).ToList();
            if (cmbReports.SelectedItem.ToString() == "Calories")
            {
                for (int i = 0; i < dailyProgrammes.Count; i++)
                {
                    if (dailyProgrammes[i].Year == currentDate.Year && dailyProgrammes[i].Month == currentDate.Month && dailyProgrammes[i].Day <= currentDate.Day)
                    {
                        chart1.Series["Chart"].Points.AddXY(dailyProgrammes[i].Day + "/" + dailyProgrammes[i].Month + "/" + dailyProgrammes[i].Year, dailyProgrammes[i].TotalCal);
                    }
                }
            }
            else if (cmbReports.SelectedItem.ToString() == "Burned Calories")
            {
                for (int i = 0; i < dailyProgrammes.Count; i++)
                {
                    if (dailyProgrammes[i].Year == currentDate.Year && dailyProgrammes[i].Month == currentDate.Month && dailyProgrammes[i].Day <= currentDate.Day)
                    {
                        chart1.Series["Chart"].Points.AddXY(dailyProgrammes[i].Day + "/" + dailyProgrammes[i].Month + "/" + dailyProgrammes[i].Year, dailyProgrammes[i].TotalBurnedCal);
                    }
                }
            }
            else if (cmbReports.SelectedItem.ToString() == "Net Calories")
            {
                for (int i = 0; i < dailyProgrammes.Count; i++)
                {
                    if (dailyProgrammes[i].Year == currentDate.Year && dailyProgrammes[i].Month == currentDate.Month && dailyProgrammes[i].Day <= currentDate.Day)
                    {
                        chart1.Series["Chart"].Points.AddXY(dailyProgrammes[i].Day + "/" + dailyProgrammes[i].Month + "/" + dailyProgrammes[i].Year, dailyProgrammes[i].NetCal);
                    }
                }
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = dtpReportDate.Value.Date;
            DailyProgramme dailyProgramme = Context.DailyProgrammes.Where(dp => dp.Day == dateTime1.Day && dp.Month == dateTime1.Month && dp.Year == dateTime1.Year).FirstOrDefault();
            if (dailyProgramme!=null)
            {
                dgvBreakfast.DataSource = Context.FoodDetails.Where(fd => fd.DailyProgrammeId == dailyProgramme.Id && fd.MealId == 1).ToList();
                dgvLunch.DataSource = Context.FoodDetails.Where(fd => fd.DailyProgrammeId == dailyProgramme.Id && fd.MealId == 2).ToList();
                dgvDinner.DataSource = Context.FoodDetails.Where(fd => fd.DailyProgrammeId == dailyProgramme.Id && fd.MealId == 3).ToList();
                dgvSnacks.DataSource = Context.FoodDetails.Where(fd => fd.DailyProgrammeId == dailyProgramme.Id && fd.MealId == 4).ToList();

                lblBurnedCalories.Text = dailyProgramme.TotalBurnedCal.ToString();
                lblTotalCalories.Text = dailyProgramme.TotalCal.ToString();
                lblNetCalories.Text = dailyProgramme.NetCal.ToString();
            }
            else
            {
                MessageBox.Show("There is no data for this date! Please try another date.");
            }
        }

        private void btnBackToPersonalMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
