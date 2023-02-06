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
    public partial class ActivityLevelForm : Form
    {
        DietaEntities context { get; set; }
        User User { get; set; }
        public ActivityLevelForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public ActivityLevelForm(User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            User = user;
        }
        private void ActivityLevelForm_Load(object sender, EventArgs e)
        {
            lblWelcomeActivityLevel.Text = $"almost done dear {User.Username}.. Finally, there is the activity level";
        }

        private void btnNotVeryActive_Click(object sender, EventArgs e)
        {
            btnNotVeryActive.BackColor = Color.Blue;
            btnLightlyActive.BackColor = default;
            btnActive.BackColor = default;
            btnVeryActive.BackColor = default;
        }

        private void btnLightlyActive_Click(object sender, EventArgs e)
        {
            btnLightlyActive.BackColor = Color.Blue;
            btnNotVeryActive.BackColor = default;
            btnActive.BackColor = default;
            btnVeryActive.BackColor = default;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            btnActive.BackColor = Color.Blue;
            btnNotVeryActive.BackColor = default;
            btnLightlyActive.BackColor = default;
            btnVeryActive.BackColor = default;
        }

        private void btnVeryActive_Click(object sender, EventArgs e)
        {
            btnVeryActive.BackColor = Color.Blue;
            btnNotVeryActive.BackColor = default;
            btnLightlyActive.BackColor = default;
            btnActive.BackColor = default;
        }

        private void btnFinishSignUp_Click(object sender, EventArgs e)
        {
            if (btnNotVeryActive.BackColor==Color.Blue)
            {
                User.ActivityLevelId = 1;
                AddUser(User);
                SignInForm signInForm = new SignInForm(User);
                signInForm.Show();
                this.Hide();

            }
            else if (btnLightlyActive.BackColor==Color.Blue)
            {
                User.ActivityLevelId = 2;
                AddUser(User);
                SignInForm signInForm = new SignInForm(User);
                signInForm.Show();
                this.Hide();
            }
            else if (btnActive.BackColor==Color.Blue)
            {
                User.ActivityLevelId = 3;
                AddUser(User);
                SignInForm signInForm = new SignInForm(User);
                signInForm.Show();
                this.Hide();
            }
            else if (btnVeryActive.BackColor==Color.Blue)
            {
                User.ActivityLevelId = 4;
                AddUser(User);
                SignInForm signInForm = new SignInForm(User);
                signInForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have not made any choices! You must make a selection before your account can be created. Please mark your activity level in Dieta.. ");
            }
        }

        private void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
