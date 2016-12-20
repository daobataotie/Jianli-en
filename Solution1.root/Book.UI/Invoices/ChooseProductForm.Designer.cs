namespace Book.UI.Invoices
{
    partial class ChooseProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseProductForm));
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSpecification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPriceB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPriceC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductRetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCost0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCost1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonAllPro = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.textEditSeach = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditSeach = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButtonSeach = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSeach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeach.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichTextEdit1,
            this.repositoryItemCheckEdit1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductCategoryId,
            this.colProductName,
            this.colProductUnit,
            this.colProductBarCode,
            this.colProductSpecification,
            this.colProductModel,
            this.gridColumn1,
            this.gridColumn2,
            this.colProductVersion,
            this.colProductPriceB,
            this.colProductPriceC,
            this.colProductRetailPrice,
            this.colProductCost0,
            this.colProductCost1,
            this.colProductDescription,
            this.gridColumnChecked});
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindFilterColumns = "ProductName";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.AccessibleDescription = null;
            this.simpleButtonCancel.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonCancel, "simpleButtonCancel");
            this.simpleButtonCancel.BackgroundImage = null;
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.AccessibleDescription = null;
            this.simpleButtonOK.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonOK, "simpleButtonOK");
            this.simpleButtonOK.BackgroundImage = null;
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.AccessibleDescription = null;
            this.simpleButtonNew.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonNew, "simpleButtonNew");
            this.simpleButtonNew.BackgroundImage = null;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.AccessibleDescription = null;
            this.listBoxControl1.AccessibleName = null;
            resources.ApplyResources(this.listBoxControl1, "listBoxControl1");
            this.listBoxControl1.BackgroundImage = null;
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.CurrentChanged += new System.EventHandler(this.productCategoryBindingSource_CurrentChanged);
            // 
            // colProductId
            // 
            this.colProductId.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductId.AppearanceCell.GradientMode")));
            this.colProductId.AppearanceCell.Image = null;
            this.colProductId.AppearanceCell.Options.UseTextOptions = true;
            this.colProductId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductId.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductId.AppearanceHeader.GradientMode")));
            this.colProductId.AppearanceHeader.Image = null;
            this.colProductId.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductId, "colProductId");
            this.colProductId.FieldName = "Id";
            this.colProductId.Name = "colProductId";
            this.colProductId.OptionsColumn.AllowEdit = false;
            // 
            // colProductCategoryId
            // 
            this.colProductCategoryId.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCategoryId.AppearanceCell.GradientMode")));
            this.colProductCategoryId.AppearanceCell.Image = null;
            this.colProductCategoryId.AppearanceCell.Options.UseTextOptions = true;
            this.colProductCategoryId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductCategoryId.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCategoryId.AppearanceHeader.GradientMode")));
            this.colProductCategoryId.AppearanceHeader.Image = null;
            this.colProductCategoryId.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductCategoryId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductCategoryId, "colProductCategoryId");
            this.colProductCategoryId.FieldName = "ProductCategoryId";
            this.colProductCategoryId.Name = "colProductCategoryId";
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductName.AppearanceCell.GradientMode")));
            this.colProductName.AppearanceCell.Image = null;
            this.colProductName.AppearanceCell.Options.UseTextOptions = true;
            this.colProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductName.AppearanceHeader.GradientMode")));
            this.colProductName.AppearanceHeader.Image = null;
            this.colProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductName, "colProductName");
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            // 
            // colProductUnit
            // 
            this.colProductUnit.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductUnit.AppearanceCell.GradientMode")));
            this.colProductUnit.AppearanceCell.Image = null;
            this.colProductUnit.AppearanceCell.Options.UseTextOptions = true;
            this.colProductUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductUnit.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductUnit.AppearanceHeader.GradientMode")));
            this.colProductUnit.AppearanceHeader.Image = null;
            this.colProductUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProductUnit, "colProductUnit");
            this.colProductUnit.FieldName = "MainUnit";
            this.colProductUnit.Name = "colProductUnit";
            this.colProductUnit.OptionsColumn.AllowEdit = false;
            // 
            // colProductBarCode
            // 
            resources.ApplyResources(this.colProductBarCode, "colProductBarCode");
            this.colProductBarCode.FieldName = "ProductBarCode";
            this.colProductBarCode.Name = "colProductBarCode";
            // 
            // colProductSpecification
            // 
            this.colProductSpecification.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductSpecification.AppearanceCell.GradientMode")));
            this.colProductSpecification.AppearanceCell.Image = null;
            this.colProductSpecification.AppearanceCell.Options.UseTextOptions = true;
            this.colProductSpecification.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductSpecification.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductSpecification.AppearanceHeader.GradientMode")));
            this.colProductSpecification.AppearanceHeader.Image = null;
            this.colProductSpecification.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductSpecification.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductSpecification, "colProductSpecification");
            this.colProductSpecification.FieldName = "ProductSpecification";
            this.colProductSpecification.Name = "colProductSpecification";
            this.colProductSpecification.OptionsColumn.AllowEdit = false;
            // 
            // colProductModel
            // 
            this.colProductModel.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductModel.AppearanceCell.GradientMode")));
            this.colProductModel.AppearanceCell.Image = null;
            this.colProductModel.AppearanceCell.Options.UseTextOptions = true;
            this.colProductModel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductModel.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductModel.AppearanceHeader.GradientMode")));
            this.colProductModel.AppearanceHeader.Image = null;
            this.colProductModel.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductModel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductModel, "colProductModel");
            this.colProductModel.FieldName = "ProductModel";
            this.colProductModel.Name = "colProductModel";
            // 
            // colProductVersion
            // 
            this.colProductVersion.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductVersion.AppearanceCell.GradientMode")));
            this.colProductVersion.AppearanceCell.Image = null;
            this.colProductVersion.AppearanceCell.Options.UseTextOptions = true;
            this.colProductVersion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductVersion.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductVersion.AppearanceHeader.GradientMode")));
            this.colProductVersion.AppearanceHeader.Image = null;
            this.colProductVersion.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductVersion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductVersion, "colProductVersion");
            this.colProductVersion.FieldName = "ProductVersion";
            this.colProductVersion.Name = "colProductVersion";
            // 
            // colProductPriceB
            // 
            this.colProductPriceB.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductPriceB.AppearanceCell.GradientMode")));
            this.colProductPriceB.AppearanceCell.Image = null;
            this.colProductPriceB.AppearanceCell.Options.UseTextOptions = true;
            this.colProductPriceB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductPriceB.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductPriceB.AppearanceHeader.GradientMode")));
            this.colProductPriceB.AppearanceHeader.Image = null;
            this.colProductPriceB.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductPriceB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductPriceB, "colProductPriceB");
            this.colProductPriceB.FieldName = "ProductPriceB";
            this.colProductPriceB.Name = "colProductPriceB";
            // 
            // colProductPriceC
            // 
            this.colProductPriceC.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductPriceC.AppearanceCell.GradientMode")));
            this.colProductPriceC.AppearanceCell.Image = null;
            this.colProductPriceC.AppearanceCell.Options.UseTextOptions = true;
            this.colProductPriceC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductPriceC.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductPriceC.AppearanceHeader.GradientMode")));
            this.colProductPriceC.AppearanceHeader.Image = null;
            this.colProductPriceC.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductPriceC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductPriceC, "colProductPriceC");
            this.colProductPriceC.FieldName = "ProductPriceC";
            this.colProductPriceC.Name = "colProductPriceC";
            // 
            // colProductRetailPrice
            // 
            this.colProductRetailPrice.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductRetailPrice.AppearanceCell.GradientMode")));
            this.colProductRetailPrice.AppearanceCell.Image = null;
            this.colProductRetailPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colProductRetailPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductRetailPrice.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductRetailPrice.AppearanceHeader.GradientMode")));
            this.colProductRetailPrice.AppearanceHeader.Image = null;
            this.colProductRetailPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductRetailPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductRetailPrice, "colProductRetailPrice");
            this.colProductRetailPrice.FieldName = "ProductRetailPrice";
            this.colProductRetailPrice.Name = "colProductRetailPrice";
            // 
            // colProductCost0
            // 
            this.colProductCost0.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCost0.AppearanceCell.GradientMode")));
            this.colProductCost0.AppearanceCell.Image = null;
            this.colProductCost0.AppearanceCell.Options.UseTextOptions = true;
            this.colProductCost0.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductCost0.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCost0.AppearanceHeader.GradientMode")));
            this.colProductCost0.AppearanceHeader.Image = null;
            this.colProductCost0.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductCost0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductCost0, "colProductCost0");
            this.colProductCost0.FieldName = "ProductCost0";
            this.colProductCost0.Name = "colProductCost0";
            // 
            // colProductCost1
            // 
            this.colProductCost1.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCost1.AppearanceCell.GradientMode")));
            this.colProductCost1.AppearanceCell.Image = null;
            this.colProductCost1.AppearanceCell.Options.UseTextOptions = true;
            this.colProductCost1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductCost1.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductCost1.AppearanceHeader.GradientMode")));
            this.colProductCost1.AppearanceHeader.Image = null;
            this.colProductCost1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductCost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductCost1, "colProductCost1");
            this.colProductCost1.FieldName = "ProductStandardCost";
            this.colProductCost1.Name = "colProductCost1";
            // 
            // colProductDescription
            // 
            this.colProductDescription.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductDescription.AppearanceCell.GradientMode")));
            this.colProductDescription.AppearanceCell.Image = null;
            this.colProductDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colProductDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProductDescription.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProductDescription.AppearanceHeader.GradientMode")));
            this.colProductDescription.AppearanceHeader.Image = null;
            this.colProductDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colProductDescription, "colProductDescription");
            this.colProductDescription.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.colProductDescription.FieldName = "ProductDescription";
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.AccessibleDescription = null;
            this.repositoryItemRichTextEdit1.AccessibleName = null;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "Customer";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "CustomerProductName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // simpleButtonAllPro
            // 
            this.simpleButtonAllPro.AccessibleDescription = null;
            this.simpleButtonAllPro.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonAllPro, "simpleButtonAllPro");
            this.simpleButtonAllPro.BackgroundImage = null;
            this.simpleButtonAllPro.Name = "simpleButtonAllPro";
            this.simpleButtonAllPro.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridColumnChecked
            // 
            resources.ApplyResources(this.gridColumnChecked, "gridColumnChecked");
            this.gridColumnChecked.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumnChecked.FieldName = "Checked";
            this.gridColumnChecked.Name = "gridColumnChecked";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AccessibleDescription = null;
            this.repositoryItemCheckEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemCheckEdit1, "repositoryItemCheckEdit1");
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // textEditSeach
            // 
            resources.ApplyResources(this.textEditSeach, "textEditSeach");
            this.textEditSeach.BackgroundImage = null;
            this.textEditSeach.EditValue = null;
            this.textEditSeach.Name = "textEditSeach";
            this.textEditSeach.Properties.AccessibleDescription = null;
            this.textEditSeach.Properties.AccessibleName = null;
            this.textEditSeach.Properties.AutoHeight = ((bool)(resources.GetObject("textEditSeach.Properties.AutoHeight")));
            this.textEditSeach.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("textEditSeach.Properties.Mask.AutoComplete")));
            this.textEditSeach.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("textEditSeach.Properties.Mask.BeepOnError")));
            this.textEditSeach.Properties.Mask.EditMask = resources.GetString("textEditSeach.Properties.Mask.EditMask");
            this.textEditSeach.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("textEditSeach.Properties.Mask.IgnoreMaskBlank")));
            this.textEditSeach.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("textEditSeach.Properties.Mask.MaskType")));
            this.textEditSeach.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("textEditSeach.Properties.Mask.PlaceHolder")));
            this.textEditSeach.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("textEditSeach.Properties.Mask.SaveLiteral")));
            this.textEditSeach.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("textEditSeach.Properties.Mask.ShowPlaceHolders")));
            this.textEditSeach.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("textEditSeach.Properties.Mask.UseMaskAsDisplayFormat")));
            this.textEditSeach.Properties.NullValuePrompt = resources.GetString("textEditSeach.Properties.NullValuePrompt");
            this.textEditSeach.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("textEditSeach.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // comboBoxEditSeach
            // 
            resources.ApplyResources(this.comboBoxEditSeach, "comboBoxEditSeach");
            this.comboBoxEditSeach.BackgroundImage = null;
            this.comboBoxEditSeach.EditValue = null;
            this.comboBoxEditSeach.Name = "comboBoxEditSeach";
            this.comboBoxEditSeach.Properties.AccessibleDescription = null;
            this.comboBoxEditSeach.Properties.AccessibleName = null;
            this.comboBoxEditSeach.Properties.AutoHeight = ((bool)(resources.GetObject("comboBoxEditSeach.Properties.AutoHeight")));
            this.comboBoxEditSeach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxEditSeach.Properties.Buttons"))))});
            this.comboBoxEditSeach.Properties.Items.AddRange(new object[] {
            resources.GetString("comboBoxEditSeach.Properties.Items"),
            resources.GetString("comboBoxEditSeach.Properties.Items1"),
            resources.GetString("comboBoxEditSeach.Properties.Items2")});
            this.comboBoxEditSeach.Properties.NullValuePrompt = resources.GetString("comboBoxEditSeach.Properties.NullValuePrompt");
            this.comboBoxEditSeach.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("comboBoxEditSeach.Properties.NullValuePromptShowForEmptyValue")));
            this.comboBoxEditSeach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // simpleButtonSeach
            // 
            this.simpleButtonSeach.AccessibleDescription = null;
            this.simpleButtonSeach.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonSeach, "simpleButtonSeach");
            this.simpleButtonSeach.BackgroundImage = null;
            this.simpleButtonSeach.Name = "simpleButtonSeach";
            this.simpleButtonSeach.Click += new System.EventHandler(this.simpleButtonSeach_Click);
            // 
            // ChooseProductForm
            // 
            this.AcceptButton = this.simpleButtonSeach;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButtonSeach);
            this.Controls.Add(this.comboBoxEditSeach);
            this.Controls.Add(this.textEditSeach);
            this.Controls.Add(this.simpleButtonAllPro);
            this.Controls.Add(this.listBoxControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = null;
            this.MaximizeBox = true;
            this.Name = "ChooseProductForm";
            this.Load += new System.EventHandler(this.ChooseProductForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseProductForm_FormClosing);
            this.Controls.SetChildIndex(this.simpleButtonCancel, 0);
            this.Controls.SetChildIndex(this.simpleButtonOK, 0);
            this.Controls.SetChildIndex(this.simpleButtonNew, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.listBoxControl1, 0);
            this.Controls.SetChildIndex(this.simpleButtonAllPro, 0);
            this.Controls.SetChildIndex(this.textEditSeach, 0);
            this.Controls.SetChildIndex(this.comboBoxEditSeach, 0);
            this.Controls.SetChildIndex(this.simpleButtonSeach, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSeach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeach.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSpecification;
        private DevExpress.XtraGrid.Columns.GridColumn colProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn colProductVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPriceB;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPriceC;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCost0;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCost1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAllPro;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnChecked;
        private DevExpress.XtraEditors.TextEdit textEditSeach;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSeach;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSeach;
    }
}