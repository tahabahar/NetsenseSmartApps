using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using Newtonsoft.Json;
using SmartPM.AddForms;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

            gridControl1.DataSource = DataHelper.GetData();
        }      

        private void bbWebCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Web;
            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry;
           
            myfrm.ShowDialog();
        }

        private void bbDatabaseCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Database;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(myCredentialEntry);
            myfrm.ShowDialog();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
           CredentialEntry credentialEntry= (CredentialEntry)gridView1.GetFocusedRow();
           CreateOrEditCredential myfrm = new CreateOrEditCredential(credentialEntry);
           myfrm.ShowDialog();
        }
    }
}