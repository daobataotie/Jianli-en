﻿//------------------------------------------------------------------------------
//
// file name:InvoiceXSAccessor.cs
// author: peidun
// create date:2008/6/6 10:00:50
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Book.DA.SQLServer
{
    /// <summary>
    /// Data accessor of InvoiceXS
    /// </summary>
    public partial class InvoiceXSAccessor : EntityAccessor, IInvoiceXSAccessor
    {
        public IList<Book.Model.InvoiceXS> Select(DateTime start, DateTime end)
        {
            Hashtable pars = new Hashtable();
            pars.Add("startTime", start);
            pars.Add("endTime", end);
            return sqlmapper.QueryForList<Model.InvoiceXS>("InvoiceXS.select_byTime", pars);
        }

        public void OwedIncrement(Book.Model.InvoiceXS invoice, decimal money)
        {
            this.OwedIncrement(invoice.InvoiceId, money);
        }

        public void OwedDecrement(Book.Model.InvoiceXS invoice, decimal money)
        {
            this.OwedDecrement(invoice.InvoiceId, money);
        }

        public void OwedIncrement(Book.Model.InvoiceXS invoice, decimal? money)
        {
            this.OwedDecrement(invoice.InvoiceId, money.Value);
        }

        public void OwedDecrement(Book.Model.InvoiceXS invoice, decimal? money)
        {
            this.OwedDecrement(invoice.InvoiceId, money.Value);
        }

        public void OwedIncrement(string invoiceId, decimal money)
        {
            System.Collections.Hashtable paras = new Hashtable();
            paras.Add("InvoiceOwed", money);
            paras.Add("InvoiceId", invoiceId);
            sqlmapper.Update("InvoiceCT.owedincrement", paras);
        }

        public void OwedDecrement(string invoiceId, decimal money)
        {
            System.Collections.Hashtable paras = new Hashtable();
            paras.Add("InvoiceOwed", money);
            paras.Add("InvoiceId", invoiceId);
            sqlmapper.Update("InvoiceXS.oweddecrement", paras);
        }

        public void OwedIncrement(string invoiceId, decimal? money)
        {
            this.OwedIncrement(invoiceId, money.Value);
        }

        public void OwedDecrement(string invoiceId, decimal? money)
        {
            this.OwedDecrement(invoiceId, money.Value);
        }

        public IList<Book.Model.InvoiceXS> Select(Helper.InvoiceStatus status)
        {
            return sqlmapper.QueryForList<Model.InvoiceXS>("InvoiceXS.select_byStatus", (int)status);
        }

        public IList<Book.Model.InvoiceXS> Select(DateTime start, DateTime end, Book.Model.Employee employee)
        {
            Hashtable pars = new Hashtable();
            pars.Add("start", start);
            pars.Add("end", end);
            pars.Add("EmployeeId", employee.EmployeeId);
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_byDateRengeAndEmployee0", pars);
        }

        public IList<Book.Model.InvoiceXS> Select(DateTime start, DateTime end, string startId, string endId)
        {
            Hashtable pars = new Hashtable();
            pars.Add("start", start);
            pars.Add("end", end);
            pars.Add("startId", startId);
            pars.Add("endId", endId);
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_byDateRengeAndCompanyIdRenge", pars);
        }

        public IList<Book.Model.InvoiceXS> Select1(DateTime start, DateTime end)
        {
            Hashtable pars = new Hashtable();
            pars.Add("start", start);
            pars.Add("end", end);
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_byDateRenge", pars);
        }

        public IList<Book.Model.InvoiceXS> Select(Model.InvoiceXO invoicexo)
        {
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_byDateXOId", invoicexo.InvoiceId);
        }

        public IList<Book.Model.InvoiceXS> Select(Model.Customer customer)
        {
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_bycustomerId", customer.CustomerId);
        }

        public IList<Book.Model.InvoiceXS> Select(string customerStart, string customerEnd, string productStart, string productEnd, DateTime dateStart, DateTime dateEnd)
        {
            IList<Book.Model.InvoiceXS> invoiceXS;
            Hashtable ht = new Hashtable();
            ht.Add("customerStart", customerStart);
            ht.Add("customerEnd", customerEnd);
            ht.Add("productStart", productStart);
            ht.Add("productEnd", productEnd);
            ht.Add("dateStart", dateStart);
            ht.Add("dateEnd", dateEnd);
            if (string.IsNullOrEmpty(productEnd))
                invoiceXS = sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.selectbydateProENDNUll", ht);
            else
                invoiceXS = sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.selectbydatePro", ht);

            return invoiceXS;
        }

        public IList<Model.InvoiceXS> SelectInvoice(Model.Customer customer)
        {
            return sqlmapper.QueryForList<Model.InvoiceXS>("InvoiceXS.selectByCustomerId", customer.CustomerId);
        }

        public IList<Model.InvoiceXS> SelectCustomerInfo(string xoid)
        {
            return sqlmapper.QueryForList<Model.InvoiceXS>("InvoiceXS.selectCustomerInfo", xoid);
        }

        public IList<Book.Model.InvoiceXS> SelectDateRangAndWhere(Model.Customer customer, DateTime? dateStart, DateTime? dateEnd, string cusxoid, Model.Product product, string invoicexoid, string FreightedCompanyId, string ConveyanceMethodId)
        {
            Hashtable ht = new Hashtable();
            ht.Add("dateStart", dateStart);
            ht.Add("dateEnd", dateEnd);
            StringBuilder sql = new StringBuilder();
            if (customer != null)
                sql.Append(" and  customerid='" + customer.CustomerId + "'");
            if (!string.IsNullOrEmpty(cusxoid))
                sql.Append(" and  InvoiceId in(select invoiceid from invoicexsdetail where invoicexoid in(select invoiceid from invoicexo where  CustomerInvoiceXOId = '" + cusxoid + "' ))");
            if (!string.IsNullOrEmpty(invoicexoid))
                sql.Append(" and  InvoiceId in(select invoiceid from invoicexsdetail where invoicexoid='" + invoicexoid + "')");
            if (product != null)
                sql.Append(" and  InvoiceId in(select invoiceid from invoicexsdetail where productid='" + product.ProductId + "')  ");
            //if (IsForeigntrade == true)
            //    sql.Append(" AND InvoiceXS.InvoiceId IN (SELECT InvoiceXSDetail.InvoiceId FROM InvoiceXSDetail WHERE InvoiceXOId IN (SELECT InvoiceXO.InvoiceId FROM InvoiceXO WHERE IsForeigntrade=1))");
            if (!string.IsNullOrEmpty(FreightedCompanyId))
                sql.Append(" and  InvoiceId in(select invoiceid from InvoiceXS where  TransportCompany='" + FreightedCompanyId + "') ");
            if (!string.IsNullOrEmpty(ConveyanceMethodId))
                sql.Append(" and  InvoiceId in(select invoiceid from InvoiceXS where  ConveyanceMethodId='" + ConveyanceMethodId + "')");
            ht.Add("sql", sql.ToString());
            return sqlmapper.QueryForList<Book.Model.InvoiceXS>("InvoiceXS.select_where", ht);
        }

        public string SelectByInvoiceCusID(string ID)
        {
            return sqlmapper.QueryForObject<string>("InvoiceXS.SelectByInvoiceCusID", ID);
        }
    }
}
