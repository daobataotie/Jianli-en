namespace Book.UI.Query
{
    partial class DepotPositionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotPositionListForm));
            this.editDept = new Book.UI.Invoices.NewChooseContorl();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // editDept
            // 
            this.editDept.AccessibleDescription = null;
            this.editDept.AccessibleName = null;
            resources.ApplyResources(this.editDept, "editDept");
            this.editDept.BackgroundImage = null;
            this.editDept.EditValue = null;
            this.editDept.Font = null;
            this.editDept.Name = "editDept";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // DepotPositionListForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editDept);
            this.Controls.Add(this.label1);
            this.Icon = null;
            this.Name = "DepotPositionListForm";
            this.Controls.SetChildIndex(this.simpleButtonOK, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.simpleButtonCancel, 0);
            this.Controls.SetChildIndex(this.editDept, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Book.UI.Invoices.NewChooseContorl editDept;
        private System.Windows.Forms.Label label1;

    }
}