namespace Dieta.UI
{
    partial class GoalForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGainingWeight = new System.Windows.Forms.Button();
            this.btnStayingSameWeight = new System.Windows.Forms.Button();
            this.btnLoseWeight = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblWelcomeGoal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Orange;
            this.btnNext.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(179, 341);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(260, 45);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGainingWeight
            // 
            this.btnGainingWeight.BackColor = System.Drawing.Color.Transparent;
            this.btnGainingWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGainingWeight.Location = new System.Drawing.Point(197, 284);
            this.btnGainingWeight.Margin = new System.Windows.Forms.Padding(2);
            this.btnGainingWeight.Name = "btnGainingWeight";
            this.btnGainingWeight.Size = new System.Drawing.Size(220, 35);
            this.btnGainingWeight.TabIndex = 13;
            this.btnGainingWeight.Text = "Gaining Weight";
            this.btnGainingWeight.UseVisualStyleBackColor = false;
            this.btnGainingWeight.Click += new System.EventHandler(this.btnGainingWeight_Click);
            // 
            // btnStayingSameWeight
            // 
            this.btnStayingSameWeight.BackColor = System.Drawing.Color.Transparent;
            this.btnStayingSameWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStayingSameWeight.Location = new System.Drawing.Point(197, 230);
            this.btnStayingSameWeight.Margin = new System.Windows.Forms.Padding(2);
            this.btnStayingSameWeight.Name = "btnStayingSameWeight";
            this.btnStayingSameWeight.Size = new System.Drawing.Size(220, 35);
            this.btnStayingSameWeight.TabIndex = 12;
            this.btnStayingSameWeight.Text = "Staying the Same Weight";
            this.btnStayingSameWeight.UseVisualStyleBackColor = false;
            this.btnStayingSameWeight.Click += new System.EventHandler(this.btnStayingSameWeight_Click);
            // 
            // btnLoseWeight
            // 
            this.btnLoseWeight.BackColor = System.Drawing.Color.Transparent;
            this.btnLoseWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoseWeight.Location = new System.Drawing.Point(197, 176);
            this.btnLoseWeight.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoseWeight.Name = "btnLoseWeight";
            this.btnLoseWeight.Size = new System.Drawing.Size(220, 35);
            this.btnLoseWeight.TabIndex = 11;
            this.btnLoseWeight.Text = "Lose Weight";
            this.btnLoseWeight.UseVisualStyleBackColor = false;
            this.btnLoseWeight.Click += new System.EventHandler(this.btnLoseWeight_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(177, 131);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(262, 22);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "What is your goal with DIETA?";
            // 
            // lblWelcomeGoal
            // 
            this.lblWelcomeGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeGoal.Location = new System.Drawing.Point(197, 93);
            this.lblWelcomeGoal.Name = "lblWelcomeGoal";
            this.lblWelcomeGoal.Size = new System.Drawing.Size(220, 28);
            this.lblWelcomeGoal.TabIndex = 15;
            // 
            // GoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewithdieta;
            this.ClientSize = new System.Drawing.Size(493, 495);
            this.Controls.Add(this.lblWelcomeGoal);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGainingWeight);
            this.Controls.Add(this.btnStayingSameWeight);
            this.Controls.Add(this.btnLoseWeight);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoalForm";
            this.Text = "Choose Goal";
            this.Load += new System.EventHandler(this.ActivityLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGainingWeight;
        private System.Windows.Forms.Button btnStayingSameWeight;
        private System.Windows.Forms.Button btnLoseWeight;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblWelcomeGoal;
    }
}