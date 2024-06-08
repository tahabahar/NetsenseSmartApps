namespace SmartPM
{
    partial class GeneratePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePassword));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textGeneratedPassword = new DevExpress.XtraEditors.TextEdit();
            this.textPasswordLenght = new DevExpress.XtraEditors.SpinEdit();
            this.checkLowerCase = new DevExpress.XtraEditors.CheckEdit();
            this.checkUpperCase = new DevExpress.XtraEditors.CheckEdit();
            this.checkNumbers = new DevExpress.XtraEditors.CheckEdit();
            this.checkSymbols = new DevExpress.XtraEditors.CheckEdit();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.generateButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textGeneratedPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPasswordLenght.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLowerCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUpperCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSymbols.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Password lenght:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 146);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Password:";
            // 
            // textGeneratedPassword
            // 
            this.textGeneratedPassword.Location = new System.Drawing.Point(78, 139);
            this.textGeneratedPassword.Name = "textGeneratedPassword";
            this.textGeneratedPassword.Size = new System.Drawing.Size(223, 28);
            this.textGeneratedPassword.TabIndex = 5;
            // 
            // textPasswordLenght
            // 
            this.textPasswordLenght.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textPasswordLenght.Location = new System.Drawing.Point(111, 66);
            this.textPasswordLenght.Name = "textPasswordLenght";
            this.textPasswordLenght.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textPasswordLenght.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textPasswordLenght.Size = new System.Drawing.Size(55, 28);
            this.textPasswordLenght.TabIndex = 0;
            // 
            // checkLowerCase
            // 
            this.checkLowerCase.Location = new System.Drawing.Point(22, 100);
            this.checkLowerCase.Name = "checkLowerCase";
            this.checkLowerCase.Properties.Caption = "abc";
            this.checkLowerCase.Size = new System.Drawing.Size(50, 22);
            this.checkLowerCase.TabIndex = 1;
            // 
            // checkUpperCase
            // 
            this.checkUpperCase.Location = new System.Drawing.Point(78, 100);
            this.checkUpperCase.Name = "checkUpperCase";
            this.checkUpperCase.Properties.Caption = "ABC";
            this.checkUpperCase.Size = new System.Drawing.Size(52, 22);
            this.checkUpperCase.TabIndex = 2;
            // 
            // checkNumbers
            // 
            this.checkNumbers.Location = new System.Drawing.Point(136, 100);
            this.checkNumbers.Name = "checkNumbers";
            this.checkNumbers.Properties.Caption = "123";
            this.checkNumbers.Size = new System.Drawing.Size(52, 22);
            this.checkNumbers.TabIndex = 3;
            // 
            // checkSymbols
            // 
            this.checkSymbols.Location = new System.Drawing.Point(194, 100);
            this.checkSymbols.Name = "checkSymbols";
            this.checkSymbols.Properties.Caption = "!+-";
            this.checkSymbols.Size = new System.Drawing.Size(49, 22);
            this.checkSymbols.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("okButton.ImageOptions.SvgImage")));
            this.okButton.Location = new System.Drawing.Point(354, 207);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(77, 40);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearButton.ImageOptions.SvgImage")));
            this.clearButton.Location = new System.Drawing.Point(95, 207);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(77, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cancelButton.ImageOptions.SvgImage")));
            this.cancelButton.Location = new System.Drawing.Point(12, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("generateButton.ImageOptions.SvgImage")));
            this.generateButton.Location = new System.Drawing.Point(307, 137);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(101, 31);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 18);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Customize Your Password";
            // 
            // GeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 259);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.checkSymbols);
            this.Controls.Add(this.checkNumbers);
            this.Controls.Add(this.checkUpperCase);
            this.Controls.Add(this.checkLowerCase);
            this.Controls.Add(this.textGeneratedPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textPasswordLenght);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneratePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneratePassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textGeneratedPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPasswordLenght.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLowerCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUpperCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSymbols.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textGeneratedPassword;
        private DevExpress.XtraEditors.SpinEdit textPasswordLenght;
        private DevExpress.XtraEditors.CheckEdit checkLowerCase;
        private DevExpress.XtraEditors.CheckEdit checkUpperCase;
        private DevExpress.XtraEditors.CheckEdit checkNumbers;
        private DevExpress.XtraEditors.CheckEdit checkSymbols;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton generateButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}