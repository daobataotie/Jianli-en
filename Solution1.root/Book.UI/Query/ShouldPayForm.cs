﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace Book.UI.Query
{
    public partial class ShouldPayForm : Settings.BasicData.BaseEditForm
    {
        Model.ShouldPayAccount shouldPayAccount = null;
        Model.AtBillsIncome AtBillsIncome = new Book.Model.AtBillsIncome();
        Model.AtSummon atSummon = new Book.Model.AtSummon();
        Model.AtSummonDetail atSummondetail;
        BL.ShouldPayAccountManager manager = new Book.BL.ShouldPayAccountManager();
        BL.AtBillsIncomeManager AtBillsIncomeManager = new Book.BL.AtBillsIncomeManager();
        BL.AtSummonManager atSummonManager = new Book.BL.AtSummonManager();
        BL.AtSummonDetailManager atSummonDetailManager = new Book.BL.AtSummonDetailManager();
        private BL.InvoiceCGDetailManager invoicecgmanager = new Book.BL.InvoiceCGDetailManager();
        DataTable dt = new DataTable();
        IList<Model.AtAccountSubject> subjectList;
        IList<Model.AtBillsIncome> atBillsIncomeList = new List<Model.AtBillsIncome>();
        Model.ShouldPayAccountCondition shouldPayAccountCondition;

        int flag = 0;
        public ShouldPayForm()
        {
            InitializeComponent();

            this.bindingSourceSubject.DataSource = this.subjectList = new BL.AtAccountSubjectManager().Select();

            this.nccSupplier.Choose = new Settings.BasicData.Supplier.ChooseSupplier();
            //this.nccYFBank.Choose = new Settings.BasicData.Bank.ChooseBank();
            //this.nccYFSupplier.Choose = new Settings.BasicData.Supplier.ChooseSupplier();
            //this.nccYFSubject.Choose = new Accounting.AtAccountSubject.ChooseAccountSubject();
            this.bindingSourceSupplier.DataSource = new BL.SupplierManager().Select();
            this.nccEmployee.Choose = new Settings.BasicData.Employees.ChooseEmployee();
            this.bindingSourceBank.DataSource = new BL.BankManager().Select();

            this.action = "view";
        }

        public ShouldPayForm(Model.ShouldPayAccount model)
            : this()
        {
            this.shouldPayAccount = model;
            this.flag = 1;
        }

        #region  override
        protected override void AddNew()
        {
            //会计传票
            this.atSummon = new Model.AtSummon();
            this.atSummon.SummonDate = DateTime.Now;
            this.atSummon.Id = this.atSummonManager.GetId();
            this.atSummon.SummonId = Guid.NewGuid().ToString();
            this.atSummon.Details = new List<Model.AtSummonDetail>();
            this.atSummon.CreditTotal = 0;
            this.atSummon.TotalDebits = 0;

            this.shouldPayAccount = new Book.Model.ShouldPayAccount();
            this.shouldPayAccount.ShouldPayAccountId = Guid.NewGuid().ToString();
            this.shouldPayAccount.AtSummon = this.atSummon;
            this.shouldPayAccount.AtSummonId = this.atSummon.SummonId;
            //this.shouldPayAccount.AtBillsIncome = this.AtBillsIncome;
            //this.shouldPayAccount.AtBillsIncomeId = this.AtBillsIncome.BillsId;
            this.shouldPayAccount.Employee = BL.V.ActiveOperator.Employee;
            if (this.shouldPayAccount.Employee != null)
                this.shouldPayAccount.EmployeeId = this.shouldPayAccount.Employee.EmployeeId;

            //应付票据作业
            //this.AtBillsIncome = new Model.AtBillsIncome();
            //this.AtBillsIncome.BillsId = Guid.NewGuid().ToString();
            //this.AtBillsIncome.IncomeCategory = "0";
            //this.AtBillsIncome.BillsOften = "0";
            //this.AtBillsIncome.TheOpenDate = DateTime.Now;
            this.atBillsIncomeList = new List<Model.AtBillsIncome>();
            Model.AtBillsIncome model = new Book.Model.AtBillsIncome();
            model.BillsId = Guid.NewGuid().ToString();
            model.TheOpenDate = DateTime.Now;
            model.ShouldPayAccountId = this.shouldPayAccount.ShouldPayAccountId;
            this.atBillsIncomeList.Add(model);


            this.action = "insert";
        }

        protected override bool HasRows()
        {
            return this.manager.HasRows();
        }

        protected override bool HasRowsNext()
        {
            return this.manager.HasRowsAfter(this.shouldPayAccount);
        }

        protected override bool HasRowsPrev()
        {
            return this.manager.HasRowsBefore(this.shouldPayAccount);
        }

        protected override void MoveFirst()
        {
            this.shouldPayAccount = this.manager.GetFirst();
        }

        protected override void MoveLast()
        {
            if (this.flag == 1)
            {
                this.flag = 0;
                return;
            }
            this.shouldPayAccount = this.manager.GetLast();
        }

        protected override void MoveNext()
        {
            Model.ShouldPayAccount model = this.manager.GetNext(this.shouldPayAccount);
            if (model == null)
                throw new InvalidOperationException(Properties.Resources.ErrorNoMoreRows);
            this.shouldPayAccount = model;
        }

        protected override void MovePrev()
        {
            Model.ShouldPayAccount model = this.manager.GetPrev(this.shouldPayAccount);
            if (model == null)
                throw new InvalidOperationException(Properties.Resources.ErrorNoMoreRows);
            this.shouldPayAccount = model;
        }

        public override void Refresh()
        {
            if (this.shouldPayAccount == null)
                this.AddNew();
            else
            {
                if (this.action == "view")
                    this.shouldPayAccount = this.manager.GetDetail(this.shouldPayAccount.ShouldPayAccountId);
            }
            this.atSummon = this.shouldPayAccount.AtSummon;
            //this.AtBillsIncome = this.shouldPayAccount.AtBillsIncome;
            if (this.atSummon != null)
            {
                if (this.action != "insert")
                    this.atSummon = this.atSummonManager.GetDetails(this.atSummon.SummonId);
                this.txt_AtSummonId.EditValue = this.atSummon.Id;
                this.date_AtSummonDate.EditValue = this.atSummon.SummonDate;
                this.cobAtSummonCategory.EditValue = this.atSummon.SummonCategory;
                this.txt_JieTaotal.EditValue = this.atSummon.TotalDebits;
                this.txt_DaiTotal.EditValue = this.atSummon.CreditTotal;
                this.bindingSourceAtDetail.DataSource = this.atSummon.Details;
            }
            if (this.action != "insert")
                this.atBillsIncomeList = this.AtBillsIncomeManager.SelectByShouldPayAccountId(this.shouldPayAccount.ShouldPayAccountId);
            foreach (var item in this.atBillsIncomeList)
            {
                if (item.BillsOften == "0")
                    item.BillsOften = "Uncollected";
                else if (item.BillsOften == "1")
                    item.BillsOften = "Have collection";
                else if (item.BillsOften == "2")
                    item.BillsOften = "Redeemed";
                else
                    item.BillsOften = null;
            }

            this.bindingSourceAtBill.DataSource = this.atBillsIncomeList;
            //if (this.atBillsIncomeList != null)
            //{
            //this.date_YFKPDate.EditValue = this.AtBillsIncome.TheOpenDate;
            //this.txt_YFCheckId.Text = this.AtBillsIncome.Id;
            //this.date_YFStopDate.EditValue = this.AtBillsIncome.Maturity;
            //this.date_YFChangeDate.EditValue = this.AtBillsIncome.MoveDay;
            //this.date_YFYDDate.EditValue = this.AtBillsIncome.TheJpy;
            //this.cobYFInvoiceState.EditValue = this.AtBillsIncome.BillsOften;
            //this.spe_YFMoney.EditValue = this.AtBillsIncome.NotesMoney;
            //this.nccYFSubject.EditValue = this.AtBillsIncome.Subject;
            //this.nccYFSupplier.EditValue = this.AtBillsIncome.PassingObject == null ? null : new BL.SupplierManager().Get(this.AtBillsIncome.PassingObject);
            //this.nccYFBank.EditValue = this.AtBillsIncome.Bank;
            //this.AtBillsIncome.IncomeCategory = "1";

            //this.txt_YFPMId.Text = this.AtBillsIncome.NotesAccount;
            //}

            this.txt_InvoiceDate.Text = this.shouldPayAccount.InvoiceDate;
            this.txt_FKDate.Text = this.shouldPayAccount.PayDate;
            this.nccSupplier.EditValue = this.shouldPayAccount.Supplier;
            this.txt_PayMethod.EditValue = this.shouldPayAccount.Supplier == null ? null : this.shouldPayAccount.Supplier.PayMethod;
            this.spe_JinE.EditValue = this.shouldPayAccount.JinE == null ? 0 : this.shouldPayAccount.JinE;
            this.spe_ShuiE.EditValue = this.shouldPayAccount.ShuiE == null ? 0 : this.shouldPayAccount.ShuiE;
            this.spe_ZheRang.EditValue = this.shouldPayAccount.ZheRang == null ? 0 : this.shouldPayAccount.ZheRang;
            this.spe_FKZheRang.EditValue = this.shouldPayAccount.PayZheRang == null ? 0 : this.shouldPayAccount.PayZheRang;
            this.spe_Total.EditValue = this.shouldPayAccount.Total == null ? 0 : this.shouldPayAccount.Total;
            this.nccEmployee.EditValue = this.shouldPayAccount.Employee;
            this.bindingSourceDetail.DataSource = this.shouldPayAccount.Detail;

            base.Refresh();

            switch (this.action)
            {
                case "view":
                    this.gridView1.OptionsBehavior.Editable = false;
                    this.gridView2.OptionsBehavior.Editable = false;
                    this.gridView3.OptionsBehavior.Editable = false;
                    break;

                default:
                    this.gridView1.OptionsBehavior.Editable = true;
                    this.gridView2.OptionsBehavior.Editable = true;
                    this.gridView3.OptionsBehavior.Editable = true;
                    break;
            }

            this.txt_PayMethod.Enabled = false;
            this.nccSupplier.Enabled = false;
        }

        protected override void Save()
        {
            if (!this.gridView1.PostEditor() || !this.gridView1.UpdateCurrentRow())
                return;
            if (!this.gridView2.PostEditor() || !this.gridView2.UpdateCurrentRow())
                return;
            if (!this.gridView3.PostEditor() || !this.gridView3.UpdateCurrentRow())
                return;

            //会计传票
            this.atSummon.Id = this.txt_AtSummonId.Text;
            this.atSummon.SummonCategory = this.cobAtSummonCategory.EditValue == null ? null : this.cobAtSummonCategory.EditValue.ToString();
            if (global::Helper.DateTimeParse.DateTimeEquls(this.date_AtSummonDate.DateTime, new DateTime()))
            {
                this.atSummon.SummonDate = global::Helper.DateTimeParse.NullDate;
            }
            else
            {
                this.atSummon.SummonDate = this.date_AtSummonDate.DateTime;
            }
            this.atSummon.TotalDebits = this.txt_JieTaotal.Text == null ? 0 : decimal.Parse(this.txt_JieTaotal.Text);
            this.atSummon.CreditTotal = this.txt_DaiTotal.Text == null ? 0 : decimal.Parse(this.txt_DaiTotal.Text);
            if (string.IsNullOrEmpty(atSummon.Id))
            {
                //MessageBox.Show("便號不能為空", this.Text, MessageBoxButtons.OK);
                //return;
                throw new Helper.MessageValueException("SummonsId can not be empty");
            }
            if (string.IsNullOrEmpty(atSummon.SummonCategory))
            {
                //MessageBox.Show("請選擇傳票類別", this.Text, MessageBoxButtons.OK);
                //return;
                throw new Helper.MessageValueException("Please select summons category");
            }
            //if (this.spe_Total.Value.ToString() != (string.IsNullOrEmpty(this.txt_JieTaotal.Text) ? this.txt_DaiTotal.Text : this.txt_JieTaotal.Text))
            //{
            //    if (MessageBox.Show("總額與借貸數目不等，是否繼續？", this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
            //        return;
            //}
            if (atSummon.Details.Count == 0 || (atSummon.Details[0].Lending == null || atSummon.Details[0].SubjectId == null))
            {
                //MessageBox.Show("請輸入傳票詳細資料！", this.Text, MessageBoxButtons.OK);
                //return;
                throw new Helper.MessageValueException("Please input summons data！");
            }

            //借贷平衡
            if (this.cobAtSummonCategory.SelectedIndex == 2)
            {
                if (this.txt_DaiTotal.EditValue != null && this.txt_JieTaotal.EditValue != null)
                {
                    if (decimal.Parse(this.txt_JieTaotal.Text) != decimal.Parse(this.txt_DaiTotal.Text))
                    {
                        //MessageBox.Show("借貸雙方不平衡,請檢查輸入是否有誤！", this.Text, MessageBoxButtons.OK);
                        //return;
                        throw new Helper.MessageValueException("Both lenders and borrowers unbalanced, check whether the input is wrong！");
                    }
                }
                else
                {
                    //MessageBox.Show("轉帳傳票,借貸金額須相等,借貸數據不完整", this.Text, MessageBoxButtons.OK);
                    //return;
                    throw new Helper.MessageValueException("Transfer Voucher, loan amount to be equal, the lending data is incomplete");
                }
            }

            foreach (var item in atSummon.Details)
            {
                if (item.Lending == "Borrow")
                    item.Id = "A" + atSummon.Details.IndexOf(item);
                else
                    item.Id = "B" + atSummon.Details.IndexOf(item);

            }
            switch (this.action)
            {
                case "insert":
                    if (this.atSummonManager.IsExistsId(this.atSummon.Id))
                        throw new Helper.MessageValueException("Summons Id exists！");
                    break;

                case "update":
                    if (this.atSummonManager.IsExistsIdUpdate(this.atSummon))
                        throw new Helper.MessageValueException("Summons Id exists！");
                    break;
            }

            //应付票据作业
            //this.AtBillsIncome.Id = this.txt_YFCheckId.Text;
            //this.AtBillsIncome.IncomeCategory = "1";
            //if (global::Helper.DateTimeParse.DateTimeEquls(this.date_YFKPDate.DateTime, new DateTime()))
            //{
            //    this.AtBillsIncome.TheOpenDate = null;
            //}
            //else
            //{
            //    this.AtBillsIncome.TheOpenDate = this.date_YFKPDate.DateTime;
            //}
            //if (global::Helper.DateTimeParse.DateTimeEquls(this.date_YFStopDate.DateTime, new DateTime()))
            //{
            //    this.AtBillsIncome.Maturity = null;
            //}
            //else
            //{
            //    this.AtBillsIncome.Maturity = this.date_YFStopDate.DateTime;
            //}
            //if (global::Helper.DateTimeParse.DateTimeEquls(this.date_YFChangeDate.DateTime, new DateTime()))
            //{
            //    this.AtBillsIncome.MoveDay = null;
            //}
            //else
            //{
            //    this.AtBillsIncome.MoveDay = this.date_YFChangeDate.DateTime;
            //}
            //if (global::Helper.DateTimeParse.DateTimeEquls(this.date_YFYDDate.DateTime, new DateTime()))
            //{
            //    this.AtBillsIncome.TheJpy = null;
            //}
            //else
            //{
            //    this.AtBillsIncome.TheJpy = this.date_YFYDDate.DateTime;
            //}
            //this.AtBillsIncome.BillsOften = this.cobYFInvoiceState.SelectedIndex.ToString();
            //this.AtBillsIncome.NotesMoney = this.spe_YFMoney.EditValue == null ? 0 : decimal.Parse(this.spe_YFMoney.EditValue.ToString());

            //if (this.nccYFSubject.EditValue as Model.AtAccountSubject != null)
            //    this.AtBillsIncome.SubjectId = (this.nccYFSubject.EditValue as Model.AtAccountSubject).SubjectId;
            //if (this.nccYFSupplier.EditValue != null)
            //    this.AtBillsIncome.PassingObject = (this.nccYFSupplier.EditValue as Model.Supplier).SupplierId;

            //if (this.nccYFBank.EditValue != null)
            //this.AtBillsIncome.BankId = (this.nccYFBank.EditValue as Model.Bank).BankId;
            //   this.AtBillsIncome.CollectionAccount = this.lookUpEdit1.EditValue == null ? null : this.lookUpEdit1.EditValue.ToString();
            //this.AtBillsIncome.Mark = this.memoEditNote.Text;
            //this.AtBillsIncome.NotesAccount = this.txt_YFPMId.Text;
            //this.AtBillsIncome.ChuanPiaoId = this.txt_AtSummonId.Text;
            foreach (var item in this.atBillsIncomeList)
            {
                item.IncomeCategory = "1";
                if (item.BillsOften == "Uncollected")
                    item.BillsOften = "0";
                else if (item.BillsOften == "Have collection")
                    item.BillsOften = "1";
                else if (item.BillsOften == "Redeemed")
                    item.BillsOften = "2";
                else
                    item.BillsOften = "-1";
                if (string.IsNullOrEmpty(item.Id))
                    throw new Helper.MessageValueException("Please input check Id");
            }

            //应付账款明细表
            this.shouldPayAccount.InvoiceDate = this.txt_InvoiceDate.Text;
            this.shouldPayAccount.PayDate = this.txt_FKDate.Text;
            this.shouldPayAccount.SupplierId = (this.nccSupplier.EditValue as Model.Supplier) == null ? null : (this.nccSupplier.EditValue as Model.Supplier).SupplierId;
            this.shouldPayAccount.JinE = this.spe_JinE.Value;
            this.shouldPayAccount.ShuiE = this.spe_ShuiE.Value;
            this.shouldPayAccount.ZheRang = this.spe_ZheRang.Value;
            this.shouldPayAccount.PayZheRang = this.spe_FKZheRang.Value;
            this.shouldPayAccount.Total = this.spe_Total.Value;
            this.shouldPayAccount.EmployeeId = (this.nccEmployee.EditValue as Model.Employee) == null ? null : (this.nccEmployee.EditValue as Model.Employee).EmployeeId;
            
            if (this.shouldPayAccountCondition == null)
                throw new Helper.MessageValueException("Please check schedule of accounts payable！");

            switch (this.action)
            {
                case "insert":
                    this.atSummonManager.Insert(this.atSummon);
                    new BL.ShouldPayAccountConditionManager().Insert(this.shouldPayAccount.ShouldPayAccountCondition);
                    this.manager.Insert(this.shouldPayAccount);
                    this.AtBillsIncomeManager.Insert(this.atBillsIncomeList);
                    break;
                case "update":
                    this.atSummonManager.Update(this.atSummon);
                    new BL.ShouldPayAccountConditionManager().Update(this.shouldPayAccount.ShouldPayAccountCondition);
                    this.AtBillsIncomeManager.Update(this.atBillsIncomeList, this.shouldPayAccount.ShouldPayAccountId);
                    this.manager.Update(this.shouldPayAccount);
                    break;
            }
        }

        protected override void Delete()
        {
            if (this.shouldPayAccount == null)
                return;
            if (MessageBox.Show(Properties.Resources.ConfirmToDelete, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Model.ShouldPayAccount model = this.manager.GetNext(this.shouldPayAccount);
                this.manager.Delete(this.shouldPayAccount.ShouldPayAccountId);
                if (model == null)
                    this.shouldPayAccount = this.manager.GetLast();
                else
                    this.shouldPayAccount = model;
            }
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReport()
        {
            Model.ShouldPayAccountCondition model = this.shouldPayAccount.ShouldPayAccountCondition;
            if (model != null)
                dt = this.invoicecgmanager.SelectByConditionCOBiao(model.StartInvoiceDate, model.EndInvoiceDate, model.StartJHDate == null ? global::Helper.DateTimeParse.NullDate : (DateTime)model.StartJHDate, model.EndJHDate == null ? global::Helper.DateTimeParse.EndDate : (DateTime)model.EndJHDate, model.StartFKDate, model.EndFKDate, model.SupplierStart, model.SupplierEnd, model.ProductStart, model.ProductEnd, model.COStartId, model.COEndId, model.CusXOId, model.EmpStart, model.EmpEnd);
            else
                dt = null;
            return new ROInvoiceCGlistBiao(this.shouldPayAccount, dt, this.txt_AtSummonId.Text);
        }
        #endregion

        private void btnAtSummonAdd_Click(object sender, EventArgs e)
        {
            Model.AtSummonDetail mdetail = new Book.Model.AtSummonDetail();
            mdetail.SummonDetailId = Guid.NewGuid().ToString();
            mdetail.Subject = new Book.Model.AtAccountSubject();
            mdetail.SummonId = this.atSummon.SummonId;
            mdetail.InsertTime = DateTime.Now;
            mdetail.UpdateTime = DateTime.Now;
            mdetail.AMoney = 0;

            switch (this.cobAtSummonCategory.SelectedIndex)
            {
                case 0:
                    mdetail.Lending = "Loan";
                    break;
                case 1:
                    mdetail.Lending = "Borrow";
                    break;
                case 3:
                    mdetail.Lending = "";
                    break;
            }

            this.atSummon.Details.Add(mdetail);
            this.bindingSourceAtDetail.Position = this.bindingSourceAtDetail.IndexOf(mdetail);
            this.gridControl1.RefreshDataSource();
            this.CountJieDaiTotal(this.atSummon.Details);
        }

        private void btnAtSummonRemove_Click(object sender, EventArgs e)
        {
            if (this.bindingSourceAtDetail.Current != null)
            {
                this.atSummon.Details.Remove(this.bindingSourceAtDetail.Current as Book.Model.AtSummonDetail);

                this.gridControl1.RefreshDataSource();

                this.bindingSourceAtDetail.Position = this.atSummon.Details.Count - 1;
                this.CountJieDaiTotal(this.atSummon.Details);
            }
        }

        private void cobAtSummonCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IList<Model.AtSummonDetail> _details = this.bindingSourceAtDetail.DataSource as IList<Model.AtSummonDetail>;

            //if (_details != null && _details.Count != 0)
            //{
            //    switch (this.cobAtSummonCategory.SelectedIndex)
            //    {
            //        case 0:
            //            this.colJieorDai.OptionsColumn.AllowEdit = false;
            //            foreach (Model.AtSummonDetail d in _details)
            //            {
            //                d.Lending = "貸";
            //            }
            //            break;
            //        case 1:
            //            this.colJieorDai.OptionsColumn.AllowEdit = false;
            //            foreach (Model.AtSummonDetail d in _details)
            //            {
            //                d.Lending = "借";
            //            }
            //            break;
            //        case 2:
            //            this.colJieorDai.OptionsColumn.AllowEdit = true;
            //            break;
            //    }

            //    this.gridControl1.RefreshDataSource();
            //} this.CountJieDaiTotal(_details);
        }

        private void dateEditAtSummonDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.action == "insert")
                this.txt_AtSummonId.Text = this.atSummonManager.GetId(this.date_AtSummonDate.DateTime);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == this.colJinE || e.Column == this.colJieorDai)
            {
                IList<Model.AtSummonDetail> _detailList = this.bindingSourceAtDetail.DataSource as IList<Model.AtSummonDetail>;
                this.CountJieDaiTotal(_detailList);
            }
        }

        private void CountJieDaiTotal(IList<Model.AtSummonDetail> list)
        {
            this.txt_JieTaotal.EditValue = list.Where(d => d.Lending == "Borrow").ToList().Sum(d => d.AMoney);
            this.txt_DaiTotal.EditValue = list.Where(d => d.Lending == "Loan").ToList().Sum(d => d.AMoney);
        }

        //查询应付账款明细表
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Book.UI.Query.ConditionCOChooseForm f = new ConditionCOChooseForm();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                ConditionCO condition = f.Condition as ConditionCO;
                dt = this.invoicecgmanager.SelectByConditionCOBiao(condition.StartInvoiceDate, condition.EndInvoiceDate, condition.StartJHDate, condition.EndJHDate, condition.StartFKDate, condition.EndFKDate, condition.SupplierStart, condition.SupplierEnd, condition.ProductStart, condition.ProductEnd, condition.COStartId, condition.COEndId, condition.CusXOId, condition.EmpStart, condition.EmpEnd);

                //查询条件
                this.shouldPayAccountCondition = this.shouldPayAccount.ShouldPayAccountCondition;
                if (this.shouldPayAccountCondition == null)
                {
                    this.shouldPayAccountCondition = new Book.Model.ShouldPayAccountCondition();
                    this.shouldPayAccountCondition.ShouldPayAccountConditionId = Guid.NewGuid().ToString();
                }
                this.shouldPayAccountCondition.StartInvoiceDate = condition.StartInvoiceDate;
                this.shouldPayAccountCondition.EndInvoiceDate = condition.EndInvoiceDate;
                this.shouldPayAccountCondition.StartJHDate = condition.StartJHDate;
                this.shouldPayAccountCondition.EndJHDate = condition.EndJHDate;
                this.shouldPayAccountCondition.StartFKDate = condition.StartFKDate;
                this.shouldPayAccountCondition.EndFKDate = condition.EndFKDate;
                this.shouldPayAccountCondition.SupplierStart = condition.SupplierStart;
                this.shouldPayAccountCondition.SupplierStartId = condition.SupplierStart == null ? null : condition.SupplierStart.SupplierId;
                this.shouldPayAccountCondition.SupplierEnd = condition.SupplierEnd;
                this.shouldPayAccountCondition.SupplierEndId = condition.SupplierEnd == null ? null : condition.SupplierEnd.SupplierId;
                this.shouldPayAccountCondition.ProductStart = condition.ProductStart;
                this.shouldPayAccountCondition.ProductStartId = condition.ProductStart == null ? null : condition.ProductStart.ProductId;
                this.shouldPayAccountCondition.ProductEnd = condition.ProductEnd;
                this.shouldPayAccountCondition.ProductEndId = condition.ProductEnd == null ? null : condition.ProductEnd.ProductId;
                this.shouldPayAccountCondition.COStartId = condition.COStartId;
                this.shouldPayAccountCondition.COEndId = condition.COEndId;
                this.shouldPayAccountCondition.CusXOId = condition.CusXOId;
                this.shouldPayAccountCondition.EmpStart = condition.EmpStart;
                this.shouldPayAccountCondition.EmpStartId = condition.EmpStart == null ? null : condition.EmpStart.EmployeeId;
                this.shouldPayAccountCondition.EmpEnd = condition.EmpEnd;
                this.shouldPayAccountCondition.EmpEndId = condition.EmpEnd == null ? null : condition.EmpEnd.EmployeeId;

                this.shouldPayAccount.ShouldPayAccountCondition = this.shouldPayAccountCondition;
                this.shouldPayAccount.ShouldPayAccountConditionId = this.shouldPayAccountCondition == null ? null : this.shouldPayAccountCondition.ShouldPayAccountConditionId;

                if (condition.SupplierStart != null && condition.SupplierEnd != null)
                    if (condition.SupplierStart.SupplierId != condition.SupplierEnd.SupplierId)
                    {
                        this.nccSupplier.EditValue = null;
                        this.txt_PayMethod.EditValue = null;
                    }
                    else
                    {
                        this.nccSupplier.EditValue = condition.SupplierStart == null ? null : condition.SupplierStart;
                        this.txt_PayMethod.EditValue = condition.SupplierStart == null ? null : condition.SupplierStart.PayMethod;
                    }
                this.txt_InvoiceDate.EditValue = (condition.StartInvoiceDate == null ? null : condition.StartInvoiceDate.Value.ToString("yyyy-MM-dd")) + "  -  " + (condition.EndInvoiceDate == null ? null : condition.EndInvoiceDate.Value.ToString("yyyy-MM-dd"));
                this.txt_FKDate.EditValue = (condition.StartFKDate == null ? null : condition.StartFKDate.Value.ToString("yyyy-MM-dd")) + "  -  " + (condition.EndFKDate == null ? null : condition.EndFKDate.Value.ToString("yyyy-MM-dd"));
                if (dt.Rows.Count > 0)
                {
                    this.spe_JinE.EditValue = Math.Round(Convert.ToDouble(dt.Compute("Sum(JinE)", "1=1")), 0);
                    this.spe_ShuiE.EditValue = Math.Round(Convert.ToDouble(dt.Compute("Sum(ShuiE)", "")), 0);
                    this.spe_Total.EditValue = Math.Round(Convert.ToDouble(this.spe_JinE.Value) + Convert.ToDouble(this.spe_ShuiE.Value), 0);
                }
                //添加、删除会计传票详细
                int count = this.atSummon.Details.Count;
                for (int i = 0; i < count; i++)
                {
                    if (this.atSummon.Details.Any(d => d.Lending == "Borrow"))
                        this.atSummon.Details.Remove(this.atSummon.Details.First(d => d.Lending == "Borrow"));
                }

                atSummondetail = new Book.Model.AtSummonDetail();
                atSummondetail.SummonDetailId = Guid.NewGuid().ToString();
                atSummondetail.Lending = "Borrow";
                atSummondetail.SubjectId = this.subjectList.First(d => d.Id == "2144001").SubjectId;
                atSummondetail.AMoney = Convert.ToDecimal(this.spe_JinE.EditValue) - Convert.ToDecimal(this.spe_ZheRang.EditValue);
                this.atSummon.Details.Add(atSummondetail);
                atSummondetail = new Book.Model.AtSummonDetail();
                atSummondetail.SummonDetailId = Guid.NewGuid().ToString();
                atSummondetail.Lending = "Borrow";
                atSummondetail.SubjectId = this.subjectList.First(d => d.Id == "6213000").SubjectId;
                atSummondetail.AMoney = Convert.ToDecimal(this.spe_ShuiE.EditValue);
                this.atSummon.Details.Add(atSummondetail);
                this.CountJieDaiTotal(this.atSummon.Details);
                this.gridControl1.RefreshDataSource();

                this.spe_FKZheRang.EditValue = 0;
                this.spe_ZheRang.EditValue = 0;

                //应付票据作业
                if (this.atBillsIncomeList.Count > 0)
                {
                    Model.AtBillsIncome atbill = this.atBillsIncomeList[0];

                    atbill.NotesMoney = this.spe_Total.Value;
                    atbill.PassingObject = this.shouldPayAccountCondition.SupplierStartId;
                }
                else
                {
                    Model.AtBillsIncome atbill = new Book.Model.AtBillsIncome();
                    atbill.BillsId = Guid.NewGuid().ToString();
                    atbill.TheOpenDate = DateTime.Now;
                    atbill.ShouldPayAccountId = this.shouldPayAccount.ShouldPayAccountId;
                    atbill.NotesMoney = this.spe_Total.Value;
                    atbill.PassingObject = this.shouldPayAccountCondition.SupplierStartId;
                    this.atBillsIncomeList.Add(atbill);

                }
                this.gridControl3.RefreshDataSource();
            }
        }

        private void spe_JinE_EditValueChanged(object sender, EventArgs e)
        {
            if (this.action == "view")
                return;
            if (this.atSummon.Details.Any(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId))
                this.atSummon.Details.First(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId).AMoney = Convert.ToDecimal(this.spe_Total.EditValue);
            this.CountJieDaiTotal(this.atSummon.Details);
            this.gridControl1.RefreshDataSource();
        }

        private void spe_ZheRang_EditValueChanged(object sender, EventArgs e)
        {
            if (this.action == "view")
                return;
            this.spe_Total.EditValue = Convert.ToDouble(this.spe_JinE.EditValue) + Convert.ToDouble(this.spe_ShuiE.EditValue) - Convert.ToDouble(this.spe_ZheRang.EditValue) - Convert.ToDouble(this.spe_FKZheRang.EditValue);

            if (this.atSummon.Details.Any(d => d.SubjectId == this.subjectList.First(f => f.Id == "2144001").SubjectId))
                this.atSummon.Details.First(d => d.SubjectId == this.subjectList.First(f => f.Id == "2144001").SubjectId).AMoney = Convert.ToDecimal(this.spe_JinE.EditValue) - Convert.ToDecimal(this.spe_ZheRang.EditValue);
            if (this.atSummon.Details.Any(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId))
                this.atSummon.Details.First(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId).AMoney = Convert.ToDecimal(this.spe_Total.EditValue);
            this.CountJieDaiTotal(this.atSummon.Details);
            this.gridControl1.RefreshDataSource();
        }

        private void spe_FKZheRang_EditValueChanged(object sender, EventArgs e)
        {
            if (this.action == "view")
                return;
            this.spe_Total.EditValue = Convert.ToDouble(this.spe_JinE.EditValue) + Convert.ToDouble(this.spe_ShuiE.EditValue) - Convert.ToDouble(this.spe_ZheRang.EditValue) - Convert.ToDouble(this.spe_FKZheRang.EditValue);

            if (this.atSummon.Details.Any(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId))
                this.atSummon.Details.First(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId).AMoney = Convert.ToDecimal(this.spe_Total.EditValue);
            if (this.atSummon.Details.Any(d => d.SubjectId == this.subjectList.First(f => f.Id == "7101000").SubjectId))
                this.atSummon.Details.First(d => d.SubjectId == this.subjectList.First(f => f.Id == "7101000").SubjectId).AMoney = Convert.ToDecimal(this.spe_FKZheRang.EditValue);
            this.CountJieDaiTotal(this.atSummon.Details);
            this.gridControl1.RefreshDataSource();
        }

        private void spe_ShuiE_EditValueChanged(object sender, EventArgs e)
        {
            if (this.action == "view")
                return;
            this.spe_Total.EditValue = Convert.ToDouble(this.spe_JinE.EditValue) + Convert.ToDouble(this.spe_ShuiE.EditValue) - Convert.ToDouble(this.spe_ZheRang.EditValue) - Convert.ToDouble(this.spe_FKZheRang.EditValue);

            if (this.atSummon.Details.Any(d => d.SubjectId == this.subjectList.First(f => f.Id == "6213000").SubjectId))
                this.atSummon.Details.First(d => d.SubjectId == this.subjectList.First(f => f.Id == "6213000").SubjectId).AMoney = Convert.ToDecimal(this.spe_ShuiE.EditValue);

            if (this.atSummon.Details.Any(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId))
                this.atSummon.Details.First(d => d.Lending == "Loan" && d.SubjectId != this.subjectList.First(f => f.Id == "7101000").SubjectId).AMoney = Convert.ToDecimal(this.spe_Total.EditValue);
            this.CountJieDaiTotal(this.atSummon.Details);
            this.gridControl1.RefreshDataSource();
        }

        private void nccYFBank_EditValueChanged(object sender, EventArgs e)
        {
            //if (this.nccYFBank.EditValue as Model.Bank != null && this.action == "insert")
            //{
            //    this.txt_YFPMId.Text = (this.nccYFBank.EditValue as Model.Bank).Id;

            //    //添加、删除会计传票详细
            //    int count = this.atSummon.Details.Count;
            //    for (int i = 0; i < count; i++)
            //    {
            //        if (this.atSummon.Details.Any(d => d.Lending == "貸"))
            //            this.atSummon.Details.Remove(this.atSummon.Details.First(d => d.Lending == "貸"));
            //    }

            //    this.atSummondetail = new Book.Model.AtSummonDetail();
            //    atSummondetail.SummonDetailId = Guid.NewGuid().ToString();
            //    atSummondetail.Lending = "貸";
            //    if (this.subjectList.Any(d => d.SubjectName.Contains((this.nccYFBank.EditValue as Model.Bank).BankName.Substring(0, (this.nccYFBank.EditValue as Model.Bank).BankName.IndexOf("銀行")))))
            //        atSummondetail.SubjectId = this.subjectList.First(d => d.SubjectName.Contains((this.nccYFBank.EditValue as Model.Bank).BankName.Substring(0, (this.nccYFBank.EditValue as Model.Bank).BankName.IndexOf("銀行")))).SubjectId;
            //    atSummondetail.AMoney = Convert.ToDecimal(this.spe_Total.EditValue);
            //    this.atSummon.Details.Add(atSummondetail);

            //    this.atSummondetail = new Book.Model.AtSummonDetail();
            //    atSummondetail.SummonDetailId = Guid.NewGuid().ToString();
            //    atSummondetail.Lending = "貸";
            //    atSummondetail.SubjectId = this.subjectList.First(d => d.Id == "7101000").SubjectId;
            //    atSummondetail.AMoney = Convert.ToDecimal(this.spe_FKZheRang.EditValue);
            //    this.atSummon.Details.Add(atSummondetail);
            //    this.CountJieDaiTotal(this.atSummon.Details);
            //    this.gridControl1.RefreshDataSource();
            //}
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.shouldPayAccount.Detail == null)
                this.shouldPayAccount.Detail = new List<Model.ShouldPayAccountDetail>();
            Model.ShouldPayAccountDetail model = new Book.Model.ShouldPayAccountDetail();
            model.ShouldPayAccountDetailId = Guid.NewGuid().ToString();
            model.ShouldPayAccountId = this.shouldPayAccount.ShouldPayAccountId;
            this.shouldPayAccount.Detail.Add(model);
            this.bindingSourceDetail.Position = this.bindingSourceDetail.IndexOf(model);
            this.gridControl2.RefreshDataSource();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.bindingSourceDetail.Current != null)
            {
                this.shouldPayAccount.Detail.Remove(this.bindingSourceDetail.Current as Model.ShouldPayAccountDetail);
                this.gridControl2.RefreshDataSource();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShouldPayFormList f = new ShouldPayFormList();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                this.shouldPayAccount = f.SelectItem as Model.ShouldPayAccount;
                this.Refresh();
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "gridColumn5")
            {
                this.gridView2.SetRowCellValue(e.RowHandle, this.gridColumn6, Convert.ToDouble(this.gridView2.GetRowCellValue(e.RowHandle, this.gridColumn5)) * 0.05);
                this.gridView2.SetRowCellValue(e.RowHandle, this.gridColumn7, Convert.ToDouble(this.gridView2.GetRowCellValue(e.RowHandle, this.gridColumn5)) * 1.05);
            }
            if (e.Column.Name == "gridColumn6")
            {
                this.gridView2.SetRowCellValue(e.RowHandle, this.gridColumn7, Convert.ToDouble(this.gridView2.GetRowCellValue(e.RowHandle, this.gridColumn5)) + Convert.ToDouble(this.gridView2.GetRowCellValue(e.RowHandle, this.gridColumn6)));
            }
            this.gridControl2.RefreshDataSource();
        }

        private void btn_YFAdd_Click(object sender, EventArgs e)
        {
            if (this.atBillsIncomeList == null)
                this.atBillsIncomeList = new List<Model.AtBillsIncome>();
            Model.AtBillsIncome model = new Book.Model.AtBillsIncome();
            model.BillsId = Guid.NewGuid().ToString();
            model.TheOpenDate = DateTime.Now;
            model.ShouldPayAccountId = this.shouldPayAccount.ShouldPayAccountId;

            this.atBillsIncomeList.Add(model);
            this.bindingSourceAtBill.Position = this.bindingSourceAtBill.IndexOf(model);
            this.gridControl3.RefreshDataSource();
        }

        private void btn_YFRemove_Click(object sender, EventArgs e)
        {
            if (this.bindingSourceAtBill.Current != null)
            {
                this.atBillsIncomeList.Remove(this.bindingSourceAtBill.Current as Model.AtBillsIncome);
                this.gridControl3.RefreshDataSource();
            }
        }
    }

}
