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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textMasterKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textMasterKey
            // 
            this.textMasterKey.Location = new System.Drawing.Point(147, 85);
            this.textMasterKey.Name = "textMasterKey";
            this.textMasterKey.Properties.PasswordChar = '*';
            this.textMasterKey.Size = new System.Drawing.Size(276, 28);
            this.textMasterKey.TabIndex = 0;
            // 
            // bbLogin
            // 
            this.bbLogin.Location = new System.Drawing.Point(206, 157);
            this.bbLogin.Name = "bbLogin";
            this.bbLogin.Size = new System.Drawing.Size(168, 45);
            this.bbLogin.TabIndex = 1;
            this.bbLogin.Text = "Login";
            this.bbLogin.Click += new System.EventHandler(this.bbLogin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(206, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Enter Your Master Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 268);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bbLogin);
            this.Controls.Add(this.textMasterKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.textMasterKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textMasterKey;
        private DevExpress.XtraEditors.SimpleButton bbLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}