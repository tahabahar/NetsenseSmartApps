namespace SmartPM
{
    partial class AskPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskPasswordForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textImportantPassword = new DevExpress.XtraEditors.TextEdit();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textImportantPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(157, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Enter Password";
            // 
            // textImportantPassword
            // 
            this.textImportantPassword.Location = new System.Drawing.Point(53, 64);
            this.textImportantPassword.Name = "textImportantPassword";
            this.textImportantPassword.Size = new System.Drawing.Size(340, 28);
            this.textImportantPassword.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("okButton.ImageOptions.SvgImage")));
            this.okButton.Location = new System.Drawing.Point(332, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 30);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Enter";
            // 
            // backButton
            // 
            this.backButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.ImageOptions.SvgImage")));
            this.backButton.Location = new System.Drawing.Point(12, 169);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 30);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Go back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AskPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 211);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textImportantPassword);
            this.Controls.Add(this.labelControl1);
            this.Name = "AskPasswordForm";
            this.Text = "AskPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.textImportantPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textImportantPassword;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton backButton;
    }
}