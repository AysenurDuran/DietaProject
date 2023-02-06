using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace Dieta.UI
{
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void AboutUsForm_Load(object sender, EventArgs e)
        {
            lblAboutUs.Text = "The prerequisite for a healthy life is a correct and balanced diet. If we look at nutrition in detail, knowing the calories of the foods we consume and avoiding processed foods that contain excessive calories is one of the easiest ways to achieve this balance.Research shows that people who can track calories manage to keep their weight in balance by consuming less calorie foods.\r\nWith Dieta, it is now very easy to keep track of your calories and keep control.We have developed this application that calculates calories for those who pay attention to what they eat.We are a family of three and we are always with you.\r\n'Take care of your body and it will take care of you'";
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
