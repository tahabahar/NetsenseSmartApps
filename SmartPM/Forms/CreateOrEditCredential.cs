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
        public CreateOrEditCredential(CredentialEntry pCredential)
        {
            InitializeComponent();
            xtraTabControl1.ShowTabHeader = DefaultBoolean.False;
          
             textCategory.Text = pCredential.Category;
             textDescription.Text = pCredential.Description;



             switch (pCredential.CredentialType)
             {
                 case CredentialTypeEnum.Web:
                     xtraTabControl1.SelectedTabPage = xtraTabPageWeb;

                     WebCredential MyWebmodel = (WebCredential)pCredential.Credential;                   

                     if (MyWebmodel != null)
                     {
                         textWEBUsername.Text = MyWebmodel.WebUrl;
                         textWEBUsername.Text = MyWebmodel.Username;
                         textWEBPasword.Text = MyWebmodel.Password;
                     }

                     break;

                 case CredentialTypeEnum.Database:
                     xtraTabControl1.SelectedTabPage = xtraTabPageDB;
                     DatabaseCredential MyDbmodel = (DatabaseCredential)pCredential.Credential;

                     if (MyDbmodel != null)
                     {
                         textDBServerName.Text = MyDbmodel.DBServerName;
                         textDBUserName.Text = MyDbmodel.DBServerName;
                         textDBPassword.Text = MyDbmodel.DBPassword;
                     }
                     break;
             }
         }
       
    }
}