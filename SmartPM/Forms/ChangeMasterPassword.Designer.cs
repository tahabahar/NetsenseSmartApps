namespace SmartPM.Forms
{
    partial class ChangeMasterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMasterPassword));
            this.textCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.textNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.generateButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNewPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textCurrentPassword
            // 
            this.textCurrentPassword.Location = new System.Drawing.Point(170, 42);
            this.textCurrentPassword.Name = "textCurrentPassword";
            this.textCurrentPassword.Size = new System.Drawing.Size(211, 28);
            this.textCurrentPassword.TabIndex = 0;
            // 
            // textNewPassword
            // 
            this.textNewPassword.Location = new System.Drawing.Point(170, 99);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.Size = new System.Drawing.Size(211, 28);
            this.textNewPassword.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Current Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(94, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "New Password";
            // 
            // cancelButton
            // 
            this.cancelButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cancelButton.ImageOptions.SvgImage")));
            this.cancelButton.Location = new System.Drawing.Point(12, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 45);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(392, 176);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 45);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("generateButton.ImageOptions.SvgImage")));
            this.generateButton.Location = new System.Drawing.Point(95, 176);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(144, 45);
            this.generateButton.TabIndex = 16;
            this.generateButton.Text = "Generate Password";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // ChangeMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 233);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.textCurrentPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeMasterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeMasterPassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNewPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textCurrentPassword;
        private DevExpress.XtraEditors.TextEdit textNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton generateButton;
    }
}