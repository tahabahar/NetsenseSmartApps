namespace SmartPM.AddForms
{
    partial class CreateOrEditCredential
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrEditCredential));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textCategory = new DevExpress.XtraEditors.TextEdit();
            this.textDescription = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageWeb = new DevExpress.XtraTab.XtraTabPage();
            this.textWEBPasword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textWEBUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textWEBUrl = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageDB = new DevExpress.XtraTab.XtraTabPage();
            this.textDBServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textDBUserName = new DevExpress.XtraEditors.TextEdit();
            this.textDBPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBPasword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBUrl.Properties)).BeginInit();
            this.xtraTabPageDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDBServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDBUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDBPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textCategory);
            this.panelControl1.Controls.Add(this.textDescription);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1071, 188);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(281, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Category";
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(31, 44);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(244, 28);
            this.textCategory.TabIndex = 1;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(281, 44);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(239, 28);
            this.textDescription.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.saveButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 629);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1071, 71);
            this.panelControl2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveButton.ImageOptions.SvgImage")));
            this.saveButton.Location = new System.Drawing.Point(943, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 188);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageWeb;
            this.xtraTabControl1.Size = new System.Drawing.Size(1071, 441);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageWeb,
            this.xtraTabPageDB});
            // 
            // xtraTabPageWeb
            // 
            this.xtraTabPageWeb.Controls.Add(this.textWEBPasword);
            this.xtraTabPageWeb.Controls.Add(this.labelControl5);
            this.xtraTabPageWeb.Controls.Add(this.textWEBUsername);
            this.xtraTabPageWeb.Controls.Add(this.labelControl4);
            this.xtraTabPageWeb.Controls.Add(this.labelControl3);
            this.xtraTabPageWeb.Controls.Add(this.textWEBUrl);
            this.xtraTabPageWeb.Name = "xtraTabPageWeb";
            this.xtraTabPageWeb.Size = new System.Drawing.Size(1069, 410);
            this.xtraTabPageWeb.Text = "xtraTabPageWEB";
            // 
            // textWEBPasword
            // 
            this.textWEBPasword.Location = new System.Drawing.Point(174, 192);
            this.textWEBPasword.Name = "textWEBPasword";
            this.textWEBPasword.Size = new System.Drawing.Size(100, 28);
            this.textWEBPasword.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(64, 199);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Password";
            // 
            // textWEBUsername
            // 
            this.textWEBUsername.Location = new System.Drawing.Point(175, 122);
            this.textWEBUsername.Name = "textWEBUsername";
            this.textWEBUsername.Size = new System.Drawing.Size(100, 28);
            this.textWEBUsername.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "User Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Web URL";
            // 
            // textWEBUrl
            // 
            this.textWEBUrl.Location = new System.Drawing.Point(175, 73);
            this.textWEBUrl.Name = "textWEBUrl";
            this.textWEBUrl.Size = new System.Drawing.Size(100, 28);
            this.textWEBUrl.TabIndex = 0;
            // 
            // xtraTabPageDB
            // 
            this.xtraTabPageDB.Controls.Add(this.textDBServerName);
            this.xtraTabPageDB.Controls.Add(this.labelControl8);
            this.xtraTabPageDB.Controls.Add(this.labelControl7);
            this.xtraTabPageDB.Controls.Add(this.labelControl6);
            this.xtraTabPageDB.Controls.Add(this.textDBUserName);
            this.xtraTabPageDB.Controls.Add(this.textDBPassword);
            this.xtraTabPageDB.Name = "xtraTabPageDB";
            this.xtraTabPageDB.Size = new System.Drawing.Size(1069, 410);
            this.xtraTabPageDB.Text = "xtraTabPageDatabase";
            // 
            // textDBServerName
            // 
            this.textDBServerName.Location = new System.Drawing.Point(188, 74);
            this.textDBServerName.Name = "textDBServerName";
            this.textDBServerName.Size = new System.Drawing.Size(244, 28);
            this.textDBServerName.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(30, 160);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Database Password";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Database User Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(111, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Database Server Name";
            // 
            // textDBUserName
            // 
            this.textDBUserName.Location = new System.Drawing.Point(188, 116);
            this.textDBUserName.Name = "textDBUserName";
            this.textDBUserName.Size = new System.Drawing.Size(239, 28);
            this.textDBUserName.TabIndex = 0;
            // 
            // textDBPassword
            // 
            this.textDBPassword.Location = new System.Drawing.Point(188, 161);
            this.textDBPassword.Name = "textDBPassword";
            this.textDBPassword.Size = new System.Drawing.Size(239, 28);
            this.textDBPassword.TabIndex = 0;
            // 
            // CreateOrEditCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 700);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CreateOrEditCredential";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateOrEditCredential";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageWeb.ResumeLayout(false);
            this.xtraTabPageWeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBPasword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWEBUrl.Properties)).EndInit();
            this.xtraTabPageDB.ResumeLayout(false);
            this.xtraTabPageDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDBServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDBUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDBPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageWeb;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDB;
        private DevExpress.XtraEditors.TextEdit textCategory;
        private DevExpress.XtraEditors.TextEdit textDescription;
        private DevExpress.XtraEditors.TextEdit textWEBUsername;
        private DevExpress.XtraEditors.TextEdit textWEBUrl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textWEBPasword;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textDBServerName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textDBUserName;
        private DevExpress.XtraEditors.TextEdit textDBPassword;
        private DevExpress.XtraEditors.SimpleButton saveButton;
    }
}