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
    public partial class SignUpDetailsForm : Form
    {
        DietaEntities context { get; set; }
        User User { get; set; }
        public SignUpDetailsForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public SignUpDetailsForm(User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            User = user;
        }
        private void SignUpDetailsForm_Load(object sender, EventArgs e)
        {
            lblWelcomeSignUpDetails.Text = $"Dear {User.Username}.. We need a little more detailed information to start experiencing Dieta's privileges.";
            rdoFemale.Checked = true;
        }
        private void lnkWhyGender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("We need to know your gender so that we can determine your Basal Metabolic Rate(BMR).","Notification");
        }

        private void btnNextStage_Click(object sender, EventArgs e)
        {
            double height = 0;
            double weight = 0;
            int age = 0;
            double goalOfWeight = 0;
            try
            {
                bool isSuccessHeight = double.TryParse(txtHeight.Text.Trim(),out height);
                bool isSuccessWeight = double.TryParse(txtWeight.Text.Trim(),out weight);
                bool isSuccessAge = int.TryParse(txtAge.Text.Trim(),out age);
                bool isSuccessGoalOfWeight = double.TryParse(txtGoalOfWeight.Text.Trim(),out goalOfWeight);
                if (isSuccessHeight && isSuccessWeight && isSuccessAge && isSuccessGoalOfWeight)
                {
                    User.Height = height;
                    User.Weight = weight;
                    User.Age = age;
                    User.GoalOfWeight = goalOfWeight;
                    if (rdoMale.Checked)
                    {
                        User.Gender = "Male";
                    }
                    else
                    {
                        User.Gender = "Female";
                    }
                    GoalForm goalForm = new GoalForm(User);
                    goalForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Make sure that the values ​​you enter are numeric values.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong! Please try again later.");
            }
        }


    }
}
