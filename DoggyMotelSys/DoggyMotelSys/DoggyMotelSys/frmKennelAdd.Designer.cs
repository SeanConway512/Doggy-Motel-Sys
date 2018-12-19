namespace DoggyMotelSys
{
    partial class frmKennelAdd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKennelType = new System.Windows.Forms.Label();
            this.txtKennelType = new System.Windows.Forms.TextBox();
            this.btnKennelType = new System.Windows.Forms.Button();
            this.lblKennelID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKennelID = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // lblKennelType
            // 
            this.lblKennelType.AutoSize = true;
            this.lblKennelType.Location = new System.Drawing.Point(9, 77);
            this.lblKennelType.Name = "lblKennelType";
            this.lblKennelType.Size = new System.Drawing.Size(64, 13);
            this.lblKennelType.TabIndex = 1;
            this.lblKennelType.Text = "KennelType";
            // 
            // txtKennelType
            // 
            this.txtKennelType.Location = new System.Drawing.Point(79, 74);
            this.txtKennelType.Name = "txtKennelType";
            this.txtKennelType.Size = new System.Drawing.Size(100, 20);
            this.txtKennelType.TabIndex = 2;
            // 
            // btnKennelType
            // 
            this.btnKennelType.Location = new System.Drawing.Point(196, 74);
            this.btnKennelType.Name = "btnKennelType";
            this.btnKennelType.Size = new System.Drawing.Size(75, 23);
            this.btnKennelType.TabIndex = 3;
            this.btnKennelType.Text = "Enter";
            this.btnKennelType.UseVisualStyleBackColor = true;
            this.btnKennelType.Click += new System.EventHandler(this.btnKennelType_Click);
            // 
            // lblKennelID
            // 
            this.lblKennelID.AutoSize = true;
            this.lblKennelID.Location = new System.Drawing.Point(9, 48);
            this.lblKennelID.Name = "lblKennelID";
            this.lblKennelID.Size = new System.Drawing.Size(51, 13);
            this.lblKennelID.TabIndex = 4;
            this.lblKennelID.Text = "KennelID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnKennelID
            // 
            this.btnKennelID.Location = new System.Drawing.Point(196, 45);
            this.btnKennelID.Name = "btnKennelID";
            this.btnKennelID.Size = new System.Drawing.Size(75, 23);
            this.btnKennelID.TabIndex = 6;
            this.btnKennelID.Text = "Enter";
            this.btnKennelID.UseVisualStyleBackColor = true;
            this.btnKennelID.Click += new System.EventHandler(this.btnKennelID_Click);
            // 
            // frmKennelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKennelID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKennelID);
            this.Controls.Add(this.btnKennelType);
            this.Controls.Add(this.txtKennelType);
            this.Controls.Add(this.lblKennelType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmKennelAdd";
            this.Text = "frmKennelAdd";
            this.Load += new System.EventHandler(this.frmKennelAdd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblKennelType;
        private System.Windows.Forms.TextBox txtKennelType;
        private System.Windows.Forms.Button btnKennelType;
        private System.Windows.Forms.Label lblKennelID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKennelID;
    }
}