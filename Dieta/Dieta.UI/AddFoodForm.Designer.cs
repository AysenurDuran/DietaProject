namespace Dieta.UI
{
    partial class AddFoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFoodForm));
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.lblChooseMeal = new System.Windows.Forms.Label();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnCompleteAdding = new System.Windows.Forms.Button();
            this.dgvAddedFoods = new System.Windows.Forms.DataGridView();
            this.nudPortion = new System.Windows.Forms.NumericUpDown();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblSodium = new System.Windows.Forms.Label();
            this.btnBackToPersonalMain = new System.Windows.Forms.Button();
            this.pbFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(191, 127);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(161, 23);
            this.txtSearchFood.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(188, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Name :";
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(358, 127);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFood.TabIndex = 2;
            this.btnSearchFood.Text = "Search";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(191, 156);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.Size = new System.Drawing.Size(240, 128);
            this.dgvSearchResult.TabIndex = 3;
            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellContentClick);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(356, 290);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cmbMeals
            // 
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(191, 80);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(161, 24);
            this.cmbMeals.TabIndex = 4;
            // 
            // lblChooseMeal
            // 
            this.lblChooseMeal.AutoSize = true;
            this.lblChooseMeal.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseMeal.Location = new System.Drawing.Point(188, 60);
            this.lblChooseMeal.Name = "lblChooseMeal";
            this.lblChooseMeal.Size = new System.Drawing.Size(111, 17);
            this.lblChooseMeal.TabIndex = 5;
            this.lblChooseMeal.Text = "Choose Meal :";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(458, 460);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(66, 29);
            this.btnDeleteFood.TabIndex = 2;
            this.btnDeleteFood.Text = "Delete";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnCompleteAdding
            // 
            this.btnCompleteAdding.Location = new System.Drawing.Point(530, 460);
            this.btnCompleteAdding.Name = "btnCompleteAdding";
            this.btnCompleteAdding.Size = new System.Drawing.Size(168, 29);
            this.btnCompleteAdding.TabIndex = 2;
            this.btnCompleteAdding.Text = "Complete Adding";
            this.btnCompleteAdding.UseVisualStyleBackColor = true;
            this.btnCompleteAdding.Click += new System.EventHandler(this.btnCompleteAdding_Click);
            // 
            // dgvAddedFoods
            // 
            this.dgvAddedFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedFoods.Location = new System.Drawing.Point(458, 156);
            this.dgvAddedFoods.Name = "dgvAddedFoods";
            this.dgvAddedFoods.Size = new System.Drawing.Size(240, 298);
            this.dgvAddedFoods.TabIndex = 3;
            // 
            // nudPortion
            // 
            this.nudPortion.Location = new System.Drawing.Point(292, 290);
            this.nudPortion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPortion.Name = "nudPortion";
            this.nudPortion.Size = new System.Drawing.Size(49, 23);
            this.nudPortion.TabIndex = 6;
            this.nudPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFoodName
            // 
            this.lblFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodName.Location = new System.Drawing.Point(191, 329);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(240, 27);
            this.lblFoodName.TabIndex = 7;
            this.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(317, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calories :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(353, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(324, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Protein :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(334, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carbs :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(333, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sugar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(323, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sodium :";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.BackColor = System.Drawing.Color.Transparent;
            this.lblCalories.Location = new System.Drawing.Point(399, 356);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(17, 17);
            this.lblCalories.TabIndex = 7;
            this.lblCalories.Text = "0";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.BackColor = System.Drawing.Color.Transparent;
            this.lblFat.Location = new System.Drawing.Point(399, 379);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(17, 17);
            this.lblFat.TabIndex = 7;
            this.lblFat.Text = "0";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.Location = new System.Drawing.Point(399, 402);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(17, 17);
            this.lblProtein.TabIndex = 7;
            this.lblProtein.Text = "0";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.BackColor = System.Drawing.Color.Transparent;
            this.lblCarbs.Location = new System.Drawing.Point(399, 425);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(17, 17);
            this.lblCarbs.TabIndex = 7;
            this.lblCarbs.Text = "0";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.BackColor = System.Drawing.Color.Transparent;
            this.lblSugar.Location = new System.Drawing.Point(399, 448);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(17, 17);
            this.lblSugar.TabIndex = 7;
            this.lblSugar.Text = "0";
            // 
            // lblSodium
            // 
            this.lblSodium.AutoSize = true;
            this.lblSodium.BackColor = System.Drawing.Color.Transparent;
            this.lblSodium.Location = new System.Drawing.Point(399, 471);
            this.lblSodium.Name = "lblSodium";
            this.lblSodium.Size = new System.Drawing.Size(17, 17);
            this.lblSodium.TabIndex = 7;
            this.lblSodium.Text = "0";
            // 
            // btnBackToPersonalMain
            // 
            this.btnBackToPersonalMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToPersonalMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPersonalMain.Image")));
            this.btnBackToPersonalMain.Location = new System.Drawing.Point(12, 455);
            this.btnBackToPersonalMain.Name = "btnBackToPersonalMain";
            this.btnBackToPersonalMain.Size = new System.Drawing.Size(56, 38);
            this.btnBackToPersonalMain.TabIndex = 20;
            this.btnBackToPersonalMain.UseVisualStyleBackColor = false;
            this.btnBackToPersonalMain.Click += new System.EventHandler(this.btnBackToPersonalMain_Click);
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(191, 359);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(115, 134);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 21;
            this.pbFood.TabStop = false;
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewidescreen;
            this.ClientSize = new System.Drawing.Size(716, 501);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.btnBackToPersonalMain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSodium);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.nudPortion);
            this.Controls.Add(this.lblChooseMeal);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.dgvAddedFoods);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.btnCompleteAdding);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchFood);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddFoodForm";
            this.Text = "AddFoodForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFoodForm_FormClosing);
            this.Load += new System.EventHandler(this.AddFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.Label lblChooseMeal;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnCompleteAdding;
        private System.Windows.Forms.DataGridView dgvAddedFoods;
        private System.Windows.Forms.NumericUpDown nudPortion;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblSodium;
        private System.Windows.Forms.Button btnBackToPersonalMain;
        private System.Windows.Forms.PictureBox pbFood;
    }
}