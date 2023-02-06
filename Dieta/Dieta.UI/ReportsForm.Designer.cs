﻿namespace Dieta.UI
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.DailyReport = new System.Windows.Forms.TabPage();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.dgvDinner = new System.Windows.Forms.DataGridView();
            this.dgvSnacks = new System.Windows.Forms.DataGridView();
            this.dgvLunch = new System.Windows.Forms.DataGridView();
            this.dgvBreakfast = new System.Windows.Forms.DataGridView();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNetCalories = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBurnedCalories = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Charts = new System.Windows.Forms.TabPage();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.btnBackToPersonalMain = new System.Windows.Forms.Button();
            this.tabControlReports.SuspendLayout();
            this.DailyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).BeginInit();
            this.Charts.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.DailyReport);
            this.tabControlReports.Controls.Add(this.Charts);
            this.tabControlReports.Location = new System.Drawing.Point(1, 1);
            this.tabControlReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(998, 524);
            this.tabControlReports.TabIndex = 0;
            // 
            // DailyReport
            // 
            this.DailyReport.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewidescreen;
            this.DailyReport.Controls.Add(this.btnBackToPersonalMain);
            this.DailyReport.Controls.Add(this.btnGetReport);
            this.DailyReport.Controls.Add(this.dgvDinner);
            this.DailyReport.Controls.Add(this.dgvSnacks);
            this.DailyReport.Controls.Add(this.dgvLunch);
            this.DailyReport.Controls.Add(this.dgvBreakfast);
            this.DailyReport.Controls.Add(this.dtpReportDate);
            this.DailyReport.Controls.Add(this.label7);
            this.DailyReport.Controls.Add(this.label5);
            this.DailyReport.Controls.Add(this.label6);
            this.DailyReport.Controls.Add(this.label4);
            this.DailyReport.Controls.Add(this.lblNetCalories);
            this.DailyReport.Controls.Add(this.label10);
            this.DailyReport.Controls.Add(this.lblBurnedCalories);
            this.DailyReport.Controls.Add(this.lblTotalCalories);
            this.DailyReport.Controls.Add(this.label9);
            this.DailyReport.Controls.Add(this.label8);
            this.DailyReport.Controls.Add(this.label3);
            this.DailyReport.Location = new System.Drawing.Point(4, 25);
            this.DailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.DailyReport.Name = "DailyReport";
            this.DailyReport.Padding = new System.Windows.Forms.Padding(4);
            this.DailyReport.Size = new System.Drawing.Size(990, 495);
            this.DailyReport.TabIndex = 1;
            this.DailyReport.Text = "Daily Calories Report";
            this.DailyReport.UseVisualStyleBackColor = true;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(458, 81);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(104, 31);
            this.btnGetReport.TabIndex = 3;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // dgvDinner
            // 
            this.dgvDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinner.Location = new System.Drawing.Point(590, 138);
            this.dgvDinner.Name = "dgvDinner";
            this.dgvDinner.Size = new System.Drawing.Size(307, 110);
            this.dgvDinner.TabIndex = 2;
            // 
            // dgvSnacks
            // 
            this.dgvSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnacks.Location = new System.Drawing.Point(590, 274);
            this.dgvSnacks.Name = "dgvSnacks";
            this.dgvSnacks.Size = new System.Drawing.Size(307, 120);
            this.dgvSnacks.TabIndex = 2;
            // 
            // dgvLunch
            // 
            this.dgvLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLunch.Location = new System.Drawing.Point(192, 274);
            this.dgvLunch.Name = "dgvLunch";
            this.dgvLunch.Size = new System.Drawing.Size(307, 120);
            this.dgvLunch.TabIndex = 2;
            // 
            // dgvBreakfast
            // 
            this.dgvBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakfast.Location = new System.Drawing.Point(192, 138);
            this.dgvBreakfast.Name = "dgvBreakfast";
            this.dgvBreakfast.Size = new System.Drawing.Size(307, 110);
            this.dgvBreakfast.TabIndex = 2;
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportDate.Location = new System.Drawing.Point(318, 84);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(117, 23);
            this.dtpReportDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Snacks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dinner Foods:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lunch Foods:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Breakfast Foods:";
            // 
            // lblNetCalories
            // 
            this.lblNetCalories.AutoSize = true;
            this.lblNetCalories.Location = new System.Drawing.Point(324, 454);
            this.lblNetCalories.Name = "lblNetCalories";
            this.lblNetCalories.Size = new System.Drawing.Size(17, 17);
            this.lblNetCalories.TabIndex = 0;
            this.lblNetCalories.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Net Calories:";
            // 
            // lblBurnedCalories
            // 
            this.lblBurnedCalories.AutoSize = true;
            this.lblBurnedCalories.Location = new System.Drawing.Point(324, 409);
            this.lblBurnedCalories.Name = "lblBurnedCalories";
            this.lblBurnedCalories.Size = new System.Drawing.Size(17, 17);
            this.lblBurnedCalories.TabIndex = 0;
            this.lblBurnedCalories.Text = "0";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(324, 432);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(17, 17);
            this.lblTotalCalories.TabIndex = 0;
            this.lblTotalCalories.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Burned Calories:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Calories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose a date :";
            // 
            // Charts
            // 
            this.Charts.BackgroundImage = global::Dieta.UI.Properties.Resources.backgroundimagewidescreen;
            this.Charts.Controls.Add(this.groupBoxChart);
            this.Charts.Controls.Add(this.label1);
            this.Charts.Controls.Add(this.cmbReports);
            this.Charts.Location = new System.Drawing.Point(4, 25);
            this.Charts.Margin = new System.Windows.Forms.Padding(4);
            this.Charts.Name = "Charts";
            this.Charts.Padding = new System.Windows.Forms.Padding(4);
            this.Charts.Size = new System.Drawing.Size(990, 495);
            this.Charts.TabIndex = 0;
            this.Charts.Text = "Charts of Calories";
            this.Charts.UseVisualStyleBackColor = true;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.label2);
            this.groupBoxChart.Controls.Add(this.chart1);
            this.groupBoxChart.Location = new System.Drawing.Point(190, 110);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(741, 378);
            this.groupBoxChart.TabIndex = 3;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Chart of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dates";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 22);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Chart";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(729, 350);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Weight Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a report :";
            // 
            // cmbReports
            // 
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(328, 80);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(181, 24);
            this.cmbReports.TabIndex = 0;
            this.cmbReports.SelectedIndexChanged += new System.EventHandler(this.cmbReports_SelectedIndexChanged);
            // 
            // btnBackToPersonalMain
            // 
            this.btnBackToPersonalMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToPersonalMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPersonalMain.Image")));
            this.btnBackToPersonalMain.Location = new System.Drawing.Point(12, 450);
            this.btnBackToPersonalMain.Name = "btnBackToPersonalMain";
            this.btnBackToPersonalMain.Size = new System.Drawing.Size(56, 38);
            this.btnBackToPersonalMain.TabIndex = 56;
            this.btnBackToPersonalMain.UseVisualStyleBackColor = false;
            this.btnBackToPersonalMain.Click += new System.EventHandler(this.btnBackToPersonalMain_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.tabControlReports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tabControlReports.ResumeLayout(false);
            this.DailyReport.ResumeLayout(false);
            this.DailyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).EndInit();
            this.Charts.ResumeLayout(false);
            this.Charts.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            this.groupBoxChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage Charts;
        private System.Windows.Forms.TabPage DailyReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.DataGridView dgvDinner;
        private System.Windows.Forms.DataGridView dgvSnacks;
        private System.Windows.Forms.DataGridView dgvLunch;
        private System.Windows.Forms.DataGridView dgvBreakfast;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNetCalories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBurnedCalories;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackToPersonalMain;
    }
}