namespace SmartPM
{
    partial class AddComputerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComputerForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textDomainName = new DevExpress.XtraEditors.TextEdit();
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textType = new DevExpress.XtraEditors.TextEdit();
            this.textUsernameOrEmail = new DevExpress.XtraEditors.TextEdit();
            this.generatePasswordButton = new DevExpress.XtraEditors.SimpleButton();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkImportant = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textDomainName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsernameOrEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Domain:";
            // 
            // textDomainName
            // 
            this.textDomainName.Location = new System.Drawing.Point(12, 23);
            this.textDomainName.Name = "textDomainName";
            this.textDomainName.Size = new System.Drawing.Size(157, 28);
            this.textDomainName.TabIndex = 0;
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(201, 23);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(375, 90);
            this.memoNote.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(201, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "Note:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 125);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(157, 28);
            this.textPassword.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 13);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "Username or E-mail:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(76, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 81;
            this.labelControl4.Text = "Type:";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(12, 176);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(157, 28);
            this.textType.TabIndex = 4;
            // 
            // textUsernameOrEmail
            // 
            this.textUsernameOrEmail.Location = new System.Drawing.Point(12, 74);
            this.textUsernameOrEmail.Name = "textUsernameOrEmail";
            this.textUsernameOrEmail.Size = new System.Drawing.Size(157, 28);
            this.textUsernameOrEmail.TabIndex = 1;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("generatePasswordButton.ImageOptions.SvgImage")));
            this.generatePasswordButton.Location = new System.Drawing.Point(175, 119);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(38, 39);
            this.generatePasswordButton.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.ImageOptions.SvgImage")));
            this.backButton.Location = new System.Drawing.Point(12, 364);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 45);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearButton.ImageOptions.SvgImage")));
            this.clearButton.Location = new System.Drawing.Point(370, 364);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 45);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveButton.ImageOptions.SvgImage")));
            this.saveButton.Location = new System.Drawing.Point(476, 364);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            // 
            // checkImportant
            // 
            this.checkImportant.Location = new System.Drawing.Point(439, 336);
            this.checkImportant.Name = "checkImportant";
            this.checkImportant.Properties.Caption = "Important password?";
            this.checkImportant.Size = new System.Drawing.Size(137, 22);
            this.checkImportant.TabIndex = 5;
            // 
            // AddComputerForm
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
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textDomainName);
            this.Controls.Add(this.memoNote);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textPassword);
            this.Name = "AddComputerForm";
            this.Text = "AddSystemForm";
            ((System.ComponentModel.ISupportInitialize)(this.textDomainName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsernameOrEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textDomainName;
        private DevExpress.XtraEditors.MemoEdit memoNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textType;
        private DevExpress.XtraEditors.TextEdit textUsernameOrEmail;
        private DevExpress.XtraEditors.SimpleButton generatePasswordButton;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.CheckEdit checkImportant;
    }
}