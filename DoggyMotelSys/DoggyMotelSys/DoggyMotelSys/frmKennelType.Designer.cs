namespace DoggyMotelSys
{
    partial class frmKennelType
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
            this.mnuSrtType = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSrtType.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSrtType
            // 
            this.mnuSrtType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuSrtType.Location = new System.Drawing.Point(0, 0);
            this.mnuSrtType.Name = "mnuSrtType";
            this.mnuSrtType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuSrtType.Size = new System.Drawing.Size(800, 24);
            this.mnuSrtType.TabIndex = 0;
            this.mnuSrtType.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmKennelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuSrtType);
            this.MainMenuStrip = this.mnuSrtType;
            this.Name = "frmKennelType";
            this.Text = "Set Kennel Type";
            this.Load += new System.EventHandler(this.frmKennelType_Load);
            this.mnuSrtType.ResumeLayout(false);
            this.mnuSrtType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSrtType;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}