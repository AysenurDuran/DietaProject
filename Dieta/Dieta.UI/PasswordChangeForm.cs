using Dieta.BLL;
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
using static System.Net.Mime.MediaTypeNames;

namespace Dieta.UI
{
    public partial class PasswordChangeForm : Form
    {
        User User { get; set; }
        public PasswordChangeForm()
        {
            InitializeComponent();
        }
        public PasswordChangeForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            lblWelcomeChangePassword.Text = $"Welcome to the password change section dear {User.Username}. Do not forget to set your password in accordance with the password rules.";
            txtOldPassword.PasswordChar = '*';
            txtPassword.PasswordChar = '*';
            txtRePassword.PasswordChar = '*';
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text==txtOldPassword.Text.Trim() && txtPassword.Text==txtPassword.Text.Trim()&&txtRePassword.Text==txtRePassword.Text.Trim())
            {
                string oldPassword = txtOldPassword.Text;
                string password = txtPassword.Text;
                string rePassword = txtRePassword.Text;
                if (DietaController.PasswordHash(oldPassword)==User.Password)
                {
                    if (password==rePassword)
                    {
                        if (DietaController.CheckPasswordRules(password))
                        {
                            User.Password = DietaController.PasswordHash(password);
                            MessageBox.Show("Password change has been successfully completed.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The password you entered does not comply with the password rules! Please set a password that complies with the password rules.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and re-password do not match! Please check these boxes.");
                    }
                }
            }
            
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = default;
                txtRePassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRePassword.PasswordChar = '*';
            }
        }
    }
}
