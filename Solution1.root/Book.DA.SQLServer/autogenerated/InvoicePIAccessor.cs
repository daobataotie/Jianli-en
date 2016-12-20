﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoicePIAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:03
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
    public partial class InvoicePIAccessor
    {
		public Model.InvoicePI Get(string id)
		{
			return this.Get<Model.InvoicePI>(id);
		}
		
		public void Insert(Model.InvoicePI e)
		{
			this.Insert<Model.InvoicePI>(e);
		}
		
		public void Update(Model.InvoicePI e)
		{
			this.Update<Model.InvoicePI>(e);
		}
		
		public IList<Model.InvoicePI> Select()
		{
			return this.Select<Model.InvoicePI>();
		}
		
		public IList<Model.InvoicePI> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.InvoicePI>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.InvoicePI>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.InvoicePI>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.InvoicePI>();
		}
		public int Count()
		{
			return this.Count<Model.InvoicePI>();
		}
		public bool HasRowsBefore(Model.InvoicePI e)
		{
			return sqlmapper.QueryForObject<bool>("InvoicePI.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.InvoicePI e)
		{
			return sqlmapper.QueryForObject<bool>("InvoicePI.has_rows_after", e);
		}
		public Model.InvoicePI GetFirst()
		{
			return sqlmapper.QueryForObject<Model.InvoicePI>("InvoicePI.get_first", null);
		}
		public Model.InvoicePI GetLast()
		{
			return sqlmapper.QueryForObject<Model.InvoicePI>("InvoicePI.get_last", null);
		}
		public Model.InvoicePI GetNext(Model.InvoicePI e)
		{
			return sqlmapper.QueryForObject<Model.InvoicePI>("InvoicePI.get_next", e);
		}
		public Model.InvoicePI GetPrev(Model.InvoicePI e)
		{
			return sqlmapper.QueryForObject<Model.InvoicePI>("InvoicePI.get_prev", e);
		}
		

    }
}