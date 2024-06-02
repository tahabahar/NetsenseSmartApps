using DevExpress.XtraEditors;
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
    public partial class AddComputerForm : DevExpress.XtraEditors.XtraForm
    {
        public AddComputerForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
            textDomainName.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}