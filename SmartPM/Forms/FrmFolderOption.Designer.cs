namespace SmartPM.Forms
{
    partial class FrmFolderOption
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
            this.components = new System.ComponentModel.Container();
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.xDataFolder = new DevExpress.XtraEditors.TextEdit();
            this.bbLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xbtnBrowse = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xDataFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // xDataFolder
            // 
            this.xDataFolder.Location = new System.Drawing.Point(63, 96);
            this.xDataFolder.Name = "xDataFolder";
            this.xDataFolder.Size = new System.Drawing.Size(711, 28);
            this.xDataFolder.TabIndex = 0;
            // 
            // bbLogin
            // 
            this.bbLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bbLogin.Appearance.Options.UseFont = true;
            this.bbLogin.Location = new System.Drawing.Point(63, 182);
            this.bbLogin.Name = "bbLogin";
            this.bbLogin.Size = new System.Drawing.Size(168, 45);
            this.bbLogin.TabIndex = 2;
            this.bbLogin.Text = "&Save && Continue";
            this.bbLogin.Click += new System.EventHandler(this.bbLogin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Data Folder";
            // 
            // xbtnBrowse
            // 
            this.xbtnBrowse.Location = new System.Drawing.Point(792, 96);
            this.xbtnBrowse.Name = "xbtnBrowse";
            this.xbtnBrowse.Size = new System.Drawing.Size(122, 28);
            this.xbtnBrowse.TabIndex = 13;
            this.xbtnBrowse.Text = "Browse";
            this.xbtnBrowse.Click += new System.EventHandler(this.xbtnBrowse_Click);
            // 
            // FrmFolderOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 280);
            this.Controls.Add(this.xbtnBrowse);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bbLogin);
            this.Controls.Add(this.xDataFolder);
            this.Name = "FrmFolderOption";
            this.Text = "Select Data Folder";
            this.Shown += new System.EventHandler(this.FrmFolderOption_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xDataFolder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.TextEdit xDataFolder;
        private DevExpress.XtraEditors.SimpleButton bbLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton xbtnBrowse;
    }
}