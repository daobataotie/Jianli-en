﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductMouldSizeAccessor.autogenerated.cs
// author: mayanjun
// create date：2013-2-21 17:29:15
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
    public partial class ProductMouldSizeAccessor
    {
		public Model.ProductMouldSize Get(string id)
		{
			return this.Get<Model.ProductMouldSize>(id);
		}
		
		public void Insert(Model.ProductMouldSize e)
		{
			this.Insert<Model.ProductMouldSize>(e);
		}
		
		public void Update(Model.ProductMouldSize e)
		{
			this.Update<Model.ProductMouldSize>(e);
		}
		
		public IList<Model.ProductMouldSize> Select()
		{
			return this.Select<Model.ProductMouldSize>();
		}
		
		public IList<Model.ProductMouldSize> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ProductMouldSize>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ProductMouldSize>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ProductMouldSize>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ProductMouldSize>();
		}
		public int Count()
		{
			return this.Count<Model.ProductMouldSize>();
		}
		public bool HasRowsBefore(Model.ProductMouldSize e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldSize.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.ProductMouldSize e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldSize.has_rows_after", e);
		}
		public Model.ProductMouldSize GetFirst()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldSize>("ProductMouldSize.get_first", null);
		}
		public Model.ProductMouldSize GetLast()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldSize>("ProductMouldSize.get_last", null);
		}
		public Model.ProductMouldSize GetNext(Model.ProductMouldSize e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldSize>("ProductMouldSize.get_next", e);
		}
		public Model.ProductMouldSize GetPrev(Model.ProductMouldSize e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldSize>("ProductMouldSize.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ProductMouldSize.existsPrimary", id);
		}
    }
}