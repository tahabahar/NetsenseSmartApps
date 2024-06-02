namespace SmartPM
{
    partial class AddWifiNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWifiNetwork));
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textNetworkName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textType = new DevExpress.XtraEditors.TextEdit();
            this.generatePasswordButton = new DevExpress.XtraEditors.SimpleButton();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkImportant = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNetworkName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(224, 25);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(352, 144);
            this.memoNote.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(224, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Note:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(10, 76);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(157, 28);
            this.textPassword.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Network name:";
            // 
            // textNetworkName
            // 
            this.textNetworkName.Location = new System.Drawing.Point(10, 25);
            this.textNetworkName.Name = "textNetworkName";
            this.textNetworkName.Size = new System.Drawing.Size(157, 28);
            this.textNetworkName.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(74, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 81;
            this.labelControl4.Text = "Type:";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(10, 127);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(157, 28);
            this.textType.TabIndex = 3;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("generatePasswordButton.ImageOptions.SvgImage")));
            this.generatePasswordButton.Location = new System.Drawing.Point(173, 70);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(38, 39);
            this.generatePasswordButton.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.ImageOptions.SvgImage")));
            this.backButton.Location = new System.Drawing.Point(10, 269);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 45);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearButton.ImageOptions.SvgImage")));
            this.clearButton.Location = new System.Drawing.Point(370, 269);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveButton.ImageOptions.SvgImage")));
            this.saveButton.Location = new System.Drawing.Point(476, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            // 
            // checkImportant
            // 
            this.checkImportant.Location = new System.Drawing.Point(439, 241);
            this.checkImportant.Name = "checkImportant";
            this.checkImportant.Properties.Caption = "Important password?";
            this.checkImportant.Size = new System.Drawing.Size(137, 22);
            this.checkImportant.TabIndex = 4;
            // 
            // AddWifiNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 326);
            this.Controls.Add(this.checkImportant);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.memoNote);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textNetworkName);
            this.Name = "AddWifiNetwork";
            this.Text = "AddNetworkForm";
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNetworkName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkImportant.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.MemoEdit memoNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textNetworkName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textType;
        private DevExpress.XtraEditors.SimpleButton generatePasswordButton;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.CheckEdit checkImportant;
    }
}