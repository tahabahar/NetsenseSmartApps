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

namespace SmartPM.Forms
{
    public partial class ChangeMasterPassword : DevExpress.XtraEditors.XtraForm
    {

        public ChangeMasterPassword()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var MyGeneratePassword = new GeneratePassword();
            MyGeneratePassword.ShowDialog();
            textNewPassword.Text = MyGeneratePassword.Password;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeMasterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is TextBox))
            {
                saveButton.PerformClick();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}