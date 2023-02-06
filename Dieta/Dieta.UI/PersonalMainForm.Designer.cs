namespace Dieta.UI
{
    partial class PersonalMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalMainForm));
            this.btnMyHome = new System.Windows.Forms.Button();
            this.lblPersonalPageText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWaterNotification = new System.Windows.Forms.Label();
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.progressBarCurrentCal = new System.Windows.Forms.ProgressBar();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNetCalories = new System.Windows.Forms.Label();
            this.lblExerciseCalories = new System.Windows.Forms.Label();
            this.lblFoodCalories = new System.Windows.Forms.Label();
            this.lblGoalOfCalories = new System.Windows.Forms.Label();
            this.lblRemainingCalories = new System.Windows.Forms.Label();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnPersonalInformation = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSafeExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudWater = new System.Windows.Forms.NumericUpDown();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyHome
            // 
            this.btnMyHome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMyHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMyHome.Image = global::Dieta.UI.Properties.Resources.backgroundimage;
            this.btnMyHome.Location = new System.Drawing.Point(0, 112);
            this.btnMyHome.Name = "btnMyHome";
            this.btnMyHome.Size = new System.Drawing.Size(173, 48);
            this.btnMyHome.TabIndex = 0;
            this.btnMyHome.Text = "My Home";
            this.btnMyHome.UseVisualStyleBackColor = false;
            // 
            // lblPersonalPageText
            // 
            this.lblPersonalPageText.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalPageText.Location = new System.Drawing.Point(174, -1);
            this.lblPersonalPageText.Name = "lblPersonalPageText";
            this.lblPersonalPageText.Size = new System.Drawing.Size(618, 57);
            this.lblPersonalPageText.TabIndex = 1;
            this.lblPersonalPageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCurrentProgress);
            this.groupBox1.Controls.Add(this.progressBarCurrentCal);
            this.groupBox1.Controls.Add(this.pbUserPhoto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNetCalories);
            this.groupBox1.Controls.Add(this.lblExerciseCalories);
            this.groupBox1.Controls.Add(this.lblFoodCalories);
            this.groupBox1.Controls.Add(this.lblGoalOfCalories);
            this.groupBox1.Controls.Add(this.lblRemainingCalories);
            this.groupBox1.Controls.Add(this.btnAddExercise);
            this.groupBox1.Controls.Add(this.btnAddFood);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(188, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Daily Summary";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "||||||||||||";
            // 
            // lblWaterNotification
            // 
            this.lblWaterNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblWaterNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaterNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWaterNotification.Location = new System.Drawing.Point(297, 375);
            this.lblWaterNotification.Name = "lblWaterNotification";
            this.lblWaterNotification.Size = new System.Drawing.Size(485, 44);
            this.lblWaterNotification.TabIndex = 3;
            this.lblWaterNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentProgress.Location = new System.Drawing.Point(310, 253);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(21, 24);
            this.lblCurrentProgress.TabIndex = 7;
            this.lblCurrentProgress.Text = "0";
            // 
            // progressBarCurrentCal
            // 
            this.progressBarCurrentCal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBarCurrentCal.Location = new System.Drawing.Point(100, 220);
            this.progressBarCurrentCal.Name = "progressBarCurrentCal";
            this.progressBarCurrentCal.Size = new System.Drawing.Size(475, 25);
            this.progressBarCurrentCal.TabIndex = 6;
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUserPhoto.Image = global::Dieta.UI.Properties.Resources.unknownuser;
            this.pbUserPhoto.Location = new System.Drawing.Point(6, 21);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(87, 102);
            this.pbUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPhoto.TabIndex = 5;
            this.pbUserPhoto.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(409, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "NET";
            // 
            // lblRemaining
            // 
            this.lblRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRemaining.Location = new System.Drawing.Point(99, 92);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(77, 20);
            this.lblRemaining.TabIndex = 3;
            this.lblRemaining.Text = "REMAINING";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(280, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "EXERCISE";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(182, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "FOOD";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(99, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "GOAL";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(362, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(253, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-------------";
            // 
            // lblNetCalories
            // 
            this.lblNetCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNetCalories.Location = new System.Drawing.Point(409, 123);
            this.lblNetCalories.Name = "lblNetCalories";
            this.lblNetCalories.Size = new System.Drawing.Size(65, 59);
            this.lblNetCalories.TabIndex = 0;
            this.lblNetCalories.Text = "Net";
            this.lblNetCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExerciseCalories
            // 
            this.lblExerciseCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExerciseCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblExerciseCalories.Location = new System.Drawing.Point(280, 123);
            this.lblExerciseCalories.Name = "lblExerciseCalories";
            this.lblExerciseCalories.Size = new System.Drawing.Size(65, 59);
            this.lblExerciseCalories.TabIndex = 0;
            this.lblExerciseCalories.Text = "Exercise";
            this.lblExerciseCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodCalories
            // 
            this.lblFoodCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoodCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFoodCalories.Location = new System.Drawing.Point(182, 123);
            this.lblFoodCalories.Name = "lblFoodCalories";
            this.lblFoodCalories.Size = new System.Drawing.Size(65, 59);
            this.lblFoodCalories.TabIndex = 0;
            this.lblFoodCalories.Text = "Food";
            this.lblFoodCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoalOfCalories
            // 
            this.lblGoalOfCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoalOfCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGoalOfCalories.Location = new System.Drawing.Point(99, 123);
            this.lblGoalOfCalories.Name = "lblGoalOfCalories";
            this.lblGoalOfCalories.Size = new System.Drawing.Size(65, 59);
            this.lblGoalOfCalories.TabIndex = 0;
            this.lblGoalOfCalories.Text = "Goal";
            this.lblGoalOfCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingCalories
            // 
            this.lblRemainingCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRemainingCalories.Location = new System.Drawing.Point(99, 33);
            this.lblRemainingCalories.Name = "lblRemainingCalories";
            this.lblRemainingCalories.Size = new System.Drawing.Size(100, 59);
            this.lblRemainingCalories.TabIndex = 0;
            this.lblRemainingCalories.Text = "Remaining";
            this.lblRemainingCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.Color.Orange;
            this.btnAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddExercise.Location = new System.Drawing.Point(439, 43);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(137, 39);
            this.btnAddExercise.TabIndex = 0;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Orange;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFood.Location = new System.Drawing.Point(275, 43);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(137, 39);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnPersonalInformation
            // 
            this.btnPersonalInformation.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPersonalInformation.Image = global::Dieta.UI.Properties.Resources.backgroundimage;
            this.btnPersonalInformation.Location = new System.Drawing.Point(0, 192);
            this.btnPersonalInformation.Name = "btnPersonalInformation";
            this.btnPersonalInformation.Size = new System.Drawing.Size(173, 49);
            this.btnPersonalInformation.TabIndex = 0;
            this.btnPersonalInformation.Text = "My Personal Informations";
            this.btnPersonalInformation.UseVisualStyleBackColor = false;
            this.btnPersonalInformation.Click += new System.EventHandler(this.btnPersonalInformation_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReports.Image = global::Dieta.UI.Properties.Resources.backgroundimage;
            this.btnReports.Location = new System.Drawing.Point(0, 272);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(173, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSafeExit
            // 
            this.btnSafeExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSafeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSafeExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSafeExit.Image = global::Dieta.UI.Properties.Resources.backgroundimage;
            this.btnSafeExit.Location = new System.Drawing.Point(0, 444);
            this.btnSafeExit.Name = "btnSafeExit";
            this.btnSafeExit.Size = new System.Drawing.Size(173, 54);
            this.btnSafeExit.TabIndex = 3;
            this.btnSafeExit.Text = "<== Exit";
            this.btnSafeExit.UseVisualStyleBackColor = false;
            this.btnSafeExit.Click += new System.EventHandler(this.btnSafeExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dieta.UI.Properties.Resources.water;
            this.pictureBox1.Location = new System.Drawing.Point(188, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nudWater
            // 
            this.nudWater.Location = new System.Drawing.Point(300, 422);
            this.nudWater.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(67, 23);
            this.nudWater.TabIndex = 5;
            this.nudWater.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddWater
            // 
            this.btnAddWater.BackColor = System.Drawing.Color.Orange;
            this.btnAddWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddWater.Location = new System.Drawing.Point(300, 451);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(67, 35);
            this.btnAddWater.TabIndex = 6;
            this.btnAddWater.Text = "Add";
            this.btnAddWater.UseVisualStyleBackColor = false;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // PersonalMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 498);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.nudWater);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSafeExit);
            this.Controls.Add(this.lblWaterNotification);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPersonalPageText);
            this.Controls.Add(this.btnPersonalInformation);
            this.Controls.Add(this.btnMyHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonalMainForm";
            this.Text = "Personal Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonalMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyHome;
        private System.Windows.Forms.Label lblPersonalPageText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNetCalories;
        private System.Windows.Forms.Label lblExerciseCalories;
        private System.Windows.Forms.Label lblFoodCalories;
        private System.Windows.Forms.Label lblGoalOfCalories;
        private System.Windows.Forms.Label lblRemainingCalories;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaterNotification;
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.ProgressBar progressBarCurrentCal;
        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Button btnPersonalInformation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSafeExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudWater;
        private System.Windows.Forms.Button btnAddWater;
    }
}