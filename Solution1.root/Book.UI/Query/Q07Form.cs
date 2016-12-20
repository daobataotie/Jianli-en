using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Book.UI.Invoices;

namespace Book.UI.Query
{
    /*----------------------------------------------------------------
// Copyright (C) 2008 - 2010  �����w�Yܛ�����޹�˾
//                     ������� �����ؾ�

// �� �� ��: ���             ���ʱ��:2009-5-29
// �޸�ԭ��
// �� �� ��:                          �޸�ʱ��:
// �޸�ԭ��
// �� �� ��:                          �޸�ʱ��:
//----------------------------------------------------------------*/
    public partial class Q07Form : BaseForm
    {
        protected BL.MiscDataManager miscDataManager = new Book.BL.MiscDataManager();

        public Q07Form(Condition condition)
            : base(condition)
        {
            InitializeComponent();

        }

        #region ��д���෽��
        protected override DevExpress.XtraReports.UI.XtraReport GetReport()
        {
            return new R07(this.bindingSource1.DataSource as System.Data.DataTable);
            //return new Q16();
        }

        protected override void DoQuery()
        {
            ConditionB condition = this.condition as ConditionB;
            //this.bindingSource1.DataSource = this.miscDataManager.SelectDataTable(condition.Date1, condition.Date2, condition.Company, condition.Employee, condition.Depot, global::Helper.InvoiceStatus.Normal, "Q07");
        }
        #endregion

        public static ConditionChooseForm GetConditionChooseForm()
        {
            return new ConditionBChooseForm(global::Helper.CompanyKind.Customer);
        }
    }
}