﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace Book.UI.Settings.BasicData.Customs
{
    public partial class CustomerProductPrice : BaseEditForm
    {
        Model.CustomerProductPrice _CustomerProductPrice;
        IList<Model.CustomerProductPrice> _CustomerProductPriceList = new List<Model.CustomerProductPrice>();
        BL.CustomerProductPriceManager _manage = new Book.BL.CustomerProductPriceManager();
        private IList<PriceRange> _priceRangeList = new List<PriceRange>();
        Model.Customer customer;

        public CustomerProductPrice()
        {
            InitializeComponent();

            string errorMessage = "The price range is incorrect, please check to save.\r1.The price range whether continuous.\r2.Price can not be zero.\r3.<Quantity upper limit>shall not be less than<Quantity lower limit>.\r4.The first section of the price range,<Quantity lower limit>must be 1";

            this.invalidValueExceptions.Add("PriceRange.Error", new AA(errorMessage, this.gridControl3));
            //this.requireValueExceptions.Add(Model.CustomerProductPrice.PRO_ProductId, new AA("商品不能為空!", this.btn_CheckProduct));

            this.bindingSourceCustomer.DataSource = (new BL.CustomerManager()).Select();
            if (this.bindingSourceCustomer.DataSource != null && this.bindingSourceCustomer.Count > 0)
            {
                this._CustomerProductPriceList = this._manage.SelectByCustomerId((this.bindingSourceCustomer.Current as Model.Customer).CustomerId);
                this.customer = this.bindingSourceCustomer[0] as Model.Customer;
            }
            if (this._CustomerProductPriceList != null && this._CustomerProductPriceList.Count > 0)
                this._CustomerProductPrice = this._CustomerProductPriceList[0];
            this.bindingSourceCustomerProduct.DataSource = this._CustomerProductPriceList;
            this.bindingSourcePriceRang.DataSource = this._priceRangeList;
            this.nccBuildEmployee.Choose = new Employees.ChooseEmployee();
            this.nccChangeEmployee.Choose = new Employees.ChooseEmployee();
            this.action = "view";
        }

        protected override void AddNew()
        {
            this._CustomerProductPrice = new Book.Model.CustomerProductPrice();
            this._CustomerProductPrice.CustomerProductPriceId = Guid.NewGuid().ToString();
            this._CustomerProductPrice.Customer = this.bindingSourceCustomer.Current as Model.Customer;
            if (this._CustomerProductPrice.Customer != null)
                this._CustomerProductPrice.CustomerId = this._CustomerProductPrice.Customer.CustomerId;
            this._CustomerProductPrice.CustomerProductPriceRage = "1/999999999999/0/0";
            this.action = "insert";
        }

        protected override void Delete()
        {
            if (MessageBox.Show(Properties.Resources.ConfirmToDelete, this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            if (this._CustomerProductPrice != null)
            {
                this._manage.Delete(this._CustomerProductPrice.CustomerProductPriceId);
                this._CustomerProductPriceList.Remove(this._CustomerProductPrice);
                this.gridControl2.RefreshDataSource();
            }
            this.gridView1_RowCellClick(null, null);
        }

        public override void Refresh()
        {
            if (this._CustomerProductPrice == null)
                this.AddNew();
            else
            {
                if (this.action == "view")
                    this._CustomerProductPrice = this._manage.Get(this._CustomerProductPrice.CustomerProductPriceId);
                if (this._CustomerProductPrice == null)
                {
                    this.bindingSourceCustomerProduct.DataSource = this._manage.SelectByCustomerId(customer.CustomerId);
                    if (this.bindingSourceCustomerProduct.Count == 0)
                        this.AddNew();
                    else
                    {
                        this._CustomerProductPrice = this.bindingSourceCustomerProduct[0] as Model.CustomerProductPrice;
                        this.bindingSourceCustomerProduct.Position = 0;
                    }
                }

            }
            this.btn_CheckProduct.EditValue = this._CustomerProductPrice.Product;
            this.memoEditNote.Text = this._CustomerProductPrice.Note;
            this.nccBuildEmployee.EditValue = this._CustomerProductPrice.BuildEmployee;
            this.nccChangeEmployee.EditValue = this._CustomerProductPrice.ChangeEmployee;
            AnalyzePriceRange(this._CustomerProductPrice.CustomerProductPriceRage);
            this.gridControl3.RefreshDataSource();

            base.Refresh();
            this.btn_CheckProduct2.Enabled = true;
            if (this.action == "view")
                this.gridView3.OptionsBehavior.Editable = false;
            else
                this.gridView3.OptionsBehavior.Editable = true;
        }

        protected override bool HasRows()
        {
            return true;
        }

        protected override void Undo()
        {
            this._CustomerProductPriceList = this._manage.SelectByCustomerId((this.bindingSourceCustomer.Current as Model.Customer).CustomerId);
            AnalyzePriceRange((this.bindingSourceCustomerProduct.Current as Model.CustomerProductPrice).CustomerProductPriceRage);
            this.gridControl2.RefreshDataSource();
            this.gridControl3.RefreshDataSource();
            base.Undo();
        }

        protected override void Save()
        {
            if (!this.gridView3.PostEditor() || !this.gridView3.UpdateCurrentRow())
                return;
            this.VerificationPriceRange();
            this._CustomerProductPrice.CustomerProductPriceRage = this.AssemblyPriceRange(this.bindingSourcePriceRang.DataSource as IList<PriceRange>);
            this._CustomerProductPrice.Note = this.memoEditNote.Text;
            this._CustomerProductPrice.BuildEmployeeId = this.nccBuildEmployee.EditValue == null ? BL.V.ActiveOperator.EmployeeId : (this.nccBuildEmployee.EditValue as Model.Employee).EmployeeId;
            this._CustomerProductPrice.ChangeEmployeeId = this.nccChangeEmployee.EditValue == null ? BL.V.ActiveOperator.EmployeeId : (this.nccChangeEmployee.EditValue as Model.Employee).EmployeeId;
            switch (this.action)
            {
                case "insert":
                    this._manage.Insert(this._CustomerProductPrice);
                    break;
                case "update":
                    this._manage.Update(this._CustomerProductPrice);
                    break;
            }
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReport()
        {
            if (this.customer == null)
                return new ROCustomerProductPrice();
            else
                return new ROCustomerProductPrice(this.customer.CustomerFullName, this.bindingSourceCustomerProduct.DataSource as List<Model.CustomerProductPrice>);
        }

        //查询客户对应商品
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            customer = this.bindingSourceCustomer.Current as Model.Customer;
            this.bindingSourceCustomerProduct.DataSource = this._CustomerProductPriceList = this._manage.SelectByCustomerId(customer.CustomerId);
            if (this.bindingSourceCustomerProduct.Count > 0)
            {
                this._CustomerProductPrice = this.bindingSourceCustomerProduct.Current as Model.CustomerProductPrice;
                this.action = "view";
            }
            else
                this.AddNew();
            this.gridControl2.RefreshDataSource();
            this.Refresh();
        }

        //解析价格区间
        //DEMO: 0/0/0,0/0/0,0/0/0,0/0/0,0/0/0,0/0/0,0/999999999999/0
        //Means: {起始数量/终止数量/价格}
        private void AnalyzePriceRange(string priceR)
        {
            this._priceRangeList.Clear();
            if (string.IsNullOrEmpty(priceR))
                priceR = "1/999999999999/0/0";
            string[] inPriceR;
            if (priceR.Contains(","))
                inPriceR = priceR.Split(',');
            else
                inPriceR = new string[] { priceR };
            PriceRange pr = null;
            foreach (string s in inPriceR)
            {
                string[] prs = s.Split('/');
                pr = new PriceRange();
                pr.startRange = Convert.ToDouble(prs[0]);
                pr.endRange = Convert.ToDouble(prs[1]);
                pr.RangePrice = Convert.ToDouble(prs[2]);
                pr.GiveQuantity = Convert.ToDouble(prs[3]);
                this._priceRangeList.Add(pr);
            }
        }

        //增删改.选择商品
        private void btn_CheckProduct_Click(object sender, EventArgs e)
        {
            if (this.action == "insert")
            {
                UI.Invoices.ChooseProductForm f = new Book.UI.Invoices.ChooseProductForm();
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    this._CustomerProductPrice.Product = f.SelectedItem as Model.Product;
                    if (this._CustomerProductPrice.Product != null)
                    {
                        this._CustomerProductPrice.ProductId = this._CustomerProductPrice.Product.ProductId;
                        this._CustomerProductPrice.ProductIDNo = this._CustomerProductPrice.Product.Id;
                        this._CustomerProductPrice.ProductName = this._CustomerProductPrice.Product.ProductName;
                        this._CustomerProductPrice.ProductDesc = this._CustomerProductPrice.Product.ProductDescription;
                        this._CustomerProductPrice.ProductVersion = this._CustomerProductPrice.Product.ProductVersion;
                        this._CustomerProductPrice.CustomerProductId = this._CustomerProductPrice.Product.CustomerProductName;
                        this._CustomerProductPrice.CustomerProductsId = (new BL.CustomerProductsManager()).SelectPrimaryIdByProceName(this._CustomerProductPrice.ProductId);
                    }
                    this._CustomerProductPrice.Customer = this.bindingSourceCustomer.Current as Model.Customer;
                    if (this._CustomerProductPrice.Customer != null)
                        this._CustomerProductPrice.CustomerId = this._CustomerProductPrice.Customer.CustomerId;

                    //foreach (Model.CustomerProductPrice cpp in this._CustomerProductPriceList)
                    //{
                    //    if (cpp.CustomerId == this._CustomerProductPrice.CustomerId && cpp.ProductId == this._CustomerProductPrice.ProductId)
                    //    {
                    //    }
                    //}
                    if (this._CustomerProductPriceList.Where(c => c.CustomerId == this._CustomerProductPrice.CustomerId && c.ProductId == this._CustomerProductPrice.ProductId).ToList<Model.CustomerProductPrice>().Count > 0)
                    {
                        MessageBox.Show("Duplicate product input", "Prompt");
                        return;
                    }
                    else if (this.action == "insert")
                    {
                        this._CustomerProductPriceList.Add(this._CustomerProductPrice);
                        this.bindingSourceCustomerProduct.Position = this.bindingSourceCustomerProduct.IndexOf(this._CustomerProductPrice);
                        this.gridControl2.RefreshDataSource();
                        AnalyzePriceRange(this._CustomerProductPrice.CustomerProductPriceRage);
                        this.gridControl3.RefreshDataSource();
                    }
                    this.btn_CheckProduct.EditValue = f.SelectedItem as Model.Product;
                }
            }
        }

        //查询选择商品
        private void btn_CheckProduct2_Click(object sender, EventArgs e)
        {
            UI.Invoices.ChooseProductForm f = new Book.UI.Invoices.ChooseProductForm();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Model.Product product = f.SelectedItem as Model.Product;
                if (product != null)
                {
                    this.btn_CheckProduct2.EditValue = product;
                    this.bindingSource4.DataSource = this._manage.SelectByProductId(product.ProductId);
                    if (this.bindingSource4.Count > 0)
                    {
                        this._CustomerProductPrice = this.bindingSource4.Current as Model.CustomerProductPrice;
                        if (this._CustomerProductPrice.CustomerProductPriceRage != null)
                        {
                            AnalyzePriceRange(this._CustomerProductPrice.CustomerProductPriceRage);
                            this.gridControl5.RefreshDataSource();
                        }
                        else
                        {
                            this._priceRangeList.Clear();
                            this.gridControl5.RefreshDataSource();
                        }
                    }
                    else
                    {
                        this._priceRangeList.Clear();
                        this.gridControl5.RefreshDataSource();
                    }
                }

            }
        }

        //检验价格区间是否正确
        private void VerificationPriceRange()
        {
            IList<PriceRange> priceRList = this.bindingSourcePriceRang.DataSource as IList<PriceRange>;
            if (priceRList != null && priceRList.Count > 0)
            {
                try
                {
                    if (priceRList.Last().endRange != 999999999999)
                        throw new Exception();

                    double ComSR, ComER, ComPrice, InSr, InEr, InPrice;
                    bool isContinue = true;
                    PriceRange prFirst = priceRList.First();

                    ComSR = prFirst.startRange; ComER = prFirst.endRange; ComPrice = prFirst.RangePrice;

                    foreach (PriceRange pr in priceRList)
                    {
                        InSr = pr.startRange; InEr = pr.endRange; InPrice = pr.RangePrice;
                        if (priceRList.IndexOf(pr) == 0)
                        {
                            if (InSr != 1 || InPrice <= 0 || InSr > InEr)
                                throw new Exception();
                        }
                        else
                        {
                            if (InSr != ComER + 1 || InPrice <= 0 || InSr > InEr)
                                throw new Exception();
                        }
                        ComSR = pr.startRange; ComER = pr.endRange; InPrice = pr.RangePrice;
                    }
                }
                catch
                {
                    throw new Helper.InvalidValueException("PriceRange.Error");
                    return;
                }
            }
        }

        //组装价格区间
        private string AssemblyPriceRange(IList<PriceRange> priceRList)
        {
            if (priceRList == null || priceRList.Count == 0)
                return string.Empty;

            StringBuilder Result = new StringBuilder();
            foreach (PriceRange pr in priceRList)
            {
                Result.Append(pr.startRange.ToString() + "/" + pr.endRange.ToString() + "/" + pr.RangePrice.ToString() + "/" + pr.GiveQuantity.ToString() + ",");
            }

            return Result.ToString().Substring(0, Result.ToString().Length - 1);
        }

        //价格区间显示
        private void gridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.ListSourceRowIndex < 0)
                return;
            IList<PriceRange> details = this.bindingSourcePriceRang.DataSource as IList<PriceRange>;
            if (details == null || details.Count < 1) return;
            PriceRange prcur = details[e.ListSourceRowIndex] as PriceRange;
            if (prcur != null)
            {
                switch (e.Column.Name)
                {
                    case "gridColumn7":
                    case "gridColumn11":
                        e.DisplayText = prcur.endRange == 999999999999 ? "Infinity" : prcur.endRange.ToString();
                        break;
                }
            }
        }

        //增加删除价格区间
        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.action != "view")
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        PriceRange pr1 = this._priceRangeList.Last();
                        if (pr1.endRange != 999999999999)
                            this._priceRangeList.Add(new PriceRange { startRange = pr1.endRange + 1, endRange = 999999999999, RangePrice = 0 });
                        break;
                    case Keys.Delete:
                        PriceRange pr2 = this.bindingSourcePriceRang.Current as PriceRange;
                        if (pr2.endRange != 999999999999)
                        {
                            this._priceRangeList.Remove(pr2);
                            if (this._priceRangeList.Count == 0)
                                this._priceRangeList.Add(new PriceRange { startRange = 1, endRange = 999999999999, RangePrice = 0 });
                        }
                        break;
                }
            }
            this.gridControl3.RefreshDataSource();
        }

        private void gridView4_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (this.bindingSource4.Current != null)
            {
                Model.CustomerProductPrice cpp = this.bindingSource4.Current as Model.CustomerProductPrice;
                if (this._CustomerProductPrice.CustomerProductPriceRage != null)
                {
                    AnalyzePriceRange(this._CustomerProductPrice.CustomerProductPriceRage);
                    this.gridControl5.RefreshDataSource();
                }
                else
                {
                    this._priceRangeList.Clear();
                    this.gridControl5.RefreshDataSource();
                }
            }
            else
            {
                this._priceRangeList.Clear();
                this.gridControl5.RefreshDataSource();
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //this._CustomerProductPrice = this.bindingSourceCustomerProduct.Current as Model.CustomerProductPrice;
            //if (this._CustomerProductPrice != null)
            //{
            //    this.btn_CheckProduct.EditValue = this._CustomerProductPrice.ProductName;
            //    this.memoEditNote.Text = this._CustomerProductPrice.Note;
            //}
            //if (this._CustomerProductPrice.CustomerProductPriceRage != null)
            //{
            //    AnalyzePriceRange(this._CustomerProductPrice.CustomerProductPriceRage);
            //    this.gridControl3.RefreshDataSource();
            //}
            //else
            //{
            //    this._priceRangeList.Clear();
            //    this._priceRangeList.Add(new PriceRange { startRange = 1, endRange = 999999999999, RangePrice = 0 });
            //    this.gridControl3.RefreshDataSource();
            //}
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.action != "insert")
            {
                this.action = "view";
                this._CustomerProductPrice = this.bindingSourceCustomerProduct.Current as Model.CustomerProductPrice;
                if (this._CustomerProductPrice != null)
                    Refresh();
            }
        }
    }

    public class PriceRange
    {
        /// <summary>
        /// 数量下限
        /// </summary>
        public double startRange { get; set; }

        /// <summary>
        /// 数量上限
        /// </summary>
        public double endRange { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public double RangePrice { get; set; }

        private double _GiveQuantity;

        /// <summary>
        /// 赠送
        /// </summary>
        public double GiveQuantity
        {
            get { return this._GiveQuantity < 0 ? 0 : this._GiveQuantity; }
            set { this._GiveQuantity = value; }
        }
    }
}
