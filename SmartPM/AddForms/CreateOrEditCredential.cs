using DevExpress.XtraEditors;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM.AddForms
{
    public partial class CreateOrEditCredential : DevExpress.XtraEditors.XtraForm
    {
        public CreateOrEditCredential(CredentialEntry credentialEntry)
        {
            InitializeComponent();

            MyCredentialEntry = credentialEntry;

            textCategory.Text = credentialEntry.Category;
            textDescription.Text = credentialEntry.Description;



            switch (credentialEntry.CredentialType)
            {
                case CredentialTypeEnum.Web:
                    var webmodel = credentialEntry.Credential as WebCredential;

                    xtraTabControl1.SelectedTabPage = xtraTabPageWeb;

                    if (webmodel != null)
                    {
                        textWEBUsername.Text = webmodel.WebUrl;
                        textWEBUsername.Text = webmodel.Username;
                        textWEBPasword.Text = webmodel.Password;
                    }

                    break;
                case CredentialTypeEnum.Email:
                    break;
                case CredentialTypeEnum.Computer:
                    break;
                case CredentialTypeEnum.SqlServer:
                   
                    var sqlmodel = credentialEntry.Credential as SQLCredential;                    

                    xtraTabControl1.SelectedTabPage = xtraTabPageSQL;

                    if (sqlmodel != null)
                    {
                        textSQLDBServerName.Text = sqlmodel.DBServerName;
                        textSQLDBUserName.Text = sqlmodel.DBServerName;
                        textSQLDBPassword.Text = sqlmodel.DBPassword;
                    }
                    break;
                case CredentialTypeEnum.App:
                    break;
                case CredentialTypeEnum.Bank:
                    break;
                case CredentialTypeEnum.CreditCard:
                    break;
                case CredentialTypeEnum.WifiNetwork:
                    break;
                case CredentialTypeEnum.API:
                    break;
            }

        }
        public CredentialEntry MyCredentialEntry {  get; set; }

        private void CreateOrEditCredential_Shown(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MyCredentialEntry.Category = textCategory.Text;
            MyCredentialEntry.Description = textDescription.Text;



            this.Close();
        }
    }
}