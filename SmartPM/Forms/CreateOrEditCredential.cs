using DevExpress.Utils;
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
            xtraTabControl1.ShowTabHeader = DefaultBoolean.False;

       

            textCategory.Text = credentialEntry.Category;
            textDescription.Text = credentialEntry.Description;



            switch (credentialEntry.CredentialType)
            {
                case CredentialTypeEnum.Web:
                    xtraTabControl1.SelectedTabPage = xtraTabPageWeb;

                    var webmodel = credentialEntry.Credential as WebCredential;                   

                    if (webmodel != null)
                    {
                        textWEBUsername.Text = webmodel.WebUrl;
                        textWEBUsername.Text = webmodel.Username;
                        textWEBPasword.Text = webmodel.Password;
                    }

                    break;
            
                case CredentialTypeEnum.Database:
                   
                    var dbmodel = credentialEntry.Credential as DatabaseCredential;                    

                    xtraTabControl1.SelectedTabPage = xtraTabPageDB;

                    if (dbmodel != null)
                    {
                        textDBServerName.Text = dbmodel.DBServerName;
                        textDBUserName.Text = dbmodel.DBServerName;
                        textDBPassword.Text = dbmodel.DBPassword;
                    }
                    break;
               
            }
            
        }



    }
}