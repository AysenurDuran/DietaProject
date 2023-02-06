using Dieta.DAL.Entity;
using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dieta.UI
{
    public partial class AddExerciseForm : Form
    {
        DietaEntities Context { get; set; }
        User User { get; set; }
        DailyProgramme DailyProgramme { get; set; }
        public AddExerciseForm()
        {
            InitializeComponent();
            Context = new DietaEntities();
        }
        public AddExerciseForm(DailyProgramme dailyProgramme, User user)
        {
            InitializeComponent();
            Context = new DietaEntities();
            User = user;
            DailyProgramme = dailyProgramme;

        }

        private void AddExerciseForm_Load(object sender, EventArgs e)
        {
            pbPhotoOfSport.Image = Dieta.UI.Properties.Resources.fitness;
            cmbExercise.DataSource = Context.Exercises.ToList();
            cmbExercise.DisplayMember = "ExerciseName";
            cmbExercise.SelectedIndex = -1;
            nudDuration.Minimum = 1;
            nudDuration.Maximum = int.MaxValue;
            dgvAddedExercise.MultiSelect = false;
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            if (cmbExercise.SelectedItem!=null)
            {
                Exercise exercise = (Exercise)cmbExercise.SelectedItem;
                ExerciseDetail exerciseDetail = new ExerciseDetail();
                exerciseDetail.ExerciseId = exercise.Id;
                exerciseDetail.Duration = Convert.ToInt32(nudDuration.Value);
                exerciseDetail.DailyProgrammeId = DailyProgramme.Id;
                Context.ExerciseDetails.Add(exerciseDetail);
                Context.SaveChanges();
                dgvAddedExercise.DataSource = Context.ExerciseDetails.ToList();
            }
            else
            {
                MessageBox.Show("You have not selected any exercise! Please select an exercise from the relevant section.");
            }
        }

        private void btnAddingComplete_Click(object sender, EventArgs e)
        {
            try
            {
                DailyProgramme.TotalBurnedCal = 0;
                foreach (ExerciseDetail exerciseDetail in Context.ExerciseDetails.Where(ed => ed.DailyProgrammeId == DailyProgramme.Id).ToList())
                {
                    DailyProgramme.TotalBurnedCal += Convert.ToInt32(Context.Exercises.Where(ex => ex.Id == exerciseDetail.ExerciseId).FirstOrDefault().BurnCaloriesPerMinute * exerciseDetail.Duration);
                }
                Context.DailyProgrammes.Where(dp => dp.Id == DailyProgramme.Id).FirstOrDefault().TotalBurnedCal = DailyProgramme.TotalBurnedCal;
                Context.DailyProgrammes.Where(dp => dp.Id == DailyProgramme.Id).FirstOrDefault().NetCal = DailyProgramme.TotalCal-DailyProgramme.TotalBurnedCal;
                Context.SaveChanges();
                PersonalMainForm personalMainForm = new PersonalMainForm(User);
                personalMainForm.Show();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Sorry..Something went wrong.");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddedExercise.SelectedRows.Count>0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete exercise?","Notification",MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    ExerciseDetail exerciseDetail = (ExerciseDetail)dgvAddedExercise.SelectedRows[0].DataBoundItem;
                    Context.ExerciseDetails.Remove(Context.ExerciseDetails.Where(ed => ed.Id == exerciseDetail.Id).FirstOrDefault());
                    Context.SaveChanges();
                    dgvAddedExercise.DataSource = Context.ExerciseDetails.Where(ed => ed.DailyProgrammeId == DailyProgramme.Id).ToList();
                }
            }
            else
            {
                MessageBox.Show("You have not made any selections for delete.");
            }
        }

        private void btnBackToPersonalMain_Click(object sender, EventArgs e)
        {
            PersonalMainForm personalMainForm = new PersonalMainForm(User);
            personalMainForm.Show();
            this.Hide();
        }

        private void AddExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
