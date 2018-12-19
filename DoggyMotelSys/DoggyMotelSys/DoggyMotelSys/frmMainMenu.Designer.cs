namespace DoggyMotelSys
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.kennelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKennelAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pocMainMenu = new System.Windows.Forms.PictureBox();
            this.updateKennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeKennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerArrivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDepartureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kennelAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pocMainMenu)).BeginInit();
            this.SuspendLayout();
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
            this.mnuMain.Size = new System.Drawing.Size(799, 24);
            this.mnuMain.TabIndex = 0;
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
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pocMainMenu
            // 
            this.pocMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pocMainMenu.Image")));
            this.pocMainMenu.Location = new System.Drawing.Point(0, 27);
            this.pocMainMenu.Name = "pocMainMenu";
            this.pocMainMenu.Size = new System.Drawing.Size(799, 422);
            this.pocMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pocMainMenu.TabIndex = 1;
            this.pocMainMenu.TabStop = false;
            this.pocMainMenu.Click += new System.EventHandler(this.pocMainMenu_Click);
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
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            // 
            // registerDogToolStripMenuItem
            // 
            this.registerDogToolStripMenuItem.Name = "registerDogToolStripMenuItem";
            this.registerDogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerDogToolStripMenuItem.Text = "Register Dog";
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeReservationToolStripMenuItem.Text = "Make Reservation";
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Reservation";
            // 
            // registerArrivalToolStripMenuItem
            // 
            this.registerArrivalToolStripMenuItem.Name = "registerArrivalToolStripMenuItem";
            this.registerArrivalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerArrivalToolStripMenuItem.Text = "Register Arrival";
            // 
            // registerDepartureToolStripMenuItem
            // 
            this.registerDepartureToolStripMenuItem.Name = "registerDepartureToolStripMenuItem";
            this.registerDepartureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerDepartureToolStripMenuItem.Text = "Register Departure";
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            // 
            // kennelAnalysisToolStripMenuItem
            // 
            this.kennelAnalysisToolStripMenuItem.Name = "kennelAnalysisToolStripMenuItem";
            this.kennelAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kennelAnalysisToolStripMenuItem.Text = "Kennel Analysis";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pocMainMenu);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pocMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem kennelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSetType;
        private System.Windows.Forms.ToolStripMenuItem mnuKennelAdd;
        private System.Windows.Forms.PictureBox pocMainMenu;
        private System.Windows.Forms.ToolStripMenuItem updateKennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeKennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerArrivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDepartureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kennelAnalysisToolStripMenuItem;
    }
}