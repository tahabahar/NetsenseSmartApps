using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM.Helper
{
    public class ShowPassword
    {
        public static void HidePassword(TabPage tabPage, TextBox textBox, CheckBox checkBox)
        {
            if (tabPage == null || textBox == null || checkBox == null)
            {
                throw new ArgumentNullException("TabPage, TextBox, or CheckBox is null.");
            }

            if (tabPage.Controls.Contains(textBox) && tabPage.Controls.Contains(checkBox))
            {
                checkBox.CheckedChanged += (sender, e) =>
                {
                    textBox.PasswordChar = checkBox.Checked ? '*' : '\0';
                };
            }
            else
            {
                throw new ArgumentException("TextBox or CheckBox is not found within the given TabPage.");
            }
        }
       
    }
}
