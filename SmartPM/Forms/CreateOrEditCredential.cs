using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using SmartPM.Helper;
using SmartPM.Model;
using SmartPM.Model.CredentialTypes;
using SmartPM.Model.Enums;
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
            this.KeyPreview = true;
            

            this.KeyDown += CreateOrEditCredential_KeyDown;

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
                            comboBoxDBType.EditValue = MyDbmodel.DBType;
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
            _credentialEntry.Priority = (PriorityEnum)comboBoxPriority.EditValue;
            _credentialEntry.MFAType = (MFATypeEnum)comboBoxMfaType.EditValue;
            _credentialEntry.LastModifiedDate = DateTime.Now;
            

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
                        MyDbmodel.DBType = (DBTypeEnum)comboBoxDBType.EditValue;

                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyDbmodel);

                    break;

                case CredentialTypeEnum.API:
                    xtraTabControl1.SelectedTabPage = xtraTabPageApi;
                    ApiCredential MyApiModel = new ApiCredential();

                    if (MyApiModel != null)
                    {
                        MyApiModel.AccessToken = textAPIAccessToken.Text;
                        MyApiModel.ApiKey = textAPIKey.Text;
                        MyApiModel.ApiName = textAPINName.Text;
                        MyApiModel.ApiPassword = textAPIPassword.Text;
                        MyApiModel.SecretKey = textAPISecretKey.Text;
                        MyApiModel.ApiUrl = textAPIUrl.Text;
                        MyApiModel.ApiUsername = textAPIUsername.Text;

                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyApiModel);

                    break;

                case CredentialTypeEnum.App:
                    xtraTabControl1.SelectedTabPage = xtraTabPageApp;
                    AppCredential MyAppModel = new AppCredential();

                    if (MyAppModel != null)
                    {
                        MyAppModel.AppName = textAPPName.Text;
                        MyAppModel.Password = textAPPPassword.Text;
                        MyAppModel.Username = textAPPUsername.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyAppModel);

                    break;

                case CredentialTypeEnum.Bank:
                    xtraTabControl1.SelectedTabPage = xtraTabPageBank;
                    BankCredential MyBankModel = new BankCredential();

                    if (MyBankModel != null)
                    {
                        MyBankModel.BankName = textBANKName.Text;
                        MyBankModel.Passcode = textBANKPasscode.Text;
                        MyBankModel.Password = textBANKPassword.Text;
                        MyBankModel.Username = textBANKUsername.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyBankModel);

                    break;

                case CredentialTypeEnum.Computer:
                    xtraTabControl1.SelectedTabPage = xtraTabPageComputer;
                    ComputerCredential MyComputerModel = new ComputerCredential();

                    if (MyComputerModel != null)
                    {
                        MyComputerModel.Domain = textCOMPUTERDomainName.Text;
                        MyComputerModel.Password = textCOMPUTERPassword.Text;
                        MyComputerModel.Pin = int.Parse(textCOMPUTERPin.Text);
                        MyComputerModel.Username = textCOMPUTERUsername.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyComputerModel);

                    break;

                case CredentialTypeEnum.CreditCard:
                    xtraTabControl1.SelectedTabPage = xtraTabPageCreditCard;
                    CreditCardCredential MyCreditCard = new CreditCardCredential();

                    if (MyCreditCard != null)
                    {
                        MyCreditCard.CVV = textCREDITCARDCvv.Text;
                        MyCreditCard.CardNumber = textCREDITCARDNumber.Text;
                        MyCreditCard.CardOwner = textCREDITCARDOwnerName.Text;
                        MyCreditCard.CardExpirationMonth = dateCREDITCARDExpirationMonth.Text;
                        MyCreditCard.CardExpirationYear = dateCREDITCARDExpirationYear.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyCreditCard);

                    break;

                case CredentialTypeEnum.Email:
                    xtraTabControl1.SelectedTabPage = xtraTabPageEmail;
                    EmailCredential MyEmailModel = new EmailCredential();

                    if (MyEmailModel != null)
                    {
                        MyEmailModel.EmailAccount = textEMAILAccountAdress.Text;
                        MyEmailModel.Password = textEMAILPassword.Text;
                        MyEmailModel.RecoveryEmail = textEMAILRecoveryAccountAdress.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyEmailModel);

                    break;

                case CredentialTypeEnum.WifiNetwork:
                    xtraTabControl1.SelectedTabPage = xtraTabPageWifi;
                    WifiNetworkCredential MyWifiNetworkModel = new WifiNetworkCredential();

                    if (MyWifiNetworkModel != null)
                    {
                        MyWifiNetworkModel.WifiName = textWIFIName.Text;
                        MyWifiNetworkModel.Password = textWIFIPassword.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyWifiNetworkModel);

                    break;
            }

            DataHelper.AddOrUpdate(_credentialEntry);     
            this.Close();         
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            var MyGeneratePassword = new GeneratePassword();
            MyGeneratePassword.ShowDialog();
            if (xtraTabControl1.SelectedTabPage == xtraTabPageApi)
            {
                textAPIPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageApp) 
            {
                textAPPPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageBank)
            {
                textBANKPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageComputer)
            {
                textCOMPUTERPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageDB)
            {
                textDBPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageEmail)
            {
                textEMAILPassword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageWeb)
            {
                textWEBPasword.Text = MyGeneratePassword.Password;
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageWifi)
            {
                textWIFIPassword.Text = MyGeneratePassword.Password;
            }
        }
        private void CreateOrEditCredential_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is TextBox))
            {
                saveButton.PerformClick();
            }
        }
        private void CreateOrEditCredential_Load(object sender, EventArgs e)
        {
            comboBoxPriority.Properties.Items.AddRange(Enum.GetValues(typeof(PriorityEnum)));
            comboBoxCredentialType.Properties.Items.AddRange(Enum.GetValues(typeof(CredentialTypeEnum)));
            comboBoxMfaType.Properties.Items.AddRange(Enum.GetValues(typeof(MFATypeEnum)));
            if (xtraTabControl1.SelectedTabPage == xtraTabPageDB)
            {
                comboBoxDBType.Properties.Items.AddRange(Enum.GetValues(typeof(DBTypeEnum)));
            }

        }

        private void checkShowPassword_Click(object sender, EventArgs e)
        {
            foreach (Control control in xtraTabControl1.SelectedTabPage.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.PasswordChar = '0'; // TextBox'ın PasswordChar özelliğini '*' karakterine ayarla
                }
            }

            // CheckBox'un durumunu PasswordChar özelliğine göre ayarla
            checkShowPasswordWeb.Checked = (xtraTabControl1.SelectedTabPage.Controls.OfType<TextBox>().Any(tb => tb.PasswordChar == '*'));
        }

        private void checkShowPasswordWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordWeb.Checked == false)
            {
                textWEBPasword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textWEBPasword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordDB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordDB.Checked == false)
            {
                textDBPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textDBPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordEmail.Checked == false)
            {
                textEMAILPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textEMAILPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordComputer.Checked == false)
            {
                textCOMPUTERPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textCOMPUTERPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordApp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordApp.Checked == false)
            {
                textAPPPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textAPPPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordBank_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordBank.Checked == false)
            {
                textBANKPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textBANKPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordWifi.Checked == false)
            {
                textWIFIPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textWIFIPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void checkShowPasswordApi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPasswordApi.Checked == false)
            {
                textAPIPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textAPIPassword.Properties.UseSystemPasswordChar = true;
            }
        }
    }
    
}