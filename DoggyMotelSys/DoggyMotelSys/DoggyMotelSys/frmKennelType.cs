﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyMotelSys
{
    public partial class frmKennelType : Form
    {
        frmMainMenu parent;

        public frmKennelType()
        {
            InitializeComponent();
        }

        public frmKennelType(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmKennelType_Load(object sender, EventArgs e)
        {

        }
    }
}
