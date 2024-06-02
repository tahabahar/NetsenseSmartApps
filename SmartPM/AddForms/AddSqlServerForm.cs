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

namespace SmartPM.AddForms
{
    public partial class AddSqlServerForm : DevExpress.XtraEditors.XtraForm
    {
        public AddSqlServerForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}