namespace Book.UI.Query
{
    partial class OutDepotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutDepotForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpEditDepotEnd = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceDepot = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditDepotStar = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_DepotOutIdEnd = new DevExpress.XtraEditors.TextEdit();
            this.txt_DepotOutIdStart = new DevExpress.XtraEditors.TextEdit();
            this.date_End = new DevExpress.XtraEditors.DateEdit();
            this.date_Start = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepotEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepotStar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepotOutIdEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepotOutIdStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.AccessibleDescription = null;
            this.simpleButtonOK.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonOK, "simpleButtonOK");
            this.simpleButtonOK.BackgroundImage = null;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.AccessibleDescription = null;
            this.simpleButtonCancel.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonCancel, "simpleButtonCancel");
            this.simpleButtonCancel.BackgroundImage = null;
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AccessibleDescription = null;
            this.layoutControl1.AccessibleName = null;
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.BackgroundImage = null;
            this.layoutControl1.Controls.Add(this.lookUpEditDepotEnd);
            this.layoutControl1.Controls.Add(this.lookUpEditDepotStar);
            this.layoutControl1.Controls.Add(this.txt_DepotOutIdEnd);
            this.layoutControl1.Controls.Add(this.txt_DepotOutIdStart);
            this.layoutControl1.Controls.Add(this.date_End);
            this.layoutControl1.Controls.Add(this.date_Start);
            this.layoutControl1.Font = null;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // lookUpEditDepotEnd
            // 
            resources.ApplyResources(this.lookUpEditDepotEnd, "lookUpEditDepotEnd");
            this.lookUpEditDepotEnd.BackgroundImage = null;
            this.lookUpEditDepotEnd.EditValue = null;
            this.lookUpEditDepotEnd.Name = "lookUpEditDepotEnd";
            this.lookUpEditDepotEnd.Properties.AccessibleDescription = null;
            this.lookUpEditDepotEnd.Properties.AccessibleName = null;
            this.lookUpEditDepotEnd.Properties.AutoHeight = ((bool)(resources.GetObject("lookUpEditDepotEnd.Properties.AutoHeight")));
            this.lookUpEditDepotEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lookUpEditDepotEnd.Properties.Buttons"))))});
            this.lookUpEditDepotEnd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lookUpEditDepotEnd.Properties.Columns"), resources.GetString("lookUpEditDepotEnd.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lookUpEditDepotEnd.Properties.Columns2"), resources.GetString("lookUpEditDepotEnd.Properties.Columns3"))});
            this.lookUpEditDepotEnd.Properties.DataSource = this.bindingSourceDepot;
            this.lookUpEditDepotEnd.Properties.DisplayMember = "DepotName";
            this.lookUpEditDepotEnd.Properties.NullText = resources.GetString("lookUpEditDepotEnd.Properties.NullText");
            this.lookUpEditDepotEnd.Properties.NullValuePrompt = resources.GetString("lookUpEditDepotEnd.Properties.NullValuePrompt");
            this.lookUpEditDepotEnd.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("lookUpEditDepotEnd.Properties.NullValuePromptShowForEmptyValue")));
            this.lookUpEditDepotEnd.Properties.ValueMember = "DepotId";
            this.lookUpEditDepotEnd.StyleController = this.layoutControl1;
            // 
            // lookUpEditDepotStar
            // 
            resources.ApplyResources(this.lookUpEditDepotStar, "lookUpEditDepotStar");
            this.lookUpEditDepotStar.BackgroundImage = null;
            this.lookUpEditDepotStar.EditValue = null;
            this.lookUpEditDepotStar.Name = "lookUpEditDepotStar";
            this.lookUpEditDepotStar.Properties.AccessibleDescription = null;
            this.lookUpEditDepotStar.Properties.AccessibleName = null;
            this.lookUpEditDepotStar.Properties.AutoHeight = ((bool)(resources.GetObject("lookUpEditDepotStar.Properties.AutoHeight")));
            this.lookUpEditDepotStar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lookUpEditDepotStar.Properties.Buttons"))))});
            this.lookUpEditDepotStar.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lookUpEditDepotStar.Properties.Columns"), resources.GetString("lookUpEditDepotStar.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lookUpEditDepotStar.Properties.Columns2"), resources.GetString("lookUpEditDepotStar.Properties.Columns3"))});
            this.lookUpEditDepotStar.Properties.DataSource = this.bindingSourceDepot;
            this.lookUpEditDepotStar.Properties.DisplayMember = "DepotName";
            this.lookUpEditDepotStar.Properties.NullText = resources.GetString("lookUpEditDepotStar.Properties.NullText");
            this.lookUpEditDepotStar.Properties.NullValuePrompt = resources.GetString("lookUpEditDepotStar.Properties.NullValuePrompt");
            this.lookUpEditDepotStar.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("lookUpEditDepotStar.Properties.NullValuePromptShowForEmptyValue")));
            this.lookUpEditDepotStar.Properties.ValueMember = "DepotId";
            this.lookUpEditDepotStar.StyleController = this.layoutControl1;
            // 
            // txt_DepotOutIdEnd
            // 
            resources.ApplyResources(this.txt_DepotOutIdEnd, "txt_DepotOutIdEnd");
            this.txt_DepotOutIdEnd.BackgroundImage = null;
            this.txt_DepotOutIdEnd.EditValue = null;
            this.txt_DepotOutIdEnd.Name = "txt_DepotOutIdEnd";
            this.txt_DepotOutIdEnd.Properties.AccessibleDescription = null;
            this.txt_DepotOutIdEnd.Properties.AccessibleName = null;
            this.txt_DepotOutIdEnd.Properties.AutoHeight = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.AutoHeight")));
            this.txt_DepotOutIdEnd.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.AutoComplete")));
            this.txt_DepotOutIdEnd.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.BeepOnError")));
            this.txt_DepotOutIdEnd.Properties.Mask.EditMask = resources.GetString("txt_DepotOutIdEnd.Properties.Mask.EditMask");
            this.txt_DepotOutIdEnd.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.IgnoreMaskBlank")));
            this.txt_DepotOutIdEnd.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.MaskType")));
            this.txt_DepotOutIdEnd.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.PlaceHolder")));
            this.txt_DepotOutIdEnd.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.SaveLiteral")));
            this.txt_DepotOutIdEnd.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.ShowPlaceHolders")));
            this.txt_DepotOutIdEnd.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txt_DepotOutIdEnd.Properties.NullValuePrompt = resources.GetString("txt_DepotOutIdEnd.Properties.NullValuePrompt");
            this.txt_DepotOutIdEnd.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txt_DepotOutIdEnd.Properties.NullValuePromptShowForEmptyValue")));
            this.txt_DepotOutIdEnd.StyleController = this.layoutControl1;
            // 
            // txt_DepotOutIdStart
            // 
            resources.ApplyResources(this.txt_DepotOutIdStart, "txt_DepotOutIdStart");
            this.txt_DepotOutIdStart.BackgroundImage = null;
            this.txt_DepotOutIdStart.EditValue = null;
            this.txt_DepotOutIdStart.Name = "txt_DepotOutIdStart";
            this.txt_DepotOutIdStart.Properties.AccessibleDescription = null;
            this.txt_DepotOutIdStart.Properties.AccessibleName = null;
            this.txt_DepotOutIdStart.Properties.AutoHeight = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.AutoHeight")));
            this.txt_DepotOutIdStart.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.AutoComplete")));
            this.txt_DepotOutIdStart.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.BeepOnError")));
            this.txt_DepotOutIdStart.Properties.Mask.EditMask = resources.GetString("txt_DepotOutIdStart.Properties.Mask.EditMask");
            this.txt_DepotOutIdStart.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.IgnoreMaskBlank")));
            this.txt_DepotOutIdStart.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.MaskType")));
            this.txt_DepotOutIdStart.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.PlaceHolder")));
            this.txt_DepotOutIdStart.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.SaveLiteral")));
            this.txt_DepotOutIdStart.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.ShowPlaceHolders")));
            this.txt_DepotOutIdStart.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txt_DepotOutIdStart.Properties.NullValuePrompt = resources.GetString("txt_DepotOutIdStart.Properties.NullValuePrompt");
            this.txt_DepotOutIdStart.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txt_DepotOutIdStart.Properties.NullValuePromptShowForEmptyValue")));
            this.txt_DepotOutIdStart.StyleController = this.layoutControl1;
            // 
            // date_End
            // 
            resources.ApplyResources(this.date_End, "date_End");
            this.date_End.BackgroundImage = null;
            this.date_End.EditValue = null;
            this.date_End.Name = "date_End";
            this.date_End.Properties.AccessibleDescription = null;
            this.date_End.Properties.AccessibleName = null;
            this.date_End.Properties.AutoHeight = ((bool)(resources.GetObject("date_End.Properties.AutoHeight")));
            this.date_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("date_End.Properties.Buttons"))))});
            this.date_End.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("date_End.Properties.Mask.AutoComplete")));
            this.date_End.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("date_End.Properties.Mask.BeepOnError")));
            this.date_End.Properties.Mask.EditMask = resources.GetString("date_End.Properties.Mask.EditMask");
            this.date_End.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("date_End.Properties.Mask.IgnoreMaskBlank")));
            this.date_End.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("date_End.Properties.Mask.MaskType")));
            this.date_End.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("date_End.Properties.Mask.PlaceHolder")));
            this.date_End.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("date_End.Properties.Mask.SaveLiteral")));
            this.date_End.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("date_End.Properties.Mask.ShowPlaceHolders")));
            this.date_End.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("date_End.Properties.Mask.UseMaskAsDisplayFormat")));
            this.date_End.Properties.NullValuePrompt = resources.GetString("date_End.Properties.NullValuePrompt");
            this.date_End.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("date_End.Properties.NullValuePromptShowForEmptyValue")));
            this.date_End.Properties.VistaTimeProperties.AccessibleDescription = null;
            this.date_End.Properties.VistaTimeProperties.AccessibleName = null;
            this.date_End.Properties.VistaTimeProperties.AutoHeight = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.AutoHeight")));
            this.date_End.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_End.Properties.VistaTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.AutoComplete")));
            this.date_End.Properties.VistaTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.BeepOnError")));
            this.date_End.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("date_End.Properties.VistaTimeProperties.Mask.EditMask");
            this.date_End.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank")));
            this.date_End.Properties.VistaTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.MaskType")));
            this.date_End.Properties.VistaTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.PlaceHolder")));
            this.date_End.Properties.VistaTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.SaveLiteral")));
            this.date_End.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.ShowPlaceHolders")));
            this.date_End.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.date_End.Properties.VistaTimeProperties.NullValuePrompt = resources.GetString("date_End.Properties.VistaTimeProperties.NullValuePrompt");
            this.date_End.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("date_End.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue")));
            this.date_End.StyleController = this.layoutControl1;
            // 
            // date_Start
            // 
            resources.ApplyResources(this.date_Start, "date_Start");
            this.date_Start.BackgroundImage = null;
            this.date_Start.EditValue = null;
            this.date_Start.Name = "date_Start";
            this.date_Start.Properties.AccessibleDescription = null;
            this.date_Start.Properties.AccessibleName = null;
            this.date_Start.Properties.AutoHeight = ((bool)(resources.GetObject("date_Start.Properties.AutoHeight")));
            this.date_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("date_Start.Properties.Buttons"))))});
            this.date_Start.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("date_Start.Properties.Mask.AutoComplete")));
            this.date_Start.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("date_Start.Properties.Mask.BeepOnError")));
            this.date_Start.Properties.Mask.EditMask = resources.GetString("date_Start.Properties.Mask.EditMask");
            this.date_Start.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("date_Start.Properties.Mask.IgnoreMaskBlank")));
            this.date_Start.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("date_Start.Properties.Mask.MaskType")));
            this.date_Start.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("date_Start.Properties.Mask.PlaceHolder")));
            this.date_Start.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("date_Start.Properties.Mask.SaveLiteral")));
            this.date_Start.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("date_Start.Properties.Mask.ShowPlaceHolders")));
            this.date_Start.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("date_Start.Properties.Mask.UseMaskAsDisplayFormat")));
            this.date_Start.Properties.NullValuePrompt = resources.GetString("date_Start.Properties.NullValuePrompt");
            this.date_Start.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("date_Start.Properties.NullValuePromptShowForEmptyValue")));
            this.date_Start.Properties.VistaTimeProperties.AccessibleDescription = null;
            this.date_Start.Properties.VistaTimeProperties.AccessibleName = null;
            this.date_Start.Properties.VistaTimeProperties.AutoHeight = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.AutoHeight")));
            this.date_Start.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_Start.Properties.VistaTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.AutoComplete")));
            this.date_Start.Properties.VistaTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.BeepOnError")));
            this.date_Start.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("date_Start.Properties.VistaTimeProperties.Mask.EditMask");
            this.date_Start.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank")));
            this.date_Start.Properties.VistaTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.MaskType")));
            this.date_Start.Properties.VistaTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.PlaceHolder")));
            this.date_Start.Properties.VistaTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.SaveLiteral")));
            this.date_Start.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.ShowPlaceHolders")));
            this.date_Start.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.date_Start.Properties.VistaTimeProperties.NullValuePrompt = resources.GetString("date_Start.Properties.VistaTimeProperties.NullValuePrompt");
            this.date_Start.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("date_Start.Properties.VistaTimeProperties.NullValuePromptShowForEmptyValue")));
            this.date_Start.StyleController = this.layoutControl1;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(520, 145);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.date_Start;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.date_End;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_DepotOutIdStart;
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_DepotOutIdEnd;
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.Location = new System.Drawing.Point(250, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 14);
            // 
            // emptySpaceItem4
            // 
            resources.ApplyResources(this.emptySpaceItem4, "emptySpaceItem4");
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 75);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(500, 50);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEditDepotStar;
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lookUpEditDepotEnd;
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.Location = new System.Drawing.Point(250, 50);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(250, 25);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(75, 14);
            // 
            // OutDepotForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Icon = null;
            this.Name = "OutDepotForm";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.Controls.SetChildIndex(this.simpleButtonCancel, 0);
            this.Controls.SetChildIndex(this.simpleButtonOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepotEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepotStar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepotOutIdEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DepotOutIdStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit date_End;
        private DevExpress.XtraEditors.DateEdit date_Start;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txt_DepotOutIdEnd;
        private DevExpress.XtraEditors.TextEdit txt_DepotOutIdStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepotEnd;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepotStar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource bindingSourceDepot;
    }
}