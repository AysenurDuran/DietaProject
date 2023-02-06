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
    public partial class AddFoodForm : Form
    {
        DietaEntities context { get; set; }
        DailyProgramme DailyProgramme { get; set; }
        User User { get; set; }
        //List<Food> foods = new List<Food>();
        //List<Meal> meals = new List<Meal>();
        public AddFoodForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public AddFoodForm(DailyProgramme dailyProgramme, User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            DailyProgramme = dailyProgramme;
            User = user;
        }

        private void AddFoodForm_Load(object sender, EventArgs e)
        {
            cmbMeals.DataSource = context.Meals.ToList();
            cmbMeals.DisplayMember = "MealName";
            cmbMeals.SelectedIndex = -1;
            txtSearchFood.Clear();
            dgvSearchResult.MultiSelect = false;
            dgvAddedFoods.MultiSelect = false;

        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string foodName = null;
            if (!string.IsNullOrEmpty(txtSearchFood.Text.Trim()))
            {
                foodName = txtSearchFood.Text.Trim();
                dgvSearchResult.DataSource = context.Foods.Where(f => f.Name.Contains(foodName)).ToList();
            }
            else
            {
                dgvSearchResult.DataSource = context.Foods.ToList();
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (cmbMeals.SelectedItem != null)
            {
                Meal meal = (Meal)cmbMeals.SelectedItem;
                if (dgvSearchResult.SelectedRows.Count > 0)
                {
                    Food food = (Food)dgvSearchResult.SelectedRows[0].DataBoundItem;
                    FoodDetail foodDetail = new FoodDetail()
                    {
                        DailyProgrammeId = DailyProgramme.Id,
                        FoodId = food.Id,
                        MealId = meal.Id,
                        Portion = Convert.ToInt32(nudPortion.Value)
                    };
                    context.FoodDetails.Add(foodDetail);
                    context.SaveChanges();
                    dgvAddedFoods.DataSource = context.FoodDetails.Where(fd => fd.DailyProgrammeId == DailyProgramme.Id).ToList();
                }
                else
                {
                    MessageBox.Show("You have not made any selection! Please make a selection.");
                }
            }
            else
            {
                MessageBox.Show("Please select a meal for the food you want to add.");
            }
        }

        private void btnCompleteAdding_Click(object sender, EventArgs e)
        {
            try
            {
                DailyProgramme.TotalCal = 0;
                foreach (FoodDetail foodDetail in context.FoodDetails.Where(fd => fd.DailyProgrammeId == DailyProgramme.Id).ToList())
                {
                    DailyProgramme.TotalCal += Convert.ToInt32(context.Foods.Where(f => f.Id == foodDetail.FoodId).FirstOrDefault().Calories*foodDetail.Portion);
                }
                context.DailyProgrammes.Where(dp => dp.Id == DailyProgramme.Id).FirstOrDefault().TotalCal = DailyProgramme.TotalCal;
                context.DailyProgrammes.Where(dp => dp.Id == DailyProgramme.Id).FirstOrDefault().NetCal = DailyProgramme.TotalCal - DailyProgramme.TotalBurnedCal;
                context.SaveChanges();
                PersonalMainForm personalMainForm = new PersonalMainForm(User);
                personalMainForm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry..Something went wrong.");
            }
            
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (dgvAddedFoods.SelectedRows.Count>0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete food?", "Notification", MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    FoodDetail foodDetail = (FoodDetail)dgvAddedFoods.SelectedRows[0].DataBoundItem;
                    context.FoodDetails.Remove(context.FoodDetails.Where(fd => fd.Id == foodDetail.Id).FirstOrDefault());
                    context.SaveChanges();
                    dgvAddedFoods.DataSource = context.FoodDetails.Where(fd => fd.DailyProgrammeId == DailyProgramme.Id).ToList();
                }
            }
            else
            {
                MessageBox.Show("You have not made any selections for delete.");
            }
        }

        private void dgvSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvSearchResult.CurrentCell.RowIndex;
            Food food = (Food)dgvSearchResult.Rows[rowIndex].DataBoundItem;
            lblFoodName.Text = food.Name;
            lblCalories.Text = Math.Round(food.Calories,2).ToString();
            lblFat.Text = Math.Round(food.Fat,2).ToString();
            lblProtein.Text = Math.Round(food.Protein,2).ToString();
            lblCarbs.Text = Math.Round(food.Carbs,2).ToString();
            lblSugar.Text = Math.Round(food.Sugar,2).ToString();
            lblSodium.Text = Math.Round(food.Sodium,2).ToString();

        }

        private void btnBackToPersonalMain_Click(object sender, EventArgs e)
        {
            PersonalMainForm personalMainForm = new PersonalMainForm(User);
            personalMainForm.Show();
            this.Hide();
        }

        private void AddFoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
