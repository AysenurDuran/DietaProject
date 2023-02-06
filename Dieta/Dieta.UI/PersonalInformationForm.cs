using Dieta.BLL;
using Dieta.DAL.Entity;
using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dieta.UI
{
    public partial class PersonalInformationForm : Form
    {
        DietaEntities context { get; set; }
        User User { get; set; }
        public PersonalInformationForm()
        {
            InitializeComponent();
            context = new DietaEntities();
        }
        public PersonalInformationForm(User user)
        {
            InitializeComponent();
            context = new DietaEntities();
            User = user;
        }

        private void lnkPasswordChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm(User);
            passwordChangeForm.Show();
            this.Close();
        }

        private void PersonalInformationForm_Load(object sender, EventArgs e)
        {
            rdoFemale.Checked = true;
            txtUsername.Text = User.Username;
            txtFullname.Text = User.Fullname;
            txtEmail.Text = User.Email;
            if (User.BirthDate != null)
            {
                dtpBirthDate.Value = (DateTime)User.BirthDate;
            }
            else
            {
                dtpBirthDate.Value = DateTime.Now.Date;
            }
            txtAdress.Text = User.Adress;
            txtAboutMe.Text = User.AboutMe;
            txtHeight.Text = User.Height.ToString();
            txtWeight.Text = User.Weight.ToString();
            txtGoalOfWeight.Text = User.GoalOfWeight.ToString();
            txtGoalOfWeight.Text = User.GoalOfWeight.ToString();
            txtAge.Text = User.Age.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (context.Users.Where(u => u.Id == User.Id).FirstOrDefault()!=null)
            {
                double height;
                double weight;
                double goalOfWeight;
                int age;
                if (DietaController.CheckEmailRules(txtEmail.Text.Trim()) && dtpBirthDate.Value < DateTime.Now.Date && double.TryParse(txtHeight.Text.Trim(), out height) && double.TryParse(txtWeight.Text.Trim(), out weight) && double.TryParse(txtGoalOfWeight.Text.Trim(), out goalOfWeight) && int.TryParse(txtAge.Text.Trim(), out age))
                {
                    User.Fullname = txtFullname.Text;
                    User.Email = txtEmail.Text.Trim();
                    User.BirthDate = dtpBirthDate.Value.Date;
                    User.Adress = txtAdress.Text;
                    User.AboutMe = txtAboutMe.Text;
                    User.Height = Convert.ToDouble(txtHeight.Text.Trim());
                    User.Weight = Convert.ToDouble(txtWeight.Text.Trim());
                    User.GoalOfWeight = Convert.ToDouble(txtGoalOfWeight.Text.Trim());
                    User.Age = Convert.ToInt32(txtAge.Text.Trim());
                    if (rdoMale.Checked)
                    {
                        User.Gender = "Male";
                    }
                    else
                    {
                        User.Gender = "Female";
                    }
                    context.Users.AddOrUpdate(User);
                    context.SaveChanges();
                    MessageBox.Show("Changes have been saved successfully..");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The e-mail address you entered does not comply with the e-mail rules.");
                }
            }     
        }

        private void btnBackToPersonalMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
