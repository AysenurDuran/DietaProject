namespace Dieta.UI
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(198, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "About Dieta";
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAboutUs.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.ForeColor = System.Drawing.Color.Orange;
            this.lblAboutUs.Location = new System.Drawing.Point(182, 139);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(312, 349);
            this.lblAboutUs.TabIndex = 18;
            this.lblAboutUs.Text = "lblAboutUs";
            this.lblAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToLogin.Image")));
            this.btnBackToLogin.Location = new System.Drawing.Point(12, 450);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(56, 38);
            this.btnBackToLogin.TabIndex = 19;
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewithdietawidescreen;
            this.ClientSize = new System.Drawing.Size(962, 497);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.label2);
            this.Name = "AboutUsForm";
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.AboutUsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}