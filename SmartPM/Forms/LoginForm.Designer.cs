namespace SmartPM.Forms
{
    partial class LoginForm
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
            this.textMasterKey = new DevExpress.XtraEditors.TextEdit();
            this.bbLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckShowPassword = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasterKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckShowPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textMasterKey
            // 
            this.textMasterKey.Location = new System.Drawing.Point(153, 79);
            this.textMasterKey.Name = "textMasterKey";
            this.textMasterKey.Properties.UseSystemPasswordChar = true;
            this.textMasterKey.Size = new System.Drawing.Size(276, 28);
            this.textMasterKey.TabIndex = 0;
            // 
            // bbLogin
            // 
            this.bbLogin.Location = new System.Drawing.Point(212, 151);
            this.bbLogin.Name = "bbLogin";
            this.bbLogin.Size = new System.Drawing.Size(168, 45);
            this.bbLogin.TabIndex = 1;
            this.bbLogin.Text = "Login";
            this.bbLogin.Click += new System.EventHandler(this.bbLogin_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(1, 235);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(581, 52);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(203, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(186, 18);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Enter Your Master Password";
            // 
            // CheckShowPassword
            // 
            this.CheckShowPassword.Location = new System.Drawing.Point(435, 82);
            this.CheckShowPassword.Name = "CheckShowPassword";
            this.CheckShowPassword.Properties.Caption = "Show Password";
            this.CheckShowPassword.Size = new System.Drawing.Size(107, 22);
            this.CheckShowPassword.TabIndex = 12;
            this.CheckShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 286);
            this.Controls.Add(this.CheckShowPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.bbLogin);
            this.Controls.Add(this.textMasterKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textMasterKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckShowPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textMasterKey;
        private DevExpress.XtraEditors.SimpleButton bbLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckShowPassword;
    }
}