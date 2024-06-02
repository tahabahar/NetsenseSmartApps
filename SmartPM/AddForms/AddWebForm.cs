using DevExpress.XtraEditors;
using SmartPM.Model;
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
    public partial class AddWebForm : DevExpress.XtraEditors.XtraForm
    {
        public AddWebForm(CredentialEntry webCredential)
        {
            InitializeComponent();
            if (webCredential != null)
            {
                
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}