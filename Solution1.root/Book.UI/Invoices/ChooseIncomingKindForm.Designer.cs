namespace Book.UI.Invoices
{
    partial class ChooseIncomingKindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseIncomingKindForm));
            this.colIncomingKindName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingKindDescription = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIncomingKindName,
            this.colIncomingKindDescription});
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
            // colIncomingKindName
            // 
            this.colIncomingKindName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colIncomingKindName.AppearanceCell.GradientMode")));
            this.colIncomingKindName.AppearanceCell.Image = null;
            this.colIncomingKindName.AppearanceCell.Options.UseTextOptions = true;
            this.colIncomingKindName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIncomingKindName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colIncomingKindName.AppearanceHeader.GradientMode")));
            this.colIncomingKindName.AppearanceHeader.Image = null;
            this.colIncomingKindName.AppearanceHeader.Options.UseTextOptions = true;
            this.colIncomingKindName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colIncomingKindName, "colIncomingKindName");
            this.colIncomingKindName.FieldName = "IncomingKindName";
            this.colIncomingKindName.Name = "colIncomingKindName";
            this.colIncomingKindName.OptionsColumn.AllowEdit = false;
            this.colIncomingKindName.OptionsColumn.ReadOnly = true;
            // 
            // colIncomingKindDescription
            // 
            this.colIncomingKindDescription.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colIncomingKindDescription.AppearanceCell.GradientMode")));
            this.colIncomingKindDescription.AppearanceCell.Image = null;
            this.colIncomingKindDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colIncomingKindDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIncomingKindDescription.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colIncomingKindDescription.AppearanceHeader.GradientMode")));
            this.colIncomingKindDescription.AppearanceHeader.Image = null;
            this.colIncomingKindDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colIncomingKindDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colIncomingKindDescription, "colIncomingKindDescription");
            this.colIncomingKindDescription.FieldName = "IncomingKindDescription";
            this.colIncomingKindDescription.Name = "colIncomingKindDescription";
            this.colIncomingKindDescription.OptionsColumn.AllowEdit = false;
            this.colIncomingKindDescription.OptionsColumn.ReadOnly = true;
            // 
            // ChooseIncomingKindForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = null;
            this.Name = "ChooseIncomingKindForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingKindName;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingKindDescription;
    }
}