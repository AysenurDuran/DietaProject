using Dieta.BLL;
using Dieta.DAL.Entity;
using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dieta.UI
{
    public partial class SignUpForm : Form
    {
        DietaEntities context { get; set; }
        User User { get; set; }
        public SignUpForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtRePassword.PasswordChar = '*';
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string email;
            if (!string.IsNullOrEmpty(txtFullname.Text.Trim()) && !string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                if (txtUsername.Text.Trim() == txtUsername.Text && txtPassword.Text.Trim() == txtPassword.Text && txtEmail.Text == txtEmail.Text.Trim())
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    email = txtEmail.Text;
                    if (DietaController.CheckEmailRules(email))
                    {
                        if (context.Users.Where(u => u.Username == username).FirstOrDefault() == null)
                        {
                            if (txtPassword.Text == txtRePassword.Text)
                            {
                                User = new User();
                                User.Username = username;
                                User.Password = DietaController.PasswordHash(password);
                                User.Fullname = txtFullname.Text;
                                User.Email = email;
                                SignUpDetailsForm signUpDetailsForm = new SignUpDetailsForm(User);
                                signUpDetailsForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("The entered passwords do not match! Please enter the same values ​​in both boxes.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This username has already been taken. Please try another username.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address! Please enter your email correctly.");
                    }
                }
                else
                {
                    MessageBox.Show("Your username, password or e-mail cannot contain spaces. Please check your username,password or e-mail.");
                }
            }
            else
            {
                MessageBox.Show("Your username or fullname cannot be left blank! Please fill in the relevant boxes.");
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

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }
    }
}
