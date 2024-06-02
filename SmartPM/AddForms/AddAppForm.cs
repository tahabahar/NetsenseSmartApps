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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartPM
{
    public partial class AddAppForm : DevExpress.XtraEditors.XtraForm
    {
        public AddAppForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
            textAppName.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}