namespace Book.UI.Hr.Attendance.Atten
{
    partial class AnormalySalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnormalySalaryForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DutyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.ShouldCheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.ShouldCheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.ActualCheckIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.ActualCheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTimeEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AccessibleDescription = null;
            this.layoutControl1.AccessibleName = null;
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.BackgroundImage = null;
            this.layoutControl1.Controls.Add(this.sbtn_print);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Font = null;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // sbtn_print
            // 
            this.sbtn_print.AccessibleDescription = null;
            this.sbtn_print.AccessibleName = null;
            resources.ApplyResources(this.sbtn_print, "sbtn_print");
            this.sbtn_print.BackgroundImage = null;
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.StyleController = this.layoutControl1;
            this.sbtn_print.Click += new System.EventHandler(this.sbtn_print_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleDescription = null;
            this.gridControl1.AccessibleName = null;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.BackgroundImage = null;
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.EmbeddedNavigator.AccessibleDescription = null;
            this.gridControl1.EmbeddedNavigator.AccessibleName = null;
            this.gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControl1.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControl1.EmbeddedNavigator.Anchor")));
            this.gridControl1.EmbeddedNavigator.BackgroundImage = null;
            this.gridControl1.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControl1.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControl1.EmbeddedNavigator.ImeMode")));
            this.gridControl1.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControl1.EmbeddedNavigator.TextLocation")));
            this.gridControl1.EmbeddedNavigator.ToolTip = resources.GetString("gridControl1.EmbeddedNavigator.ToolTip");
            this.gridControl1.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControl1.EmbeddedNavigator.ToolTipIconType")));
            this.gridControl1.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControl1.EmbeddedNavigator.ToolTipTitle");
            this.gridControl1.Font = null;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeEdit2,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTimeEdit3,
            this.repositoryItemTimeEdit4,
            this.repositoryItemTimeEdit5,
            this.repositoryItemDateEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DutyDate,
            this.Employee,
            this.EmployeeName,
            this.ShouldCheckIn,
            this.ShouldCheckOut,
            this.ActualCheckIn,
            this.ActualCheckOut,
            this.Note});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // DutyDate
            // 
            resources.ApplyResources(this.DutyDate, "DutyDate");
            this.DutyDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.DutyDate.DisplayFormat.FormatString = "yyyy:MM:dd";
            this.DutyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DutyDate.FieldName = "DutyDate";
            this.DutyDate.Name = "DutyDate";
            this.DutyDate.OptionsColumn.AllowEdit = false;
            this.DutyDate.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AccessibleDescription = null;
            this.repositoryItemDateEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemDateEdit1, "repositoryItemDateEdit1");
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.Buttons"))))});
            this.repositoryItemDateEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit1.Mask.AutoComplete")));
            this.repositoryItemDateEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.BeepOnError")));
            this.repositoryItemDateEdit1.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.Mask.EditMask");
            this.repositoryItemDateEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit1.Mask.MaskType")));
            this.repositoryItemDateEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit1.Mask.PlaceHolder")));
            this.repositoryItemDateEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.SaveLiteral")));
            this.repositoryItemDateEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.AccessibleDescription = null;
            this.repositoryItemDateEdit1.VistaTimeProperties.AccessibleName = null;
            this.repositoryItemDateEdit1.VistaTimeProperties.AutoHeight = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.AutoHeight")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.AutoComplete")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.BeepOnError")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.VistaTimeProperties.Mask.EditMask");
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.MaskType")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.PlaceHolder")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.SaveLiteral")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit1.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit1.VistaTimeProperties.NullValuePrompt = resources.GetString("repositoryItemDateEdit1.VistaTimeProperties.NullValuePrompt");
            this.repositoryItemDateEdit1.VistaTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("repositoryItemDateEdit1.VistaTimeProperties.NullValuePromptShowForEmptyValue")));
            // 
            // Employee
            // 
            resources.ApplyResources(this.Employee, "Employee");
            this.Employee.Name = "Employee";
            this.Employee.OptionsColumn.AllowEdit = false;
            this.Employee.OptionsColumn.ReadOnly = true;
            // 
            // EmployeeName
            // 
            resources.ApplyResources(this.EmployeeName, "EmployeeName");
            this.EmployeeName.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AccessibleDescription = null;
            this.repositoryItemHyperLinkEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemHyperLinkEdit1, "repositoryItemHyperLinkEdit1");
            this.repositoryItemHyperLinkEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.AutoComplete")));
            this.repositoryItemHyperLinkEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.BeepOnError")));
            this.repositoryItemHyperLinkEdit1.Mask.EditMask = resources.GetString("repositoryItemHyperLinkEdit1.Mask.EditMask");
            this.repositoryItemHyperLinkEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemHyperLinkEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.MaskType")));
            this.repositoryItemHyperLinkEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.PlaceHolder")));
            this.repositoryItemHyperLinkEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.SaveLiteral")));
            this.repositoryItemHyperLinkEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemHyperLinkEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemHyperLinkEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit1_Click);
            // 
            // ShouldCheckIn
            // 
            resources.ApplyResources(this.ShouldCheckIn, "ShouldCheckIn");
            this.ShouldCheckIn.ColumnEdit = this.repositoryItemTimeEdit1;
            this.ShouldCheckIn.DisplayFormat.FormatString = "HH:mm";
            this.ShouldCheckIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ShouldCheckIn.FieldName = "ShouldCheckIn";
            this.ShouldCheckIn.Name = "ShouldCheckIn";
            this.ShouldCheckIn.OptionsColumn.AllowEdit = false;
            this.ShouldCheckIn.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AccessibleDescription = null;
            this.repositoryItemTimeEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTimeEdit1, "repositoryItemTimeEdit1");
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTimeEdit1.Mask.AutoComplete")));
            this.repositoryItemTimeEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTimeEdit1.Mask.BeepOnError")));
            this.repositoryItemTimeEdit1.Mask.EditMask = resources.GetString("repositoryItemTimeEdit1.Mask.EditMask");
            this.repositoryItemTimeEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTimeEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemTimeEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTimeEdit1.Mask.MaskType")));
            this.repositoryItemTimeEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTimeEdit1.Mask.PlaceHolder")));
            this.repositoryItemTimeEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTimeEdit1.Mask.SaveLiteral")));
            this.repositoryItemTimeEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTimeEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemTimeEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTimeEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // ShouldCheckOut
            // 
            resources.ApplyResources(this.ShouldCheckOut, "ShouldCheckOut");
            this.ShouldCheckOut.ColumnEdit = this.repositoryItemTimeEdit2;
            this.ShouldCheckOut.DisplayFormat.FormatString = "HH:mm";
            this.ShouldCheckOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ShouldCheckOut.FieldName = "ShouldCheckOut";
            this.ShouldCheckOut.Name = "ShouldCheckOut";
            this.ShouldCheckOut.OptionsColumn.AllowEdit = false;
            this.ShouldCheckOut.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AccessibleDescription = null;
            this.repositoryItemTimeEdit2.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTimeEdit2, "repositoryItemTimeEdit2");
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit2.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTimeEdit2.Mask.AutoComplete")));
            this.repositoryItemTimeEdit2.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTimeEdit2.Mask.BeepOnError")));
            this.repositoryItemTimeEdit2.Mask.EditMask = resources.GetString("repositoryItemTimeEdit2.Mask.EditMask");
            this.repositoryItemTimeEdit2.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTimeEdit2.Mask.IgnoreMaskBlank")));
            this.repositoryItemTimeEdit2.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTimeEdit2.Mask.MaskType")));
            this.repositoryItemTimeEdit2.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTimeEdit2.Mask.PlaceHolder")));
            this.repositoryItemTimeEdit2.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTimeEdit2.Mask.SaveLiteral")));
            this.repositoryItemTimeEdit2.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTimeEdit2.Mask.ShowPlaceHolders")));
            this.repositoryItemTimeEdit2.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTimeEdit2.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // ActualCheckIn
            // 
            resources.ApplyResources(this.ActualCheckIn, "ActualCheckIn");
            this.ActualCheckIn.ColumnEdit = this.repositoryItemTimeEdit3;
            this.ActualCheckIn.DisplayFormat.FormatString = "HH:mm";
            this.ActualCheckIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ActualCheckIn.FieldName = "ActualCheckIn";
            this.ActualCheckIn.Name = "ActualCheckIn";
            this.ActualCheckIn.OptionsColumn.AllowEdit = false;
            this.ActualCheckIn.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemTimeEdit3
            // 
            this.repositoryItemTimeEdit3.AccessibleDescription = null;
            this.repositoryItemTimeEdit3.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTimeEdit3, "repositoryItemTimeEdit3");
            this.repositoryItemTimeEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit3.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTimeEdit3.Mask.AutoComplete")));
            this.repositoryItemTimeEdit3.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTimeEdit3.Mask.BeepOnError")));
            this.repositoryItemTimeEdit3.Mask.EditMask = resources.GetString("repositoryItemTimeEdit3.Mask.EditMask");
            this.repositoryItemTimeEdit3.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTimeEdit3.Mask.IgnoreMaskBlank")));
            this.repositoryItemTimeEdit3.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTimeEdit3.Mask.MaskType")));
            this.repositoryItemTimeEdit3.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTimeEdit3.Mask.PlaceHolder")));
            this.repositoryItemTimeEdit3.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTimeEdit3.Mask.SaveLiteral")));
            this.repositoryItemTimeEdit3.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTimeEdit3.Mask.ShowPlaceHolders")));
            this.repositoryItemTimeEdit3.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTimeEdit3.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTimeEdit3.Name = "repositoryItemTimeEdit3";
            // 
            // ActualCheckOut
            // 
            resources.ApplyResources(this.ActualCheckOut, "ActualCheckOut");
            this.ActualCheckOut.ColumnEdit = this.repositoryItemTimeEdit4;
            this.ActualCheckOut.DisplayFormat.FormatString = "HH:mm";
            this.ActualCheckOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ActualCheckOut.FieldName = "ActualCheckOut";
            this.ActualCheckOut.Name = "ActualCheckOut";
            this.ActualCheckOut.OptionsColumn.AllowEdit = false;
            this.ActualCheckOut.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemTimeEdit4
            // 
            this.repositoryItemTimeEdit4.AccessibleDescription = null;
            this.repositoryItemTimeEdit4.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTimeEdit4, "repositoryItemTimeEdit4");
            this.repositoryItemTimeEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit4.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTimeEdit4.Mask.AutoComplete")));
            this.repositoryItemTimeEdit4.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTimeEdit4.Mask.BeepOnError")));
            this.repositoryItemTimeEdit4.Mask.EditMask = resources.GetString("repositoryItemTimeEdit4.Mask.EditMask");
            this.repositoryItemTimeEdit4.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTimeEdit4.Mask.IgnoreMaskBlank")));
            this.repositoryItemTimeEdit4.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTimeEdit4.Mask.MaskType")));
            this.repositoryItemTimeEdit4.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTimeEdit4.Mask.PlaceHolder")));
            this.repositoryItemTimeEdit4.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTimeEdit4.Mask.SaveLiteral")));
            this.repositoryItemTimeEdit4.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTimeEdit4.Mask.ShowPlaceHolders")));
            this.repositoryItemTimeEdit4.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTimeEdit4.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTimeEdit4.Name = "repositoryItemTimeEdit4";
            // 
            // Note
            // 
            resources.ApplyResources(this.Note, "Note");
            this.Note.FieldName = "Note";
            this.Note.Name = "Note";
            this.Note.OptionsColumn.AllowEdit = false;
            this.Note.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AccessibleDescription = null;
            this.repositoryItemCheckEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemCheckEdit1, "repositoryItemCheckEdit1");
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTimeEdit5
            // 
            this.repositoryItemTimeEdit5.AccessibleDescription = null;
            this.repositoryItemTimeEdit5.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTimeEdit5, "repositoryItemTimeEdit5");
            this.repositoryItemTimeEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit5.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTimeEdit5.Mask.AutoComplete")));
            this.repositoryItemTimeEdit5.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTimeEdit5.Mask.BeepOnError")));
            this.repositoryItemTimeEdit5.Mask.EditMask = resources.GetString("repositoryItemTimeEdit5.Mask.EditMask");
            this.repositoryItemTimeEdit5.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTimeEdit5.Mask.IgnoreMaskBlank")));
            this.repositoryItemTimeEdit5.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTimeEdit5.Mask.MaskType")));
            this.repositoryItemTimeEdit5.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTimeEdit5.Mask.PlaceHolder")));
            this.repositoryItemTimeEdit5.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTimeEdit5.Mask.SaveLiteral")));
            this.repositoryItemTimeEdit5.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTimeEdit5.Mask.ShowPlaceHolders")));
            this.repositoryItemTimeEdit5.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTimeEdit5.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTimeEdit5.Name = "repositoryItemTimeEdit5";
            // 
            // dateEdit1
            // 
            resources.ApplyResources(this.dateEdit1, "dateEdit1");
            this.dateEdit1.BackgroundImage = null;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.AccessibleDescription = null;
            this.dateEdit1.Properties.AccessibleName = null;
            this.dateEdit1.Properties.AutoHeight = ((bool)(resources.GetObject("dateEdit1.Properties.AutoHeight")));
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEdit1.Properties.Buttons"))))});
            this.dateEdit1.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("dateEdit1.Properties.Mask.AutoComplete")));
            this.dateEdit1.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("dateEdit1.Properties.Mask.BeepOnError")));
            this.dateEdit1.Properties.Mask.EditMask = resources.GetString("dateEdit1.Properties.Mask.EditMask");
            this.dateEdit1.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("dateEdit1.Properties.Mask.IgnoreMaskBlank")));
            this.dateEdit1.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("dateEdit1.Properties.Mask.MaskType")));
            this.dateEdit1.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("dateEdit1.Properties.Mask.PlaceHolder")));
            this.dateEdit1.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("dateEdit1.Properties.Mask.SaveLiteral")));
            this.dateEdit1.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("dateEdit1.Properties.Mask.ShowPlaceHolders")));
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("dateEdit1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.dateEdit1.Properties.NullDate = "";
            this.dateEdit1.Properties.NullValuePrompt = resources.GetString("dateEdit1.Properties.NullValuePrompt");
            this.dateEdit1.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("dateEdit1.Properties.NullValuePromptShowForEmptyValue")));
            this.dateEdit1.Properties.VistaTimeProperties.AccessibleDescription = null;
            this.dateEdit1.Properties.VistaTimeProperties.AccessibleName = null;
            this.dateEdit1.Properties.VistaTimeProperties.AutoHeight = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.AutoHeight")));
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Properties.VistaTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.AutoComplete")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.BeepOnError")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("dateEdit1.Properties.VistaTimeProperties.Mask.EditMask");
            this.dateEdit1.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.MaskType")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.PlaceHolder")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.SaveLiteral")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.ShowPlaceHolders")));
            this.dateEdit1.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.dateEdit1.Properties.VistaTimeProperties.NullValuePrompt = resources.GetString("dateEdit1.Properties.VistaTimeProperties.NullValuePrompt");
            this.dateEdit1.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("dateEdit1.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue")));
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(955, 440);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(196, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(38, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(935, 394);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.Location = new System.Drawing.Point(300, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(635, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbtn_print;
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.Location = new System.Drawing.Point(196, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // AnormalySalaryForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Icon = null;
            this.Name = "AnormalySalaryForm";
            this.Load += new System.EventHandler(this.AnormalySalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DutyDate;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Employee;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ShouldCheckIn;
        private DevExpress.XtraGrid.Columns.GridColumn ShouldCheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn ActualCheckIn;
        private DevExpress.XtraGrid.Columns.GridColumn ActualCheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit5;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}