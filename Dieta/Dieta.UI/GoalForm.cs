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
    public partial class GoalForm : Form
    {
        DietaEntities context { get; set; }
        User User;
        public GoalForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public GoalForm(User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            User = user;
        }

        private void ActivityLevelForm_Load(object sender, EventArgs e)
        {
            lblWelcomeGoal.Text = $"Welcome to Dieta {User.Username}. Now is the time to set your goals.";
        }

        private void btnLoseWeight_Click(object sender, EventArgs e)
        {
            btnLoseWeight.BackColor = Color.Blue;
            btnGainingWeight.BackColor = default;
            btnStayingSameWeight.BackColor = default;
        }

        private void btnStayingSameWeight_Click(object sender, EventArgs e)
        {
            btnStayingSameWeight.BackColor = Color.Blue;
            btnGainingWeight.BackColor = default;
            btnLoseWeight.BackColor = default;
        }

        private void btnGainingWeight_Click(object sender, EventArgs e)
        {
            btnGainingWeight.BackColor = Color.Blue;
            btnLoseWeight.BackColor = default;
            btnStayingSameWeight.BackColor = default;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnLoseWeight.BackColor==Color.Blue)
            {
                User.GoalId = 1;
                ActivityLevelForm activityLevelForm = new ActivityLevelForm(User);
                activityLevelForm.Show();
                this.Hide();

            }
            else if(btnStayingSameWeight.BackColor==Color.Blue)
            {
                User.GoalId = 2;
                ActivityLevelForm activityLevelForm = new ActivityLevelForm(User);
                activityLevelForm.Show();
                this.Hide();
            }
            else if (btnGainingWeight.BackColor==Color.Blue)
            {
                User.GoalId = 3;
                ActivityLevelForm activityLevelForm = new ActivityLevelForm(User);
                activityLevelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have not made any choices! You must make a selection before your account can be created. Please mark your goal in Dieta.. ");
            }
        }
    }
}
