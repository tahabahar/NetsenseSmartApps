using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        private void bbLogin_Click(object sender, EventArgs e)
        {
            DataHelper.aesCipher = new AESCipher(textMasterKey.Text);

            if (!Directory.Exists(DataHelper.FolderName))
            {
                Directory.CreateDirectory(DataHelper.FolderName);
            }
            if (textMasterKey.Text.Length<6)
            {
                XtraMessageBox.Show("Please enter master password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(DataHelper.FileName))
            {
                if (DataHelper.TryLoadData())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            else
            {                
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is TextBox))
            {
                bbLogin.PerformClick();
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckHidePassword.Checked == false)
            {
                textMasterKey.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textMasterKey.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}