﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM
{
    public partial class AddBankForm : DevExpress.XtraEditors.XtraForm
    {
        public AddBankForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
            textBankName.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}