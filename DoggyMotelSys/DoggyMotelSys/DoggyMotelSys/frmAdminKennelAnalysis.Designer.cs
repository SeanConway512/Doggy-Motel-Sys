namespace DoggyMotelSys
{
    partial class frmAdminKennelAnalysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KennelID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
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
            this.mnuMain.TabIndex = 6;
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
            this.mnuSetType.Size = new System.Drawing.Size(180, 22);
            this.mnuSetType.Text = "Set Kennel Type";
            this.mnuSetType.Click += new System.EventHandler(this.mnuSetType_Click);
            // 
            // mnuKennelAdd
            // 
            this.mnuKennelAdd.Name = "mnuKennelAdd";
            this.mnuKennelAdd.Size = new System.Drawing.Size(180, 22);
            this.mnuKennelAdd.Text = "Add Kennel";
            this.mnuKennelAdd.Click += new System.EventHandler(this.mnuKennelAdd_Click);
            // 
            // updateKennelToolStripMenuItem
            // 
            this.updateKennelToolStripMenuItem.Name = "updateKennelToolStripMenuItem";
            this.updateKennelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateKennelToolStripMenuItem.Text = "Update Kennel";
            this.updateKennelToolStripMenuItem.Click += new System.EventHandler(this.updateKennelToolStripMenuItem_Click);
            // 
            // removeKennelToolStripMenuItem
            // 
            this.removeKennelToolStripMenuItem.Name = "removeKennelToolStripMenuItem";
            this.removeKennelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            this.registerCustomerToolStripMenuItem.Click += new System.EventHandler(this.registerCustomerToolStripMenuItem_Click);
            // 
            // registerDogToolStripMenuItem
            // 
            this.registerDogToolStripMenuItem.Name = "registerDogToolStripMenuItem";
            this.registerDogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerDogToolStripMenuItem.Text = "Register Dog";
            this.registerDogToolStripMenuItem.Click += new System.EventHandler(this.registerDogToolStripMenuItem_Click);
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeReservationToolStripMenuItem.Text = "Make Reservation";
            this.makeReservationToolStripMenuItem.Click += new System.EventHandler(this.makeReservationToolStripMenuItem_Click);
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.registerArrivalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerArrivalToolStripMenuItem.Text = "Register Arrival";
            this.registerArrivalToolStripMenuItem.Click += new System.EventHandler(this.registerArrivalToolStripMenuItem_Click);
            // 
            // registerDepartureToolStripMenuItem
            // 
            this.registerDepartureToolStripMenuItem.Name = "registerDepartureToolStripMenuItem";
            this.registerDepartureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerDepartureToolStripMenuItem.Text = "Register Departure";
            this.registerDepartureToolStripMenuItem.Click += new System.EventHandler(this.registerDepartureToolStripMenuItem_Click);
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.revenueAnalysisToolStripMenuItem_Click);
            // 
            // kennelAnalysisToolStripMenuItem
            // 
            this.kennelAnalysisToolStripMenuItem.Name = "kennelAnalysisToolStripMenuItem";
            this.kennelAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // frmAdminKennelAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminKennelAnalysis";
            this.Text = "frmAdminKennelAnalysis";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}