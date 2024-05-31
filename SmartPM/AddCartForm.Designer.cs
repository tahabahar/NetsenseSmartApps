namespace SmartPM
{
    partial class AddCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCartForm));
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.comboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textOwner = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textValidThru = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textCVV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textCardNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textBankName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValidThru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValidThru.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCVV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.ImageOptions.SvgImage")));
            this.backButton.Location = new System.Drawing.Point(442, 201);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 45);
            this.backButton.TabIndex = 35;
            this.backButton.Text = "Back";
            // 
            // clearButton
            // 
            this.clearButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearButton.ImageOptions.SvgImage")));
            this.clearButton.Location = new System.Drawing.Point(333, 201);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 45);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Clear";
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveButton.ImageOptions.SvgImage")));
            this.saveButton.Location = new System.Drawing.Point(224, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            // 
            // comboType
            // 
            this.comboType.Location = new System.Drawing.Point(12, 426);
            this.comboType.Name = "comboType";
            this.comboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboType.Size = new System.Drawing.Size(157, 28);
            this.comboType.TabIndex = 29;
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(192, 41);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(375, 144);
            this.memoNote.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(192, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Note:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(76, 401);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Type:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 336);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 361);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(157, 28);
            this.textPassword.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Card owner name:";
            // 
            // textOwner
            // 
            this.textOwner.Location = new System.Drawing.Point(12, 101);
            this.textOwner.Name = "textOwner";
            this.textOwner.Size = new System.Drawing.Size(157, 28);
            this.textOwner.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(66, 206);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Valid thru:";
            // 
            // textValidThru
            // 
            this.textValidThru.EditValue = null;
            this.textValidThru.Location = new System.Drawing.Point(12, 231);
            this.textValidThru.Name = "textValidThru";
            this.textValidThru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textValidThru.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textValidThru.Properties.DisplayFormat.FormatString = "";
            this.textValidThru.Properties.EditFormat.FormatString = "";
            this.textValidThru.Properties.MaskSettings.Set("mask", "");
            this.textValidThru.Size = new System.Drawing.Size(157, 28);
            this.textValidThru.TabIndex = 38;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(79, 271);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "CVV:";
            // 
            // textCVV
            // 
            this.textCVV.Location = new System.Drawing.Point(12, 296);
            this.textCVV.Name = "textCVV";
            this.textCVV.Size = new System.Drawing.Size(157, 28);
            this.textCVV.TabIndex = 40;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(71, 141);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Card No:";
            // 
            // textCardNo
            // 
            this.textCardNo.Location = new System.Drawing.Point(12, 166);
            this.textCardNo.Name = "textCardNo";
            this.textCardNo.Size = new System.Drawing.Size(157, 28);
            this.textCardNo.TabIndex = 42;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(62, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 13);
            this.labelControl8.TabIndex = 45;
            this.labelControl8.Text = "Bank name:";
            // 
            // textBankName
            // 
            this.textBankName.Location = new System.Drawing.Point(12, 42);
            this.textBankName.Name = "textBankName";
            this.textBankName.Size = new System.Drawing.Size(157, 28);
            this.textBankName.TabIndex = 44;
            // 
            // AddCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 553);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textBankName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textCardNo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textCVV);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.memoNote);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textOwner);
            this.Controls.Add(this.textValidThru);
            this.Name = "AddCartForm";
            this.Text = "AddCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValidThru.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValidThru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCVV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.ComboBoxEdit comboType;
        private DevExpress.XtraEditors.MemoEdit memoNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textOwner;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit textValidThru;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textCVV;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textCardNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textBankName;
    }
}