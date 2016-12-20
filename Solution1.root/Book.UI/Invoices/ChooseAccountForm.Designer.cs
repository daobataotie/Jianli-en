namespace Book.UI.Invoices
{
    partial class ChooseAccountForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAccountForm));
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountBalance0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountBalance1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountId,
            this.colAccountName,
            this.colAccountBalance0,
            this.colAccountBalance1,
            this.colAccountDescription});
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colAccountId
            // 
            this.colAccountId.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountId.AppearanceCell.GradientMode")));
            this.colAccountId.AppearanceCell.Image = null;
            this.colAccountId.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAccountId.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountId.AppearanceHeader.GradientMode")));
            this.colAccountId.AppearanceHeader.Image = null;
            this.colAccountId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colAccountId, "colAccountId");
            this.colAccountId.FieldName = "Id";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.OptionsColumn.AllowEdit = false;
            // 
            // colAccountName
            // 
            this.colAccountName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountName.AppearanceCell.GradientMode")));
            this.colAccountName.AppearanceCell.Image = null;
            this.colAccountName.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAccountName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountName.AppearanceHeader.GradientMode")));
            this.colAccountName.AppearanceHeader.Image = null;
            this.colAccountName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colAccountName, "colAccountName");
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsColumn.AllowEdit = false;
            // 
            // colAccountBalance0
            // 
            this.colAccountBalance0.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountBalance0.AppearanceCell.GradientMode")));
            this.colAccountBalance0.AppearanceCell.Image = null;
            this.colAccountBalance0.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountBalance0.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAccountBalance0.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountBalance0.AppearanceHeader.GradientMode")));
            this.colAccountBalance0.AppearanceHeader.Image = null;
            this.colAccountBalance0.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountBalance0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colAccountBalance0, "colAccountBalance0");
            this.colAccountBalance0.FieldName = "AccountBalance0";
            this.colAccountBalance0.Name = "colAccountBalance0";
            this.colAccountBalance0.OptionsColumn.AllowEdit = false;
            // 
            // colAccountBalance1
            // 
            this.colAccountBalance1.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountBalance1.AppearanceCell.GradientMode")));
            this.colAccountBalance1.AppearanceCell.Image = null;
            this.colAccountBalance1.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountBalance1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAccountBalance1.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountBalance1.AppearanceHeader.GradientMode")));
            this.colAccountBalance1.AppearanceHeader.Image = null;
            this.colAccountBalance1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountBalance1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colAccountBalance1, "colAccountBalance1");
            this.colAccountBalance1.FieldName = "AccountBalance1";
            this.colAccountBalance1.Name = "colAccountBalance1";
            this.colAccountBalance1.OptionsColumn.AllowEdit = false;
            // 
            // colAccountDescription
            // 
            this.colAccountDescription.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountDescription.AppearanceCell.GradientMode")));
            this.colAccountDescription.AppearanceCell.Image = null;
            this.colAccountDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAccountDescription.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colAccountDescription.AppearanceHeader.GradientMode")));
            this.colAccountDescription.AppearanceHeader.Image = null;
            this.colAccountDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colAccountDescription, "colAccountDescription");
            this.colAccountDescription.FieldName = "AccountDescription";
            this.colAccountDescription.Name = "colAccountDescription";
            this.colAccountDescription.OptionsColumn.AllowEdit = false;
            // 
            // ChooseAccountForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = null;
            this.Name = "ChooseAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountBalance0;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountBalance1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountDescription;
    }
}