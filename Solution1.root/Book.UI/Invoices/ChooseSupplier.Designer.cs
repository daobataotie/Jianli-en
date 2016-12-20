namespace Book.UI.Invoices
{
    partial class ChooseSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSupplier));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCompanyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName0 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.colCompanyId,
            this.colCompanyName1,
            this.colCompanyName0,
            this.colCompanyDescription});
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
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
            // colCompanyId
            // 
            this.colCompanyId.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyId.AppearanceCell.GradientMode")));
            this.colCompanyId.AppearanceCell.Image = null;
            this.colCompanyId.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompanyId.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyId.AppearanceHeader.GradientMode")));
            this.colCompanyId.AppearanceHeader.Image = null;
            this.colCompanyId.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colCompanyId, "colCompanyId");
            this.colCompanyId.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colCompanyId.FieldName = "Id";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AccessibleDescription = null;
            this.repositoryItemButtonEdit1.AccessibleName = null;
            resources.ApplyResources(this.repositoryItemButtonEdit1, "repositoryItemButtonEdit1");
            resources.ApplyResources(serializableAppearanceObject2, "serializableAppearanceObject2");
            serializableAppearanceObject2.Image = null;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), resources.GetString("repositoryItemButtonEdit1.Buttons1"), ((int)(resources.GetObject("repositoryItemButtonEdit1.Buttons2"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons3"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons4"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons5"))), ((DevExpress.XtraEditors.ImageLocation)(resources.GetObject("repositoryItemButtonEdit1.Buttons6"))), null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, resources.GetString("repositoryItemButtonEdit1.Buttons7"), null, null, ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons8"))))});
            this.repositoryItemButtonEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemButtonEdit1.Mask.AutoComplete")));
            this.repositoryItemButtonEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemButtonEdit1.Mask.BeepOnError")));
            this.repositoryItemButtonEdit1.Mask.EditMask = resources.GetString("repositoryItemButtonEdit1.Mask.EditMask");
            this.repositoryItemButtonEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemButtonEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemButtonEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemButtonEdit1.Mask.MaskType")));
            this.repositoryItemButtonEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemButtonEdit1.Mask.PlaceHolder")));
            this.repositoryItemButtonEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemButtonEdit1.Mask.SaveLiteral")));
            this.repositoryItemButtonEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemButtonEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemButtonEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemButtonEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // colCompanyName1
            // 
            this.colCompanyName1.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyName1.AppearanceCell.GradientMode")));
            this.colCompanyName1.AppearanceCell.Image = null;
            this.colCompanyName1.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompanyName1.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyName1.AppearanceHeader.GradientMode")));
            this.colCompanyName1.AppearanceHeader.Image = null;
            this.colCompanyName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colCompanyName1, "colCompanyName1");
            this.colCompanyName1.FieldName = "SupplierFullName";
            this.colCompanyName1.Name = "colCompanyName1";
            this.colCompanyName1.OptionsColumn.AllowEdit = false;
            // 
            // colCompanyDescription
            // 
            this.colCompanyDescription.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyDescription.AppearanceCell.GradientMode")));
            this.colCompanyDescription.AppearanceCell.Image = null;
            this.colCompanyDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompanyDescription.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyDescription.AppearanceHeader.GradientMode")));
            this.colCompanyDescription.AppearanceHeader.Image = null;
            this.colCompanyDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colCompanyDescription, "colCompanyDescription");
            this.colCompanyDescription.FieldName = "Remark";
            this.colCompanyDescription.Name = "colCompanyDescription";
            this.colCompanyDescription.OptionsColumn.AllowEdit = false;
            // 
            // colCompanyName0
            // 
            this.colCompanyName0.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyName0.AppearanceCell.GradientMode")));
            this.colCompanyName0.AppearanceCell.Image = null;
            this.colCompanyName0.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName0.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompanyName0.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("colCompanyName0.AppearanceHeader.GradientMode")));
            this.colCompanyName0.AppearanceHeader.Image = null;
            this.colCompanyName0.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            resources.ApplyResources(this.colCompanyName0, "colCompanyName0");
            this.colCompanyName0.FieldName = "SupplierShortName";
            this.colCompanyName0.Name = "colCompanyName0";
            this.colCompanyName0.OptionsColumn.AllowEdit = false;
            // 
            // ChooseSupplier
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = null;
            this.Name = "ChooseSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName0;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;

    }
}