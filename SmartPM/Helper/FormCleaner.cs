using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM
{
    public class FormCleaner
    {
        public static void ResetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                else if (control is DevExpress.XtraEditors.CheckEdit)
                {
                    (control as DevExpress.XtraEditors.CheckEdit).Checked = false;
                }
                else if (control.HasChildren)
                {
                    ResetAllControls(control); 
                }
            }
        }
    }
}
