namespace Dieta.UI
{
    partial class AddExerciseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExerciseForm));
            this.lblChooseExercise = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExercise = new System.Windows.Forms.ComboBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.dgvAddedExercise = new System.Windows.Forms.DataGridView();
            this.lblAddedExercise = new System.Windows.Forms.Label();
            this.btnAddingComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblWelcomeAddExercise = new System.Windows.Forms.Label();
            this.pbPhotoOfSport = new System.Windows.Forms.PictureBox();
            this.btnBackToPersonalMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoOfSport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseExercise
            // 
            this.lblChooseExercise.AutoSize = true;
            this.lblChooseExercise.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseExercise.Location = new System.Drawing.Point(190, 173);
            this.lblChooseExercise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseExercise.Name = "lblChooseExercise";
            this.lblChooseExercise.Size = new System.Drawing.Size(151, 17);
            this.lblChooseExercise.TabIndex = 0;
            this.lblChooseExercise.Text = "Choose a exercise :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(177, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration of exercise :";
            // 
            // cmbExercise
            // 
            this.cmbExercise.FormattingEnabled = true;
            this.cmbExercise.Location = new System.Drawing.Point(348, 166);
            this.cmbExercise.Name = "cmbExercise";
            this.cmbExercise.Size = new System.Drawing.Size(145, 24);
            this.cmbExercise.TabIndex = 3;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(348, 198);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(145, 23);
            this.nudDuration.TabIndex = 4;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(376, 239);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(117, 33);
            this.btnAddExercise.TabIndex = 5;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // dgvAddedExercise
            // 
            this.dgvAddedExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedExercise.Location = new System.Drawing.Point(512, 164);
            this.dgvAddedExercise.Name = "dgvAddedExercise";
            this.dgvAddedExercise.Size = new System.Drawing.Size(300, 225);
            this.dgvAddedExercise.TabIndex = 6;
            // 
            // lblAddedExercise
            // 
            this.lblAddedExercise.AutoSize = true;
            this.lblAddedExercise.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedExercise.Location = new System.Drawing.Point(509, 144);
            this.lblAddedExercise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddedExercise.Name = "lblAddedExercise";
            this.lblAddedExercise.Size = new System.Drawing.Size(130, 17);
            this.lblAddedExercise.TabIndex = 0;
            this.lblAddedExercise.Text = "Added Exercise :";
            // 
            // btnAddingComplete
            // 
            this.btnAddingComplete.Location = new System.Drawing.Point(667, 400);
            this.btnAddingComplete.Name = "btnAddingComplete";
            this.btnAddingComplete.Size = new System.Drawing.Size(145, 33);
            this.btnAddingComplete.TabIndex = 5;
            this.btnAddingComplete.Text = "Adding Complete";
            this.btnAddingComplete.UseVisualStyleBackColor = true;
            this.btnAddingComplete.Click += new System.EventHandler(this.btnAddingComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblWelcomeAddExercise
            // 
            this.lblWelcomeAddExercise.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeAddExercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWelcomeAddExercise.Location = new System.Drawing.Point(190, 104);
            this.lblWelcomeAddExercise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcomeAddExercise.Name = "lblWelcomeAddExercise";
            this.lblWelcomeAddExercise.Size = new System.Drawing.Size(620, 40);
            this.lblWelcomeAddExercise.TabIndex = 7;
            // 
            // pbPhotoOfSport
            // 
            this.pbPhotoOfSport.BackColor = System.Drawing.Color.Transparent;
            this.pbPhotoOfSport.Location = new System.Drawing.Point(193, 283);
            this.pbPhotoOfSport.Name = "pbPhotoOfSport";
            this.pbPhotoOfSport.Size = new System.Drawing.Size(300, 206);
            this.pbPhotoOfSport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotoOfSport.TabIndex = 8;
            this.pbPhotoOfSport.TabStop = false;
            // 
            // btnBackToPersonalMain
            // 
            this.btnBackToPersonalMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToPersonalMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPersonalMain.Image")));
            this.btnBackToPersonalMain.Location = new System.Drawing.Point(12, 451);
            this.btnBackToPersonalMain.Name = "btnBackToPersonalMain";
            this.btnBackToPersonalMain.Size = new System.Drawing.Size(56, 38);
            this.btnBackToPersonalMain.TabIndex = 21;
            this.btnBackToPersonalMain.UseVisualStyleBackColor = false;
            this.btnBackToPersonalMain.Click += new System.EventHandler(this.btnBackToPersonalMain_Click);
            // 
            // AddExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewithdietalogin;
            this.ClientSize = new System.Drawing.Size(823, 501);
            this.Controls.Add(this.btnBackToPersonalMain);
            this.Controls.Add(this.pbPhotoOfSport);
            this.Controls.Add(this.lblWelcomeAddExercise);
            this.Controls.Add(this.dgvAddedExercise);
            this.Controls.Add(this.btnAddingComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.cmbExercise);
            this.Controls.Add(this.lblAddedExercise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChooseExercise);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddExerciseForm";
            this.Text = "Add Exercise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddExerciseForm_FormClosing);
            this.Load += new System.EventHandler(this.AddExerciseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoOfSport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExercise;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.DataGridView dgvAddedExercise;
        private System.Windows.Forms.Label lblAddedExercise;
        private System.Windows.Forms.Button btnAddingComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblWelcomeAddExercise;
        private System.Windows.Forms.PictureBox pbPhotoOfSport;
        private System.Windows.Forms.Button btnBackToPersonalMain;
    }
}