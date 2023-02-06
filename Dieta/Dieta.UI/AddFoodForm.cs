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
                    DailyProgramme.TotalCal += Convert.ToInt32(context.Foods.Where(f => f.Id == foodDetail.FoodId).FirstOrDefault().Calories * foodDetail.Portion);
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
            if (dgvAddedFoods.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete food?", "Notification", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
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
            lblCalories.Text = Math.Round(food.Calories, 2).ToString();
            lblFat.Text = Math.Round(food.Fat, 2).ToString();
            lblProtein.Text = Math.Round(food.Protein, 2).ToString();
            lblCarbs.Text = Math.Round(food.Carbs, 2).ToString();
            lblSugar.Text = Math.Round(food.Sugar, 2).ToString();
            lblSodium.Text = Math.Round(food.Sodium, 2).ToString();

            #region FoodPhotos
            switch (food.Id)
            {
                case 1:
                    pbFood.Image = Dieta.UI.Properties.Resources._001_Raspberry;
                    break;
                case 2:
                    pbFood.Image = Dieta.UI.Properties.Resources._002_Pineapple;
                    break;
                case 3:
                    pbFood.Image = Dieta.UI.Properties.Resources._003_Blueberry;
                    break;
                case 4:
                    pbFood.Image = Dieta.UI.Properties.Resources._004_Avocado;
                    break;
                case 5:
                    pbFood.Image = Dieta.UI.Properties.Resources._005_Apple;
                    break;
                case 6:
                    pbFood.Image = Dieta.UI.Properties.Resources._006_Banana;
                    break;
                case 7:
                    pbFood.Image = Dieta.UI.Properties.Resources._007_Grape;
                    break;
                case 8:
                    pbFood.Image = Dieta.UI.Properties.Resources._008_Pear;
                    break;
                case 9:
                    pbFood.Image = Dieta.UI.Properties.Resources._009_Orange;
                    break;
                case 10:
                    pbFood.Image = Dieta.UI.Properties.Resources._010_Fig;
                    break;
                case 11:
                    pbFood.Image = Dieta.UI.Properties.Resources._011_Plum;
                    break;
                case 12:
                    pbFood.Image = Dieta.UI.Properties.Resources._012_Cherry;
                    break;
                case 13:
                    pbFood.Image = Dieta.UI.Properties.Resources._013_Sourcherry;
                    break;
                case 14:
                    pbFood.Image = Dieta.UI.Properties.Resources._014_Apricot;
                    break;
                case 15:
                    pbFood.Image = Dieta.UI.Properties.Resources._015_Tangerine;
                    break;
                case 16:
                    pbFood.Image = Dieta.UI.Properties.Resources._016_Peach;
                    break;
                case 17:
                    pbFood.Image = Dieta.UI.Properties.Resources._017_Strawberry;
                    break;
                case 18:
                    pbFood.Image = Dieta.UI.Properties.Resources._018_Melon;
                    break;
                case 19:
                    pbFood.Image = Dieta.UI.Properties.Resources._019_Lemon;
                    break;
                case 20:
                    pbFood.Image = Dieta.UI.Properties.Resources._020_Watermelon;
                    break;
                case 21:
                    pbFood.Image = Dieta.UI.Properties.Resources._021_Corn;
                    break;
                case 22:
                    pbFood.Image = Dieta.UI.Properties.Resources._022_Pea;
                    break;
                case 23:
                    pbFood.Image = Dieta.UI.Properties.Resources._023_BoiledPotato;
                    break;
                case 24:
                    pbFood.Image = Dieta.UI.Properties.Resources._024_Leek;
                    break;
                case 25:
                    pbFood.Image = Dieta.UI.Properties.Resources._025_Beet;
                    break;
                case 26:
                    pbFood.Image = Dieta.UI.Properties.Resources._026_Carrot;
                    break;
                case 27:
                    pbFood.Image = Dieta.UI.Properties.Resources._027_Celery;
                    break;
                case 28:
                    pbFood.Image = Dieta.UI.Properties.Resources._028_Onion;
                    break;
                case 29:
                    pbFood.Image = Dieta.UI.Properties.Resources._029_Bean;
                    break;
                case 30:
                    pbFood.Image = Dieta.UI.Properties.Resources._030_Mushroom;
                    break;
                case 31:
                    pbFood.Image = Dieta.UI.Properties.Resources._031_Cauli;
                    break;
                case 32:
                    pbFood.Image = Dieta.UI.Properties.Resources._032_Spinach;
                    break;
                case 33:
                    pbFood.Image = Dieta.UI.Properties.Resources._033_Cabbage;
                    break;
                case 34:
                    pbFood.Image = Dieta.UI.Properties.Resources._034_Paprika;
                    break;
                case 35:
                    pbFood.Image = Dieta.UI.Properties.Resources._035_Tomato;
                    break;
                case 36:
                    pbFood.Image = Dieta.UI.Properties.Resources._036_Radish;
                    break;
                case 37:
                    pbFood.Image = Dieta.UI.Properties.Resources._037_Cucumber;
                    break;
                case 38:
                    pbFood.Image = Dieta.UI.Properties.Resources._038_BakedBean;
                    break;
                case 39:
                    pbFood.Image = Dieta.UI.Properties.Resources._039_PeawithCarrot;
                    break;
                case 40:
                    pbFood.Image = Dieta.UI.Properties.Resources._040_Hummus;
                    break;
                case 41:
                    pbFood.Image = Dieta.UI.Properties.Resources._041_SteamedArtichoke;
                    break;
                case 42:
                    pbFood.Image = Dieta.UI.Properties.Resources._042_Sultan_sDelight;
                    break;
                case 43:
                    pbFood.Image = Dieta.UI.Properties.Resources._043_MincedBeefPide;
                    break;
                case 44:
                    pbFood.Image = Dieta.UI.Properties.Resources._045_SteamedCelery;
                    break;
                case 45:
                    pbFood.Image = Dieta.UI.Properties.Resources._045_SteamedCelery;
                    break;
                case 46:
                    pbFood.Image = Dieta.UI.Properties.Resources._046_PotatoSalad;
                    break;
                case 47:
                    pbFood.Image = Dieta.UI.Properties.Resources._047_AdanaKebab;
                    break;
                case 48:
                    pbFood.Image = Dieta.UI.Properties.Resources._048_BulgurPilaf;
                    break;
                case 49:
                    pbFood.Image = Dieta.UI.Properties.Resources._049_MixedPidewithCheese;
                    break;
                case 50:
                    pbFood.Image = Dieta.UI.Properties.Resources._050_Lasagna;
                    break;
                case 51:
                    pbFood.Image = Dieta.UI.Properties.Resources._051_StuffedGrapeLeave;
                    break;
                case 52:
                    pbFood.Image = Dieta.UI.Properties.Resources._052_PastawithCheese;
                    break;
                case 53:
                    pbFood.Image = Dieta.UI.Properties.Resources._053_SaladwithGrilledChicken;
                    break;
                case 54:
                    pbFood.Image = Dieta.UI.Properties.Resources._054_StuffedPeppersMincedMeat;
                    break;
                case 55:
                    pbFood.Image = Dieta.UI.Properties.Resources._055_GreenRunnerBean;
                    break;
                case 56:
                    pbFood.Image = Dieta.UI.Properties.Resources._056_EggplantwithMincedMeat;
                    break;
                case 57:
                    pbFood.Image = Dieta.UI.Properties.Resources._057_Octopus;
                    break;
                case 58:
                    pbFood.Image = Dieta.UI.Properties.Resources._058_Shrimp;
                    break;
                case 59:
                    pbFood.Image = Dieta.UI.Properties.Resources._059_FriedCalamaris;
                    break;
                case 60:
                    pbFood.Image = Dieta.UI.Properties.Resources._060_StuffedMussel;
                    break;
                case 61:
                    pbFood.Image = Dieta.UI.Properties.Resources._061_Fried_Anchovies;
                    break;
                case 62:
                    pbFood.Image = Dieta.UI.Properties.Resources._062_Salmon;
                    break;
                case 63:
                    pbFood.Image = Dieta.UI.Properties.Resources._063_Bonito;
                    break;
                case 64:
                    pbFood.Image = Dieta.UI.Properties.Resources._064_SeaBass;
                    break;
                case 65:
                    pbFood.Image = Dieta.UI.Properties.Resources._065_Bream;
                    break;
                case 66:
                    pbFood.Image = Dieta.UI.Properties.Resources._066_Mackerel;
                    break;
                case 67:
                    pbFood.Image = Dieta.UI.Properties.Resources._067_RedMullet;
                    break;
                case 68:
                    pbFood.Image = Dieta.UI.Properties.Resources._068_Pork;
                    break;
                case 69:
                    pbFood.Image = Dieta.UI.Properties.Resources._069_Duck;
                    break;
                case 70:
                    pbFood.Image = Dieta.UI.Properties.Resources._070_Mutton;
                    break;
                case 71:
                    pbFood.Image = Dieta.UI.Properties.Resources._071_Beef;
                    break;
                case 72:
                    pbFood.Image = Dieta.UI.Properties.Resources._072_LambChop;
                    break;
                case 73:
                    pbFood.Image = Dieta.UI.Properties.Resources._073_ChickenBreast;
                    break;
                case 74:
                    pbFood.Image = Dieta.UI.Properties.Resources._074_TurkeyBreast;
                    break;
                case 75:
                    pbFood.Image = Dieta.UI.Properties.Resources._075_Steak;
                    break;
                case 76:
                    pbFood.Image = Dieta.UI.Properties.Resources._076_KasharCheese;
                    break;
                case 77:
                    pbFood.Image = Dieta.UI.Properties.Resources._077_CreamCheese;
                    break;
                case 78:
                    pbFood.Image = Dieta.UI.Properties.Resources._078_StringCheese;
                    break;
                case 79:
                    pbFood.Image = Dieta.UI.Properties.Resources._079_WhiteCheese;
                    break;
                case 80:
                    pbFood.Image = Dieta.UI.Properties.Resources._080_Bryndza;
                    break;
                case 81:
                    pbFood.Image = Dieta.UI.Properties.Resources._081_SheepMilk;
                    break;
                case 82:
                    pbFood.Image = Dieta.UI.Properties.Resources._082_CurdCheese;
                    break;
                case 83:
                    pbFood.Image = Dieta.UI.Properties.Resources._083_Yoghurt;
                    break;
                case 84:
                    pbFood.Image = Dieta.UI.Properties.Resources._084_CowMilk;
                    break;
                case 85:
                    pbFood.Image = Dieta.UI.Properties.Resources._085_Ayran;
                    break;
                case 86:
                    pbFood.Image = Dieta.UI.Properties.Resources._086_SunflowerSeedOil;
                    break;
                case 87:
                    pbFood.Image = Dieta.UI.Properties.Resources._087_OliveOil;
                    break;
                case 88:
                    pbFood.Image = Dieta.UI.Properties.Resources._088_Margarine;
                    break;
                case 89:
                    pbFood.Image = Dieta.UI.Properties.Resources._089_Butter;
                    break;
                case 90:
                    pbFood.Image = Dieta.UI.Properties.Resources._090_Mayonnaise;
                    break;
                case 91:
                    pbFood.Image = Dieta.UI.Properties.Resources._091_Mustard;
                    break;
                case 92:
                    pbFood.Image = Dieta.UI.Properties.Resources._092_Ketchup;
                    break;
                case 93:
                    pbFood.Image = Dieta.UI.Properties.Resources._093_Phyllo;
                    break;
                case 94:
                    pbFood.Image = Dieta.UI.Properties.Resources._094_WhiteBread;
                    break;
                case 95:
                    pbFood.Image = Dieta.UI.Properties.Resources._095_RyeBread;
                    break;
                case 96:
                    pbFood.Image = Dieta.UI.Properties.Resources._096_WholeWheatBread;
                    break;
                case 97:
                    pbFood.Image = Dieta.UI.Properties.Resources._097_Walnut;
                    break;
                case 98:
                    pbFood.Image = Dieta.UI.Properties.Resources._098_Hazelnut;
                    break;
                case 99:
                    pbFood.Image = Dieta.UI.Properties.Resources._099_Almond;
                    break;
                case 100:
                    pbFood.Image = Dieta.UI.Properties.Resources._100_Pistachio;
                    break;
                case 101:
                    pbFood.Image = Dieta.UI.Properties.Resources._101_Peanut;
                    break;
                case 102:
                    pbFood.Image = Dieta.UI.Properties.Resources._102_Popcorn;
                    break;
                case 103:
                    pbFood.Image = Dieta.UI.Properties.Resources._103_ChocolateCake;
                    break;
                case 104:
                    pbFood.Image = Dieta.UI.Properties.Resources._104_Biscuit;
                    break;
                case 105:
                    pbFood.Image = Dieta.UI.Properties.Resources._105_ApplePie;
                    break;
                case 106:
                    pbFood.Image = Dieta.UI.Properties.Resources._106_IceCream;
                    break;
                case 107:
                    pbFood.Image = Dieta.UI.Properties.Resources._107_MilkChocolate;
                    break;
                case 108:
                    pbFood.Image = Dieta.UI.Properties.Resources._108_BitterChocolate;
                    break;
                case 109:
                    pbFood.Image = Dieta.UI.Properties.Resources._109_Baklava;
                    break;
                case 110:
                    pbFood.Image = Dieta.UI.Properties.Resources._110_RicePudding;
                    break;
                case 111:
                    pbFood.Image = Dieta.UI.Properties.Resources._101_Peanut;
                    break;
                case 112:
                    pbFood.Image = Dieta.UI.Properties.Resources._112_AppleJuice;
                    break;
                case 113:
                    pbFood.Image = Dieta.UI.Properties.Resources._113_OrangeJuice;
                    break;
                case 114:
                    pbFood.Image = Dieta.UI.Properties.Resources._114_IceTea;
                    break;
                case 115:
                    pbFood.Image = Dieta.UI.Properties.Resources._115_Coffee;
                    break;
                case 116:
                    pbFood.Image = Dieta.UI.Properties.Resources._116_Tea;
                    break;
                case 117:
                    pbFood.Image = Dieta.UI.Properties.Resources._117_GreenTea;
                    break;
            }
            #endregion

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
