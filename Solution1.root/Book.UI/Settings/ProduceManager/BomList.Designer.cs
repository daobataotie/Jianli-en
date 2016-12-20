namespace Book.UI.Settings.ProduceManager
{
    partial class BomList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BomList));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar1, "bar1");
            // 
            // imageCollection1
            // 
            resources.ApplyResources(this.imageCollection1, "imageCollection1");
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.AccessibleDescription = null;
            this.barStaticItem1.AccessibleName = null;
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            // 
            // layoutControl1
            // 
            this.layoutControl1.AccessibleDescription = null;
            this.layoutControl1.AccessibleName = null;
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.BackgroundImage = null;
            this.layoutControl1.Font = null;
            this.layoutControl1.Controls.SetChildIndex(this.gridControl1, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleDescription = null;
            this.gridControl1.AccessibleName = null;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.BackgroundImage = null;
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
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemRichTextEdit1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.ProductId,
            this.gridColumnName,
            this.gridColumn14,
            this.gridColumnCustomer,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn11,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.FieldName = "BomType";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            resources.ApplyResources(this.gridColumn5, "gridColumn5");
            this.gridColumn5.FieldName = "LossRate";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn9
            // 
            resources.ApplyResources(this.gridColumn9, "gridColumn9");
            this.gridColumn9.FieldName = "DefaultQuantity";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn11
            // 
            resources.ApplyResources(this.gridColumn11, "gridColumn11");
            this.gridColumn11.FieldName = "EmployeeAddName";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumnName
            // 
            resources.ApplyResources(this.gridColumnName, "gridColumnName");
            this.gridColumnName.FieldName = "ProductName";
            this.gridColumnName.Name = "gridColumnName";
            // 
            // gridColumn14
            // 
            resources.ApplyResources(this.gridColumn14, "gridColumn14");
            this.gridColumn14.FieldName = "CustomerProductName";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // ProductId
            // 
            resources.ApplyResources(this.ProductId, "ProductId");
            this.ProductId.FieldName = "ProId";
            this.ProductId.Name = "ProductId";
            // 
            // gridColumnCustomer
            // 
            resources.ApplyResources(this.gridColumnCustomer, "gridColumnCustomer");
            this.gridColumnCustomer.FieldName = "CustomerName";
            this.gridColumnCustomer.Name = "gridColumnCustomer";
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "BomVersion";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "IsEdit";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.AccessibleDescription = null;
            this.repositoryItemRichTextEdit1.AccessibleName = null;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AccessibleDescription = null;
            this.repositoryItemTextEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTextEdit1.Mask.AutoComplete")));
            this.repositoryItemTextEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.BeepOnError")));
            this.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask");
            this.repositoryItemTextEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemTextEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")));
            this.repositoryItemTextEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTextEdit1.Mask.PlaceHolder")));
            this.repositoryItemTextEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.SaveLiteral")));
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // BomList
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = null;
            this.Name = "BomList";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
    }
}