namespace SmartPM
{
    partial class AddBankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBankForm));
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textType = new DevExpress.XtraEditors.TextEdit();
            this.textUsernameOrEmail = new DevExpress.XtraEditors.TextEdit();
            this.generatePasswordButton = new DevExpress.XtraEditors.SimpleButton();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkImportant = new DevExpress.XtraEditors.CheckEdit();
            this.textAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsernameOrEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(201, 20);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(375, 144);
            this.memoNote.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(201, 1);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Note:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Password 2:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 174);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(157, 28);
            this.textPassword.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Username or E-mail:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Bank name:";
            // 
            // textBankName
            // 
            this.textBankName.Location = new System.Drawing.Point(12, 21);
            this.textBankName.Name = "textBankName";
            this.textBankName.Size = new System.Drawing.Size(157, 28);
            this.textBankName.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(76, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 81;
            this.labelControl4.Text = "Type:";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(12, 225);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(157, 28);
            this.textType.TabIndex = 5;
            // 
            // textUsernameOrEmail
            // 
            this.textUsernameOrEmail.Location = new System.Drawing.Point(12, 72);
            this.textUsernameOrEmail.Name = "textUsernameOrEmail";
            this.textUsernameOrEmail.Size = new System.Drawing.Size(157, 28);
            this.textUsernameOrEmail.TabIndex = 2;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("generatePasswordButton.ImageOptions.SvgImage")));
            this.generatePasswordButton.Location = new System.Drawing.Point(175, 168);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(38, 39);
            this.generatePasswordButton.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.ImageOptions.SvgImage")));
            this.backButton.Location = new System.Drawing.Point(12, 364);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 45);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearButton.ImageOptions.SvgImage")));
            this.clearButton.Location = new System.Drawing.Point(369, 364);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 45);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveButton.ImageOptions.SvgImage")));
            this.saveButton.Location = new System.Drawing.Point(476, 364);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            // 
            // checkImportant
            // 
            this.checkImportant.Location = new System.Drawing.Point(439, 336);
            this.checkImportant.Name = "checkImportant";
            this.checkImportant.Properties.Caption = "Important password?";
            this.checkImportant.Size = new System.Drawing.Size(137, 22);
            this.checkImportant.TabIndex = 6;
            // 
            // textAccountNumber
            // 
            this.textAccountNumber.Location = new System.Drawing.Point(12, 123);
            this.textAccountNumber.Name = "textAccountNumber";
            this.textAccountNumber.Size = new System.Drawing.Size(157, 28);
            this.textAccountNumber.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(61, 105);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Password 1:";
            // 
            // AddBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 421);
            this.Controls.Add(this.checkImportant);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textUsernameOrEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textAccountNumber);
            this.Controls.Add(this.memoNote);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBankName);
            this.Name = "AddBankForm";
            this.Text = "AddBankForm";
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsernameOrEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.MemoEdit memoNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBankName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textType;
        private DevExpress.XtraEditors.TextEdit textUsernameOrEmail;
        private DevExpress.XtraEditors.SimpleButton generatePasswordButton;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.CheckEdit checkImportant;
        private DevExpress.XtraEditors.TextEdit textAccountNumber;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}