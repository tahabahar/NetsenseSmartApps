using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;
using Newtonsoft.Json;
using SmartPM.AddForms;
using SmartPM.Forms;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartPM
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bbWebCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Web;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbDatabaseCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Database;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbAppCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.App;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbApiCrendential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.API;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbBankCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Bank;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbComputerCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Computer;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbCreditCardCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.CreditCard;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbEmailCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Email;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbWifiNetworkCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.WifiNetwork;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            CredentialEntry credentialEntry = (CredentialEntry)gridView1.GetFocusedRow();

            CreateOrEditCredential myfrm = new CreateOrEditCredential(credentialEntry);
            myfrm.ShowDialog();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Application will be closed");
                Application.Exit();
            }


            gridControl.DataSource = DataHelper.MyData;
        }
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure to delete focused row?", "Warning!", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                return;
            }

            var credentialEntry = (CredentialEntry)gridView1.GetFocusedRow();

            DataHelper.MyData.Remove(credentialEntry);
            DataHelper.SaveData();
            

        }
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}