﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book.UI.produceManager.ANSIPCImpactCheck
{
    public partial class ListForm : Book.UI.Settings.BasicData.BaseListForm
    {
        string ForANSIOrJIS = null;
        int tag = 0;
        public ListForm()
        {
            InitializeComponent();
            this.manager = new BL.ANSIPCImpactCheckManager();
        }
        public ListForm(string ForANSIOrJIS)
            : this()
        {
            if (ForANSIOrJIS == "JIS")
            {
                this.Text = "JIS impact test list";
                this.ColANSIImpackID.Caption = "JIS No.";
            }
            this.ForANSIOrJIS = ForANSIOrJIS;
        }

        public ListForm(string InvoiceCusId, int tag)
            : this()
        {
            this.tag = tag;
            this.bindingSource1.DataSource = (this.manager as BL.ANSIPCImpactCheckManager).SelectByDateRage(global::Helper.DateTimeParse.NullDate, global::Helper.DateTimeParse.EndDate, null, null, InvoiceCusId, null);
        }

        protected override void RefreshData()
        {
            if (this.tag == 1)
            {
                this.tag = 0;
                return;
            }
            this.bindingSource1.DataSource = (this.manager as BL.ANSIPCImpactCheckManager).SelectByDateRage(DateTime.Now.AddDays(-15), global::Helper.DateTimeParse.EndDate, null, null, "", this.ForANSIOrJIS);
            
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Query.ConditionPronoteHeaderChooseForm f = new Query.ConditionPronoteHeaderChooseForm();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Query.ConditionPronoteHeader condition = f.Condition as Query.ConditionPronoteHeader;
                this.bindingSource1.DataSource = (this.manager as BL.ANSIPCImpactCheckManager).SelectByDateRage(condition.StartDate, condition.EndDate, condition.Product, condition.Customer, condition.CusXOId, this.ForANSIOrJIS);
                this.barStaticItem1.Caption = string.Format("{0}Items", this.bindingSource1.Count);
                this.gridControl1.RefreshDataSource();
            }
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <returns></returns>
        protected override Book.UI.Settings.BasicData.BaseEditForm GetEditForm()
        {
            return new EditForm();
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        protected override Book.UI.Settings.BasicData.BaseEditForm GetEditForm(object[] args)
        {
            Type type = typeof(EditForm);
            return (EditForm)type.Assembly.CreateInstance(type.FullName, false, System.Reflection.BindingFlags.CreateInstance, null, args, null, null);
        }
    }
}
