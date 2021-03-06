﻿namespace DoggyMotelSys
{
    partial class frmAdminRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.kennelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKennelAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.updateKennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeKennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerArrivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDepartureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kennelAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perform Revenue Analysis";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kennelsToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // kennelsToolStripMenuItem
            // 
            this.kennelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetType,
            this.mnuKennelAdd,
            this.updateKennelToolStripMenuItem,
            this.removeKennelToolStripMenuItem});
            this.kennelsToolStripMenuItem.Name = "kennelsToolStripMenuItem";
            this.kennelsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kennelsToolStripMenuItem.Text = "Kennels";
            // 
            // mnuSetType
            // 
            this.mnuSetType.Name = "mnuSetType";
            this.mnuSetType.Size = new System.Drawing.Size(157, 22);
            this.mnuSetType.Text = "Set Kennel Type";
            this.mnuSetType.Click += new System.EventHandler(this.mnuSetType_Click);
            // 
            // mnuKennelAdd
            // 
            this.mnuKennelAdd.Name = "mnuKennelAdd";
            this.mnuKennelAdd.Size = new System.Drawing.Size(157, 22);
            this.mnuKennelAdd.Text = "Add Kennel";
            this.mnuKennelAdd.Click += new System.EventHandler(this.mnuKennelAdd_Click);
            // 
            // updateKennelToolStripMenuItem
            // 
            this.updateKennelToolStripMenuItem.Name = "updateKennelToolStripMenuItem";
            this.updateKennelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateKennelToolStripMenuItem.Text = "Update Kennel";
            this.updateKennelToolStripMenuItem.Click += new System.EventHandler(this.updateKennelToolStripMenuItem_Click);
            // 
            // removeKennelToolStripMenuItem
            // 
            this.removeKennelToolStripMenuItem.Name = "removeKennelToolStripMenuItem";
            this.removeKennelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeKennelToolStripMenuItem.Text = "Remove Kennel";
            this.removeKennelToolStripMenuItem.Click += new System.EventHandler(this.removeKennelToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCustomerToolStripMenuItem,
            this.registerDogToolStripMenuItem,
            this.makeReservationToolStripMenuItem,
            this.cancelReservationToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bookingsToolStripMenuItem.Text = "Reservations";
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            this.registerCustomerToolStripMenuItem.Click += new System.EventHandler(this.registerCustomerToolStripMenuItem_Click);
            // 
            // registerDogToolStripMenuItem
            // 
            this.registerDogToolStripMenuItem.Name = "registerDogToolStripMenuItem";
            this.registerDogToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.registerDogToolStripMenuItem.Text = "Register Dog";
            this.registerDogToolStripMenuItem.Click += new System.EventHandler(this.registerDogToolStripMenuItem_Click);
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.makeReservationToolStripMenuItem.Text = "Make Reservation";
            this.makeReservationToolStripMenuItem.Click += new System.EventHandler(this.makeReservationToolStripMenuItem_Click);
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Reservation";
            this.cancelReservationToolStripMenuItem.Click += new System.EventHandler(this.cancelReservationToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerArrivalToolStripMenuItem,
            this.registerDepartureToolStripMenuItem,
            this.revenueAnalysisToolStripMenuItem,
            this.kennelAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // registerArrivalToolStripMenuItem
            // 
            this.registerArrivalToolStripMenuItem.Name = "registerArrivalToolStripMenuItem";
            this.registerArrivalToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registerArrivalToolStripMenuItem.Text = "Register Arrival";
            this.registerArrivalToolStripMenuItem.Click += new System.EventHandler(this.registerArrivalToolStripMenuItem_Click);
            // 
            // registerDepartureToolStripMenuItem
            // 
            this.registerDepartureToolStripMenuItem.Name = "registerDepartureToolStripMenuItem";
            this.registerDepartureToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registerDepartureToolStripMenuItem.Text = "Register Departure";
            this.registerDepartureToolStripMenuItem.Click += new System.EventHandler(this.registerDepartureToolStripMenuItem_Click);
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.revenueAnalysisToolStripMenuItem_Click);
            // 
            // kennelAnalysisToolStripMenuItem
            // 
            this.kennelAnalysisToolStripMenuItem.Name = "kennelAnalysisToolStripMenuItem";
            this.kennelAnalysisToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.kennelAnalysisToolStripMenuItem.Text = "Kennel Analysis";
            this.kennelAnalysisToolStripMenuItem.Click += new System.EventHandler(this.kennelAnalysisToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(254, 116);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // frmAdminRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmAdminRevenueAnalysis";
            this.Text = "frmAdminRevenueAnalysis";
            this.Load += new System.EventHandler(this.frmAdminRevenueAnalysis_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem kennelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetType;
        private System.Windows.Forms.ToolStripMenuItem mnuKennelAdd;
        private System.Windows.Forms.ToolStripMenuItem updateKennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeKennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerArrivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDepartureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kennelAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}