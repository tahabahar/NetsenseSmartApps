using DevExpress.Utils;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using SmartPM.Model;
using SmartPM.Model.CredentialTypes;
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

                case CredentialTypeEnum.API:
                    xtraTabControl1.SelectedTabPage = xtraTabPageApi;
                    if (pCredential.CredentialJsonData != null)
                    {
                        ApiCredential MyApiModel = JsonConvert.DeserializeObject<ApiCredential>(pCredential.CredentialJsonData);

                        if (MyApiModel != null)
                        {
                            textAPIAccessToken.Text = MyApiModel.AccessToken;
                            textAPIKey.Text = MyApiModel.ApiKey;
                            textAPINName.Text = MyApiModel.ApiName;
                            textAPIPassword.Text = MyApiModel.ApiPassword;
                            textAPISecretKey.Text = MyApiModel.SecretKey;
                            textAPIUrl.Text = MyApiModel.ApiUrl;
                            textAPIUsername.Text = MyApiModel.ApiUsername;
                        }
                    }
                    break;

                case CredentialTypeEnum.App:
                    xtraTabControl1.SelectedTabPage = xtraTabPageApp;
                    if (pCredential.CredentialJsonData != null)
                    {
                        AppCredential MyAppModel = JsonConvert.DeserializeObject<AppCredential>(pCredential.CredentialJsonData);

                        if (MyAppModel != null)
                        {
                            textAPPName.Text = MyAppModel.AppName;
                            textAPPPassword.Text = MyAppModel.Password;
                            textAPPUsername.Text = MyAppModel.Username;
                        }
                    }
                    break;

                case CredentialTypeEnum.Bank:
                    xtraTabControl1.SelectedTabPage = xtraTabPageBank;
                    if (pCredential.CredentialJsonData != null)
                    {
                        BankCredential MyBankModel = JsonConvert.DeserializeObject<BankCredential>(pCredential.CredentialJsonData);

                        if (MyBankModel != null)
                        {
                            textBANKName.Text = MyBankModel.BankName;
                            textBANKPasscode.Text = MyBankModel.Passcode;
                            textBANKPassword.Text = MyBankModel.Password;
                            textBANKUsername.Text = MyBankModel.Username;
                        }
                    }
                    break;

                case CredentialTypeEnum.Computer:
                    xtraTabControl1.SelectedTabPage = xtraTabPageComputer;
                    if (pCredential.CredentialJsonData != null)
                    {
                        ComputerCredential MyComputerModel = JsonConvert.DeserializeObject<ComputerCredential>(pCredential.CredentialJsonData);

                        if (MyComputerModel != null)
                        {
                            textCOMPUTERDomainName.Text = MyComputerModel.Domain;
                            textCOMPUTERPassword.Text = MyComputerModel.Password;
                            textCOMPUTERPin.Text = MyComputerModel.Pin.ToString();
                            textCOMPUTERUsername.Text = MyComputerModel.Username;
                        }
                    }
                    break;

                case CredentialTypeEnum.CreditCard:
                    xtraTabControl1.SelectedTabPage = xtraTabPageCreditCard;
                    if (pCredential.CredentialJsonData != null)
                    {
                        CreditCardCredential MyCreditCard = JsonConvert.DeserializeObject<CreditCardCredential>(pCredential.CredentialJsonData);

                        if (MyCreditCard != null)
                        {
                            textCREDITCARDCvv.Text = MyCreditCard.CVV;
                            textCREDITCARDNumber.Text = MyCreditCard.CardNumber;
                            textCREDITCARDOwnerName.Text = MyCreditCard.CardOwner;
                            dateCREDITCARDExpirationMonth.Text = MyCreditCard.CardExpirationMonth;
                            dateCREDITCARDExpirationYear.Text = MyCreditCard.CardExpirationYear;
                        }
                    }
                    break;

                case CredentialTypeEnum.Email:
                    xtraTabControl1.SelectedTabPage = xtraTabPageEmail;
                    if (pCredential.CredentialJsonData != null)
                    {
                        EmailCredential MyEmailModel = JsonConvert.DeserializeObject<EmailCredential>(pCredential.CredentialJsonData);

                        if (MyEmailModel != null)
                        {
                            textEMAILAccountAdress.Text = MyEmailModel.EmailAccount;
                            textEMAILPassword.Text = MyEmailModel.Password;
                            textEMAILRecoveryAccountAdress.Text = MyEmailModel.RecoveryEmail;
                        }
                    }
                    break;

                case CredentialTypeEnum.WifiNetwork:
                    xtraTabControl1.SelectedTabPage = xtraTabPageWifi;
                    if (pCredential.CredentialJsonData != null)
                    {
                        WifiNetworkCredential MyWifiNetworkModel = JsonConvert.DeserializeObject<WifiNetworkCredential>(pCredential.CredentialJsonData);

                        if (MyWifiNetworkModel != null)
                        {
                            textWIFIName.Text = MyWifiNetworkModel.WifiName;
                            textWIFIPassword.Text = MyWifiNetworkModel.Password;
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
                        MyWebmodel.Username = textWEBUsername.Text;
                        MyWebmodel.Password = textWEBPasword.Text;                        
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyWebmodel);

                    break;

                case CredentialTypeEnum.Database:
                    xtraTabControl1.SelectedTabPage = xtraTabPageDB;
                    DatabaseCredential MyDbmodel = new DatabaseCredential();

                    if (MyDbmodel != null)
                    {
                        MyDbmodel.DBUsername = textDBUserName.Text;
                        MyDbmodel.DBServerName = textDBServerName.Text;
                        MyDbmodel.DBPassword = textDBPassword.Text;
                        //Todo:
                        //MyDbmodel.DBType = comboBoxDBType.EditValue;
                        
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyDbmodel);

                    break;
            }

            DataHelper.AddOrUpdate(_credentialEntry);

            this.Close();

        }
    }
}