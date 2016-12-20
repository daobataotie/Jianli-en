namespace Book.UI.Invoices.CO
{
    partial class ChooseDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDetailsForm));
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceCODetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceCODetailQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceCODetailMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceCODetailNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.AccessibleDescription = null;
            this.simpleButtonOK.AccessibleName = null;
            resources.ApplyResources(this.simpleButtonOK, "simpleButtonOK");
            this.simpleButtonOK.BackgroundImage = null;
            this.simpleButtonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleDescription = null;
            this.simpleButton1.AccessibleName = null;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.BackgroundImage = null;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Name = "simpleButton1";
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
            this.repositoryItemCheckEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelection,
            this.colProductId,
            this.colProduct,
            this.colInvoiceCODetailPrice,
            this.colInvoiceCODetailQuantity,
            this.colInvoiceCODetailMoney,
            this.colInvoiceCODetailNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colSelection
            // 
            this.colSelection.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colSelection.AppearanceHeader.GradientMode")));
            this.colSelection.AppearanceHeader.Image = null;
            this.colSelection.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelection.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colSelection, "colSelection");
            this.colSelection.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelection.FieldName = "Selected";
            this.colSelection.Name = "colSelection";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AccessibleDescription = null;
            this.repositoryItemCheckEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemCheckEdit1, "repositoryItemCheckEdit1");
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.OptionsColumn.AllowEdit = false;
            this.colProductId.OptionsColumn.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProduct.AppearanceCell.GradientMode")));
            this.colProduct.AppearanceCell.Image = null;
            this.colProduct.AppearanceCell.Options.UseTextOptions = true;
            this.colProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colProduct.AppearanceHeader.GradientMode")));
            this.colProduct.AppearanceHeader.Image = null;
            this.colProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colProduct, "colProduct");
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.OptionsColumn.AllowEdit = false;
            this.colProduct.OptionsColumn.ReadOnly = true;
            // 
            // colInvoiceCODetailPrice
            // 
            this.colInvoiceCODetailPrice.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailPrice.AppearanceCell.GradientMode")));
            this.colInvoiceCODetailPrice.AppearanceCell.Image = null;
            this.colInvoiceCODetailPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colInvoiceCODetailPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colInvoiceCODetailPrice.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailPrice.AppearanceHeader.GradientMode")));
            this.colInvoiceCODetailPrice.AppearanceHeader.Image = null;
            this.colInvoiceCODetailPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceCODetailPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.colInvoiceCODetailPrice, "colInvoiceCODetailPrice");
            this.colInvoiceCODetailPrice.FieldName = "InvoiceCODetailPrice";
            this.colInvoiceCODetailPrice.Name = "colInvoiceCODetailPrice";
            // 
            // colInvoiceCODetailQuantity
            // 
            this.colInvoiceCODetailQuantity.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailQuantity.AppearanceCell.GradientMode")));
            this.colInvoiceCODetailQuantity.AppearanceCell.Image = null;
            this.colInvoiceCODetailQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colInvoiceCODetailQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colInvoiceCODetailQuantity.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailQuantity.AppearanceHeader.GradientMode")));
            this.colInvoiceCODetailQuantity.AppearanceHeader.Image = null;
            this.colInvoiceCODetailQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceCODetailQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.colInvoiceCODetailQuantity, "colInvoiceCODetailQuantity");
            this.colInvoiceCODetailQuantity.FieldName = "InvoiceCODetailQuantity";
            this.colInvoiceCODetailQuantity.Name = "colInvoiceCODetailQuantity";
            // 
            // colInvoiceCODetailMoney
            // 
            this.colInvoiceCODetailMoney.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailMoney.AppearanceCell.GradientMode")));
            this.colInvoiceCODetailMoney.AppearanceCell.Image = null;
            this.colInvoiceCODetailMoney.AppearanceCell.Options.UseTextOptions = true;
            this.colInvoiceCODetailMoney.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colInvoiceCODetailMoney.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailMoney.AppearanceHeader.GradientMode")));
            this.colInvoiceCODetailMoney.AppearanceHeader.Image = null;
            this.colInvoiceCODetailMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceCODetailMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.colInvoiceCODetailMoney, "colInvoiceCODetailMoney");
            this.colInvoiceCODetailMoney.FieldName = "InvoiceCODetailMoney";
            this.colInvoiceCODetailMoney.Name = "colInvoiceCODetailMoney";
            this.colInvoiceCODetailMoney.OptionsColumn.AllowEdit = false;
            this.colInvoiceCODetailMoney.OptionsColumn.ReadOnly = true;
            // 
            // colInvoiceCODetailNote
            // 
            this.colInvoiceCODetailNote.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailNote.AppearanceCell.GradientMode")));
            this.colInvoiceCODetailNote.AppearanceCell.Image = null;
            this.colInvoiceCODetailNote.AppearanceCell.Options.UseTextOptions = true;
            this.colInvoiceCODetailNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colInvoiceCODetailNote.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colInvoiceCODetailNote.AppearanceHeader.GradientMode")));
            this.colInvoiceCODetailNote.AppearanceHeader.Image = null;
            this.colInvoiceCODetailNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceCODetailNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colInvoiceCODetailNote, "colInvoiceCODetailNote");
            this.colInvoiceCODetailNote.FieldName = "InvoiceCODetailNote";
            this.colInvoiceCODetailNote.Name = "colInvoiceCODetailNote";
            // 
            // ChooseDetailsForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton1;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.simpleButton1);
            this.Icon = null;
            this.Name = "ChooseDetailsForm";
            this.Load += new System.EventHandler(this.ChooseDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSelection;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCODetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCODetailQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCODetailMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCODetailNote;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}