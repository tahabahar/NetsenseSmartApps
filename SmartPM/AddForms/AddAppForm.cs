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
    public partial class AddAppForm : DevExpress.XtraEditors.XtraForm
    {
        public AddAppForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var data = new DataEntity();
            {
                Name = textAppName.Text;


            }
        }
    }
}