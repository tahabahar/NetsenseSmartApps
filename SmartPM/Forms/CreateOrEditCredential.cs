using DevExpress.Utils;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPM.AddForms
{
    public partial class CreateOrEditCredential : DevExpress.XtraEditors.XtraForm
    {
        private CredentialEntry _credentialEntry;
        public CreateOrEditCredential(CredentialEntry pCredential)
        {
            InitializeComponent();
            _credentialEntry = pCredential;

            xtraTabControl1.ShowTabHeader = DefaultBoolean.False;

            textCategory.Text = pCredential.Category;
            textDescription.Text = pCredential.Description;
            textValidThru.Text = pCredential.ValidThru.ToString();
            memoNote.Text = pCredential.Note;
            comboBoxCredentialType.EditValue = pCredential.CredentialType;
            comboBoxPriority.EditValue = pCredential.Priority;
            comboBoxMfaType.EditValue = pCredential.MFAType;

            switch (pCredential.CredentialType)
            {
                case CredentialTypeEnum.Web:
                    xtraTabControl1.SelectedTabPage = xtraTabPageWeb;
                    //Unboxing
                    if (pCredential.CredentialJsonData != null)
                    {
                        WebCredential MyWebmodel = JsonConvert.DeserializeObject<WebCredential>(pCredential.CredentialJsonData);

                        if (MyWebmodel != null)
                        {
                            textWEBUrl.Text = MyWebmodel.WebUrl;
                            textWEBUsername.Text = MyWebmodel.Username;
                            textWEBPasword.Text = MyWebmodel.Password;
                        }
                    }
                    break;

                case CredentialTypeEnum.Database:
                    xtraTabControl1.SelectedTabPage = xtraTabPageDB;
                    //Unboxing
                    if (pCredential.CredentialJsonData != null)
                    {
                        DatabaseCredential MyDbmodel = JsonConvert.DeserializeObject<DatabaseCredential>(pCredential.CredentialJsonData);

                        if (MyDbmodel != null)
                        {
                            comboBoxDBType.Text = MyDbmodel.DBType.ToString();
                            textDBServerName.Text = MyDbmodel.DBServerName;
                            textDBUserName.Text = MyDbmodel.DBUsername;
                            textDBPassword.Text = MyDbmodel.DBPassword;
                        }
                    }
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _credentialEntry.Category = textCategory.Text;
            _credentialEntry.Description = textDescription.Text;
            _credentialEntry.ValidThru = textValidThru.DateTime;
            _credentialEntry.Note = memoNote.Text;

            //Todo:Şimdilik pas geçtik kontrol et.
            /* 
            _credentialEntry.Priority = comboBoxPriority.EditValue;
            _credentialEntry.MFAType = comboBoxMfaType.EditValue;          ;
            */

            switch (_credentialEntry.CredentialType)
            {
                case CredentialTypeEnum.Web:
                    xtraTabControl1.SelectedTabPage = xtraTabPageWeb;

                    WebCredential MyWebmodel = new WebCredential();

                    if (MyWebmodel != null)
                    {
                        MyWebmodel.WebUrl = textWEBUrl.Text;
                        MyWebmodel.Username = textDBUserName.Text;
                        MyWebmodel.Password = textDBPassword.Text;                        
                    }
                    //Boxing
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyWebmodel);

                    break;

                case CredentialTypeEnum.Database:
                    xtraTabControl1.SelectedTabPage = xtraTabPageDB;
                    DatabaseCredential MyDbmodel = new DatabaseCredential();

                    if (MyDbmodel != null)
                    {
                        MyDbmodel.DBUsername = textDBUserName.Text;
                        MyDbmodel.DBServerName =  textDBServerName.Text;
                        MyDbmodel.DBPassword = textDBPassword.Text;
                        //Todo:
                        //MyDbmodel.DBType = comboBoxDBType.EditValue;
                        
                    }
                    //Boxing
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyDbmodel);

                    break;
            }

            DataHelper.AddOrUpdate(_credentialEntry);

            this.Close();

        }
    }
}