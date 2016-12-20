﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceCTAccessor.autogenerated.cs
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
    public partial class InvoiceCTAccessor
    {
		public Model.InvoiceCT Get(string id)
		{
			return this.Get<Model.InvoiceCT>(id);
		}
		
		public void Insert(Model.InvoiceCT e)
		{
			this.Insert<Model.InvoiceCT>(e);
		}
		
		public void Update(Model.InvoiceCT e)
		{
			this.Update<Model.InvoiceCT>(e);
		}
		
		public IList<Model.InvoiceCT> Select()
		{
			return this.Select<Model.InvoiceCT>();
		}
		
		public IList<Model.InvoiceCT> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.InvoiceCT>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.InvoiceCT>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.InvoiceCT>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.InvoiceCT>();
		}
		public int Count()
		{
			return this.Count<Model.InvoiceCT>();
		}
		public bool HasRowsBefore(Model.InvoiceCT e)
		{
			return sqlmapper.QueryForObject<bool>("InvoiceCT.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.InvoiceCT e)
		{
			return sqlmapper.QueryForObject<bool>("InvoiceCT.has_rows_after", e);
		}
		public Model.InvoiceCT GetFirst()
		{
			return sqlmapper.QueryForObject<Model.InvoiceCT>("InvoiceCT.get_first", null);
		}
		public Model.InvoiceCT GetLast()
		{
			return sqlmapper.QueryForObject<Model.InvoiceCT>("InvoiceCT.get_last", null);
		}
		public Model.InvoiceCT GetNext(Model.InvoiceCT e)
		{
			return sqlmapper.QueryForObject<Model.InvoiceCT>("InvoiceCT.get_next", e);
		}
		public Model.InvoiceCT GetPrev(Model.InvoiceCT e)
		{
			return sqlmapper.QueryForObject<Model.InvoiceCT>("InvoiceCT.get_prev", e);
		}
		

    }
}
