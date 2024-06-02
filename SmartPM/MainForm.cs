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
        }
        BindingList<CredentialEntry> dataSource = new BindingList<CredentialEntry>();
        private void MainForm_Shown(object sender, EventArgs e)
        {
            dataSource = DataHelper.GetData();
            gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as CredentialEntry;        

            CreateOrEditCredential addWebForm = new CreateOrEditCredential(row);
            addWebForm.ShowDialog();

        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedRow() as CredentialEntry;
            dataSource.Remove(row);
        }


        private void bbSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            string serializeddata = JsonConvert.SerializeObject(dataSource);
            File.WriteAllText("c:\\jsondenemes\\credentialdata.json", serializeddata);

        }

        private void bbWebCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry  credentialEntry = new CredentialEntry();
            credentialEntry.CredentialType = CredentialTypeEnum.Web;

            CreateOrEditCredential addWebForm = new CreateOrEditCredential(credentialEntry);
            addWebForm.ShowDialog();

            dataSource.Add(addWebForm.MyCredentialEntry);

        }

        private void bbSQLCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry credentialEntry = new CredentialEntry();
            credentialEntry.CredentialType = CredentialTypeEnum.Web;

            CreateOrEditCredential addWebForm = new CreateOrEditCredential(credentialEntry);
            addWebForm.ShowDialog();
            dataSource.Add(addWebForm.MyCredentialEntry);


        }
    }
}