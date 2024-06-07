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
    public partial class GeneratePassword : DevExpress.XtraEditors.XtraForm
    {
        public GeneratePassword()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += GeneratePassword_KeyDown;
        }
        public string  Password { get; set; }
        private string GenerateCustomPassword(int length, bool useLowercase, bool useUppercase, bool useNumbers, bool useSymbols)
        {
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numberChars = "1234567890";
            const string symbolChars = "!@#$%^&*()-_+=";

            StringBuilder password = new StringBuilder();
            Random rnd = new Random();

            string validChars = "";

            if (useLowercase)
                validChars += lowercaseChars;
            if (useUppercase)
                validChars += uppercaseChars;
            if (useNumbers)
                validChars += numberChars;
            if (useSymbols)
                validChars += symbolChars;

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            bool useLowercase = checkLowerCase.Checked;
            bool useUppercase = checkUpperCase.Checked;
            bool useNumbers = checkNumbers.Checked;
            bool useSymbols = checkSymbols.Checked;

            if (!useLowercase && !useUppercase && !useNumbers && !useSymbols)
            {
                MessageBox.Show("Please select at least one character option!");
                return;
            }

            if (int.TryParse(textPasswordLenght.Text, out int passwordLength))
            {
                if (passwordLength >= 8 && passwordLength <= 25)
                {
                    string password = GenerateCustomPassword(passwordLength, useLowercase, useUppercase, useNumbers, useSymbols);
                    textGeneratedPassword.Text = password;
                }
                else
                {
                    MessageBox.Show("Password length must be between 8 and 25!");
                }
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            FormCleaner.ResetAllControls(this);
            textPasswordLenght.Focus();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
           Password = textGeneratedPassword.Text;
            this.Close();
        }
        private void GeneratePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is TextBox))
            {
                okButton.PerformClick();
            }
        }
    }
}
    
