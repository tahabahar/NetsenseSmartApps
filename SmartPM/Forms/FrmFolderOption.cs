using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class FrmFolderOption : DevExpress.XtraEditors.XtraForm
    {
        public FrmFolderOption()
        {
            InitializeComponent();
        }

        private void FrmFolderOption_Shown(object sender, EventArgs e)
        {
            xDataFolder.Text = Properties.Settings.Default.DataFolder;
        }

        private void xbtnBrowse_Click(object sender, EventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                xDataFolder.Text = xtraFolderBrowserDialog1.SelectedPath;
            }
        }

        private void bbSaveAndContinue_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(xDataFolder.Text))
            {
                Directory.CreateDirectory(DataHelper.FolderName);
            }

            Properties.Settings.Default.DataFolder = xDataFolder.Text;
            Properties.Settings.Default.Save();


            Properties.Settings.Default.Reload();


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}