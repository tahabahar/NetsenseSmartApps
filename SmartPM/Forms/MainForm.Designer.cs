namespace SmartPM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbWebCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbDatabaseCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbApiCrendential = new DevExpress.XtraBars.BarButtonItem();
            this.bbAppCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbBankCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbComputerCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbCreditCardCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbEmailCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbWifiNetworkCredential = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.bbSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOpenDataFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiDuplicate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangeMasterPassword = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemFileName = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticVersion = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 201);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1541, 746);
            this.gridControl.TabIndex = 2;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn8,
            this.Description});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Category";
            this.gridColumn1.FieldName = "Category";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 241;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Note";
            this.gridColumn3.FieldName = "Note";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 552;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Credential Type";
            this.gridColumn7.FieldName = "CredentialType";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 166;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Last Modified Date";
            this.gridColumn8.DisplayFormat.FormatString = "g";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.FieldName = "LastModifiedDate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 190;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            this.Description.Width = 364;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1,
            this.bbSave,
            this.bbWebCredential,
            this.bbDatabaseCredential,
            this.bbApiCrendential,
            this.bbAppCredential,
            this.bbBankCredential,
            this.bbComputerCredential,
            this.bbCreditCardCredential,
            this.bbEmailCredential,
            this.bbWifiNetworkCredential,
            this.bbiOpenDataFolder,
            this.barButtonItem1,
            this.barButtonItem2,
            this.ribbonGalleryBarItem1,
            this.bbiDuplicate,
            this.bbiSave,
            this.bbiChangeMasterPassword,
            this.barStaticItemFileName,
            this.barStaticVersion});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 57;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1541, 201);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bbiNew
            // 
            this.bbiNew.ActAsDropDown = true;
            this.bbiNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiNew.Caption = "New";
            this.bbiNew.DropDownControl = this.popupMenu1;
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.bbWebCredential);
            this.popupMenu1.ItemLinks.Add(this.bbDatabaseCredential);
            this.popupMenu1.ItemLinks.Add(this.bbApiCrendential);
            this.popupMenu1.ItemLinks.Add(this.bbAppCredential);
            this.popupMenu1.ItemLinks.Add(this.bbBankCredential);
            this.popupMenu1.ItemLinks.Add(this.bbComputerCredential);
            this.popupMenu1.ItemLinks.Add(this.bbCreditCardCredential);
            this.popupMenu1.ItemLinks.Add(this.bbEmailCredential);
            this.popupMenu1.ItemLinks.Add(this.bbWifiNetworkCredential);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl;
            // 
            // bbWebCredential
            // 
            this.bbWebCredential.Caption = "Web Credential";
            this.bbWebCredential.Id = 28;
            this.bbWebCredential.Name = "bbWebCredential";
            this.bbWebCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbWebCredential_ItemClick);
            // 
            // bbDatabaseCredential
            // 
            this.bbDatabaseCredential.Caption = "Database Credential";
            this.bbDatabaseCredential.Id = 29;
            this.bbDatabaseCredential.Name = "bbDatabaseCredential";
            this.bbDatabaseCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbDatabaseCredential_ItemClick);
            // 
            // bbApiCrendential
            // 
            this.bbApiCrendential.Caption = "Api Crendential";
            this.bbApiCrendential.Id = 40;
            this.bbApiCrendential.Name = "bbApiCrendential";
            this.bbApiCrendential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbApiCrendential_ItemClick);
            // 
            // bbAppCredential
            // 
            this.bbAppCredential.Caption = "App Credential";
            this.bbAppCredential.Id = 41;
            this.bbAppCredential.Name = "bbAppCredential";
            this.bbAppCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAppCredential_ItemClick);
            // 
            // bbBankCredential
            // 
            this.bbBankCredential.Caption = "Bank Credential";
            this.bbBankCredential.Id = 42;
            this.bbBankCredential.Name = "bbBankCredential";
            this.bbBankCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbBankCredential_ItemClick);
            // 
            // bbComputerCredential
            // 
            this.bbComputerCredential.Caption = "Computer Credential";
            this.bbComputerCredential.Id = 43;
            this.bbComputerCredential.Name = "bbComputerCredential";
            this.bbComputerCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbComputerCredential_ItemClick);
            // 
            // bbCreditCardCredential
            // 
            this.bbCreditCardCredential.Caption = "CreditCard Credential";
            this.bbCreditCardCredential.Id = 44;
            this.bbCreditCardCredential.Name = "bbCreditCardCredential";
            this.bbCreditCardCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbCreditCardCredential_ItemClick);
            // 
            // bbEmailCredential
            // 
            this.bbEmailCredential.Caption = "Email Credential";
            this.bbEmailCredential.Id = 45;
            this.bbEmailCredential.Name = "bbEmailCredential";
            this.bbEmailCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbEmailCredential_ItemClick);
            // 
            // bbWifiNetworkCredential
            // 
            this.bbWifiNetworkCredential.Caption = "Wifi Network Credential";
            this.bbWifiNetworkCredential.Id = 46;
            this.bbWifiNetworkCredential.Name = "bbWifiNetworkCredential";
            this.bbWifiNetworkCredential.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbWifiNetworkCredential_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 20;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 21;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // bbSave
            // 
            this.bbSave.Caption = "Save";
            this.bbSave.Id = 26;
            this.bbSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbSave.ImageOptions.LargeImage")));
            this.bbSave.Name = "bbSave";
            // 
            // bbiOpenDataFolder
            // 
            this.bbiOpenDataFolder.Caption = "Open Data Folder";
            this.bbiOpenDataFolder.Id = 47;
            this.bbiOpenDataFolder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiOpenDataFolder.ImageOptions.LargeImage")));
            this.bbiOpenDataFolder.Name = "bbiOpenDataFolder";
            this.bbiOpenDataFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOpenDataFolder_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Duplicate";
            this.barButtonItem1.Id = 48;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "duplicate";
            this.barButtonItem2.Id = 49;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            this.ribbonGalleryBarItem1.Id = 50;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // bbiDuplicate
            // 
            this.bbiDuplicate.Caption = "Duplicate Selected Row";
            this.bbiDuplicate.Id = 51;
            this.bbiDuplicate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDuplicate.ImageOptions.LargeImage")));
            this.bbiDuplicate.Name = "bbiDuplicate";
            this.bbiDuplicate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDuplicate_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save Your Customization";
            this.bbiSave.Id = 52;
            this.bbiSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.LargeImage")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiChangeMasterPassword
            // 
            this.bbiChangeMasterPassword.Caption = "Change Master Password";
            this.bbiChangeMasterPassword.Id = 53;
            this.bbiChangeMasterPassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiChangeMasterPassword.ImageOptions.SvgImage")));
            this.bbiChangeMasterPassword.Name = "bbiChangeMasterPassword";
            this.bbiChangeMasterPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangeMasterPassword_ItemClick);
            // 
            // barStaticItemFileName
            // 
            this.barStaticItemFileName.Caption = "barStaticItem1";
            this.barStaticItemFileName.Id = 55;
            this.barStaticItemFileName.Name = "barStaticItemFileName";
            // 
            // barStaticVersion
            // 
            this.barStaticVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticVersion.Caption = "barStaticVersion";
            this.barStaticVersion.Id = 56;
            this.barStaticVersion.Name = "barStaticVersion";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDuplicate);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Theme";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiChangeMasterPassword);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Settings";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiOpenDataFolder);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Your Data";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemFileName);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticVersion);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 947);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1541, 37);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Location = new System.Drawing.Point(235, 434);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(250, 130);
            this.popupControlContainer1.TabIndex = 4;
            this.popupControlContainer1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 984);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Smart Password Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.BarButtonItem bbSave;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraBars.BarButtonItem bbWebCredential;
        private DevExpress.XtraBars.BarButtonItem bbDatabaseCredential;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbApiCrendential;
        private DevExpress.XtraBars.BarButtonItem bbAppCredential;
        private DevExpress.XtraBars.BarButtonItem bbBankCredential;
        private DevExpress.XtraBars.BarButtonItem bbComputerCredential;
        private DevExpress.XtraBars.BarButtonItem bbCreditCardCredential;
        private DevExpress.XtraBars.BarButtonItem bbEmailCredential;
        private DevExpress.XtraBars.BarButtonItem bbWifiNetworkCredential;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.BarButtonItem bbiOpenDataFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDuplicate;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bbiChangeMasterPassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarStaticItem barStaticItemFileName;
        private DevExpress.XtraBars.BarStaticItem barStaticVersion;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}