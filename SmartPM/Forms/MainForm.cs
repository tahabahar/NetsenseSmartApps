using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using System.Deployment.Application;
using System.Diagnostics;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

            string savedTheme = Properties.Settings.Default.Theme;
            string savedPalette = Properties.Settings.Default.Template;
            string savedGridLayout = Properties.Settings.Default.GridLayout;

            if (!string.IsNullOrEmpty(savedTheme))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(savedTheme);
            }

            if (!string.IsNullOrEmpty(savedPalette))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(savedTheme, savedPalette);
            }

            if (!string.IsNullOrEmpty(savedGridLayout))
            {
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(savedGridLayout)))
                {
                    gridControl.MainView.RestoreLayoutFromStream(stream);
                }
            }

            gridView1.RestoreLayoutFromRegistry("SmartPM");
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
        private void bbNoteCredential_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialEntry myCredentialEntry = new CredentialEntry();
            myCredentialEntry.CredentialType = CredentialTypeEnum.Note;

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
        private void bbiChangeMasterPassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Mychangemasterpassword = new ChangeMasterPassword();
            Mychangemasterpassword.ShowDialog();
        }
        
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            CredentialEntry credentialEntry = (CredentialEntry)gridView1.GetFocusedRow();

            CreateOrEditCredential myfrm = new CreateOrEditCredential(credentialEntry);
            myfrm.ShowDialog();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                barStaticVersion.Caption = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            else
                barStaticVersion.Caption = "Preview";

            if (string.IsNullOrEmpty(Properties.Settings.Default.DataFolder))
            {
                FrmFolderOption frmFolderOption = new FrmFolderOption();
                if (frmFolderOption.ShowDialog() != DialogResult.OK)
                    Application.Exit();
            }
            else
            {
                DataHelper.FolderName = Properties.Settings.Default.DataFolder;
                DataHelper.FileName = Path.Combine(DataHelper.FolderName, "credentialdata.json");
                barStaticItemFileName.Caption = DataHelper.FileName;
            }

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
            var result = XtraMessageBox.Show("Are you sure to delete focused row?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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
            CredentialEntry credentialEntry = (CredentialEntry)gridView1.GetFocusedRow();

            CreateOrEditCredential myfrm = new CreateOrEditCredential(credentialEntry);
            myfrm.ShowDialog();
        }
        private void bbiDuplicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var credentialEntry = (CredentialEntry)gridView1.GetFocusedRow();

            CredentialEntry newCredentialEntry = new CredentialEntry();
            newCredentialEntry.Note = credentialEntry.Note;
            newCredentialEntry.Description = credentialEntry.Description;
            newCredentialEntry.Category = credentialEntry.Category;
            newCredentialEntry.Id = Guid.NewGuid();
            newCredentialEntry.CredentialJsonData = credentialEntry.CredentialJsonData;
            newCredentialEntry.CredentialType = credentialEntry.CredentialType;

            CreateOrEditCredential myfrm = new CreateOrEditCredential(newCredentialEntry);
            myfrm.ShowDialog();
        }
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Properties.Settings.Default.Theme = skinDropDownButtonItem1.Caption;
            Properties.Settings.Default.Template = skinPaletteDropDownButtonItem1.Caption;
            using (var stream = new MemoryStream())
            {
                gridControl.MainView.SaveLayoutToStream(stream);
                stream.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(stream))
                {
                    string layoutString = reader.ReadToEnd();
                    Properties.Settings.Default.GridLayout = layoutString;
                    Properties.Settings.Default.Save();
                }
            }
            Properties.Settings.Default.Save();

            gridView1.SaveLayoutToRegistry("SmartPM");
        }
        private void bbiOpenDataFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (File.Exists(DataHelper.FileName))
            {
                string folderPath = Path.GetDirectoryName(DataHelper.FileName);

                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                XtraMessageBox.Show("Data file doesn't exists", "Warning!", MessageBoxButtons.OK);
            }
        }
        

        
    }
}