using DevExpress.XtraEditors;
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
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextEdit textEdit)
                {
                    textEdit.Text = string.Empty; 
                }
                else if (ctrl.HasChildren)
                {
                    ResetAllControls(ctrl);
                }
            }
        }
    }
}
