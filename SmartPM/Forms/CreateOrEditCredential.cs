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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
           
            memoNote.Text = pCredential.Note;

            this.Text = pCredential.CredentialType.ToString();
            


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


                case CredentialTypeEnum.CreditCard:
                    xtraTabControl1.SelectedTabPage = xtraTabPageCreditCard;
                    if (pCredential.CredentialJsonData != null)
                    {
                        CreditCardCredential MyCreditCard = JsonConvert.DeserializeObject<CreditCardCredential>(pCredential.CredentialJsonData);

                        if (MyCreditCard != null)
                        {
                            textCREDITCARDcvv.Text = MyCreditCard.CVV;
                            textCREDITCARDNumber.Text = MyCreditCard.CardNumber;
                            textCREDITCARDOwnerName.Text = MyCreditCard.CardOwner;
                            dateCREDITCARDExpirationDate.Text = MyCreditCard.CardExpirationMonth;
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

                case CredentialTypeEnum.Note:
                    xtraTabControl1.SelectedTabPage = xtraTabPageNote;
                    if (pCredential.CredentialJsonData != null)
                    {
                        NoteCredential MyNote = JsonConvert.DeserializeObject<NoteCredential>(pCredential.CredentialJsonData);

                        if (MyNote != null)
                        {
                            memoBigNote.Text = MyNote.Note;
                        }
                    }
                    break;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            _credentialEntry.Category = textCategory.Text;
            _credentialEntry.Note = memoNote.Text;
            _credentialEntry.Description = textDescription.Text;
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
                case CredentialTypeEnum.Note:
                    xtraTabControl1.SelectedTabPage = xtraTabPageDB;
                    NoteCredential MyNote = new NoteCredential();

                    if (MyNote != null)
                    {
                        MyNote.Note = memoBigNote.Text;
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyNote);

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

                

               

                case CredentialTypeEnum.CreditCard:
                    xtraTabControl1.SelectedTabPage = xtraTabPageCreditCard;
                    CreditCardCredential MyCreditCard = new CreditCardCredential();

                    if (MyCreditCard != null)
                    {
                        MyCreditCard.CVV = textCREDITCARDcvv.Text;
                        MyCreditCard.CardNumber = textCREDITCARDNumber.Text;
                        MyCreditCard.CardOwner = textCREDITCARDOwnerName.Text;
                        MyCreditCard.CardExpirationMonth = dateCREDITCARDExpirationDate.Text;
                        if (MyCreditCard.CardNumber.Length > 4)
                        {
                            _credentialEntry.Description = new string('*', MyCreditCard.CardNumber.Length - 4) + MyCreditCard.CardNumber.Substring(MyCreditCard.CardNumber.Length - 4);
                        }
                        else
                        {
                            textCREDITCARDNumber.Text = MyCreditCard.CardNumber;
                        }
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
                        if (string.IsNullOrEmpty(textEMAILAccountAdress.Text)) 
                        {
                            _credentialEntry.Description = MyEmailModel.EmailAccount; 
                        }
                        else
                        {
                            _credentialEntry.Description = textDescription.Text;
                        }
                    }
                    _credentialEntry.CredentialJsonData = JsonConvert.SerializeObject(MyEmailModel);

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
            if (xtraTabControl1.SelectedTabPage == xtraTabPageApp)
            {
                textAPPPassword.Text = MyGeneratePassword.Password;
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
        }
        private void CreateOrEditCredential_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is System.Windows.Forms.TextBox))
            {
                saveButton.PerformClick();
            }
        }
        private void CreateOrEditCredential_Load(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPageDB)
            {
                comboBoxDBType.Properties.Items.AddRange(Enum.GetValues(typeof(DBTypeEnum)));
            }

            // Form Load veya uygun bir yerde DateEdit kontrolüne format ayarlama
            dateCREDITCARDExpirationDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateCREDITCARDExpirationDate.Properties.Mask.EditMask = "MM/yy"; // Sadece Ay ve Yıl gösterimi
            dateCREDITCARDExpirationDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView; // Yıl bazlı görünüm
            dateCREDITCARDExpirationDate.Properties.DisplayFormat.FormatString = "MM/yy"; // Ekranda görünecek format
            dateCREDITCARDExpirationDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateCREDITCARDExpirationDate.Properties.EditFormat.FormatString = "MM/yy"; // Düzenleme formatı
            dateCREDITCARDExpirationDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPageApp)
            {
                Clipboard.SetText(textAPPPassword.Text);
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageDB)
            {
                Clipboard.SetText(textDBPassword.Text);
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageEmail)
            {
                Clipboard.SetText(textEMAILPassword.Text);
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageWeb)
            {
                Clipboard.SetText(textWEBPasword.Text);
            }
            else if (xtraTabControl1.SelectedTabPage == xtraTabPageNote)
            {
                Clipboard.SetText(memoBigNote.Text);
            }
        }

        private void xcbHidePass_CheckedChanged(object sender, EventArgs e)
        {
            textEMAILPassword.Properties.UseSystemPasswordChar = !xcbShowPassEMail.Checked;
        }

        private void xcbShowPassWEB_CheckedChanged(object sender, EventArgs e)
        {
            textWEBPasword.Properties.UseSystemPasswordChar =!xcbShowPassWEB.Checked;
        }

        private void xcbShowPassDatabase_CheckedChanged(object sender, EventArgs e)
        {
            textDBPassword.Properties.UseSystemPasswordChar = !xcbShowPassDatabase.Checked;
        }

        private void xcbShowPassAPP_CheckedChanged(object sender, EventArgs e)
        {
            textAPPPassword.Properties.UseSystemPasswordChar = !xcbShowPassAPP.Checked;
        }

        private void checkCvvCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            textCREDITCARDcvv.Properties.UseSystemPasswordChar = !checkCvvCreditCard.Checked;
        }
        private void checkCardNumberCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            textCREDITCARDNumber.Properties.UseSystemPasswordChar= !checkCardNumberCreditCard.Checked;
        }

        private void textCategory_TextChanged(object sender, EventArgs e)
        {
            string descriptionText = textDescription.Text;

            if (string.IsNullOrWhiteSpace(descriptionText))
            {
                textWEBUrl.Text = string.Empty;
            }
            else
            {
                textWEBUrl.Text = $"www.{descriptionText}.com";
            }
        }


    }
}