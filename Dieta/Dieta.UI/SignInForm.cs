﻿using Dieta.BLL;
using Dieta.DAL.Entity;
using Dieta.Model.Models;
using Dieta.UI.Properties;
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
    public partial class SignInForm : Form
    {
        DietaEntities Context { get; set; }
        User User { get; set; }
        public SignInForm()
        {
            InitializeComponent();
            Context = new DietaEntities();
        }
        public SignInForm(User user)
        {
            InitializeComponent();
            Context = new DietaEntities();
            User = user;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            lblWelcomeSignIn.Text = "Welcome to the exclusive healthy world of Dieta!\n\nLet's begin!";
            rdoFemale.Checked = true;

            ActivityLevel activityLevel = new ActivityLevel() { ActivityLevelName = "Not Active" };
            ActivityLevel activityLevel1 = new ActivityLevel() { ActivityLevelName = "Ligthly Active" };
            ActivityLevel activityLevel2 = new ActivityLevel() { ActivityLevelName = "Active" };
            ActivityLevel activityLevel3 = new ActivityLevel() { ActivityLevelName = "Very Active" };
            Context.ActivityLevels.Add(activityLevel);
            Context.ActivityLevels.Add(activityLevel1);
            Context.ActivityLevels.Add(activityLevel2);
            Context.ActivityLevels.Add(activityLevel3);

            Goal goal = new Goal() { GoalName = "Lose Weight" };
            Goal goal1 = new Goal() { GoalName = "Stay Weight" };
            Goal goal2 = new Goal() { GoalName = "Gain Weight" };

            Context.Goals.Add(goal);
            Context.Goals.Add(goal1);
            Context.Goals.Add(goal2);

            //Category category = new Category() { CategoryName = "Meyve", Description = "Vitaminli şeyler" };
            //Category category1 = new Category() { CategoryName = "Sebze", Description = "Yeşil şeyler" };
            //Context.Categories.Add(category);
            //Context.Categories.Add(category1);

            //Food food = new Food()
            //{
            //    Name = "Elma",
            //    CategoryId = 1,
            //    Calories = 25,
            //    Fat = 25,
            //    Protein = 25,
            //    Sugar = 25,
            //    Carbs = 25,
            //    Sodium = 25
            //};
            //Food food1 = new Food()
            //{
            //    Name = "Armut",
            //    CategoryId = 1,
            //    Calories = 25,
            //    Fat = 25,
            //    Protein = 25,
            //    Sugar = 25,
            //    Carbs = 25,
            //    Sodium = 25
            //};
            //Context.Foods.Add(food);
            //Context.Foods.Add(food1);
            Context.SaveChanges();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(txtWeight.Text.Trim());
                double height = Convert.ToDouble(txtHeight.Text.Trim());
                double result = DietaController.CalculateBMI(rdoMale.Checked == true ? 0 : 1, weight, height);
                //double result = weight / ((height / 100) * (height / 100));
                //lblResult.Text = (result.ToString("0.###"));
                if (result > 0 && result <= 18.5)
                {
                    if (rdoFemale.Checked)
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.skinnywomen;
                        pictureBox2.BackgroundImage = null;
                    }
                    else
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.skinnymen;
                    }
                    lblResult.Text = $"Your BMI {result}.You are below your ideal weight.";
                }
                else if (result > 18.5 && result <= 25)
                {
                    if (rdoFemale.Checked)
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.idealwomen;
                    }
                    else
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.ideal;
                    }
                    lblResult.Text = $"Your BMI {result}.Looks great! you are at your ideal weight.";
                }
                else if (result > 25 && result <= 30)
                {
                    if (rdoFemale.Checked)
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.idealwomen;

                    }
                    else
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.ideal;
                    }
                    lblResult.Text = $"Your BMI {result}.You are above your ideal weight. You can do better. Let's get better with Dieta!";
                }
                else if (result > 30 && result <= 40)
                {
                    if (rdoFemale.Checked)
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.fatwomen;
                    }
                    else
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.fat;
                    }
                    lblResult.Text = $"Your BMI {result}.You are well above your ideal weight! (Obese).How about a healthy life with Dieta?";
                }

                else if (result > 40)
                {
                    if (rdoFemale.Checked)
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.ultrafatwomen;
                    }
                    else
                    {
                        pictureBox2.Image = Dieta.UI.Properties.Resources.wellfat;
                    }
                    lblResult.Text = $"Your BMI {result}.You are well above your ideal weight!(Morbidly Obese) You should get health support!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numerical expressions in the boxes.");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            User user = Context.Users.Where(u => u.Username == username).FirstOrDefault();
            if (user != null)
            {
                password = DietaController.PasswordHash(password);
                if (user.Password == password)
                {
                    PersonalMainForm personalMainForm = new PersonalMainForm(user);
                    personalMainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is incorrect! Please make sure you enter your password correctly.");
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("There is no such user in the database! Please check your username.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void lnkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void lnkComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommentsForm commentsForm = new CommentsForm();
            commentsForm.ShowDialog();
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
