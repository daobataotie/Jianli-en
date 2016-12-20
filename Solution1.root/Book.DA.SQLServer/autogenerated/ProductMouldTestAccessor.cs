﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductMouldTestAccessor.autogenerated.cs
// author: mayanjun
// create date：2012-7-13 16:40:37
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
    public partial class ProductMouldTestAccessor
    {
		public Model.ProductMouldTest Get(string id)
		{
			return this.Get<Model.ProductMouldTest>(id);
		}
		
		public void Insert(Model.ProductMouldTest e)
		{
			this.Insert<Model.ProductMouldTest>(e);
		}
		
		public void Update(Model.ProductMouldTest e)
		{
			this.Update<Model.ProductMouldTest>(e);
		}
		
		public IList<Model.ProductMouldTest> Select()
		{
			return this.Select<Model.ProductMouldTest>();
		}
		
		public IList<Model.ProductMouldTest> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ProductMouldTest>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ProductMouldTest>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ProductMouldTest>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ProductMouldTest>();
		}
		public int Count()
		{
			return this.Count<Model.ProductMouldTest>();
		}
		public bool HasRowsBefore(Model.ProductMouldTest e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldTest.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.ProductMouldTest e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldTest.has_rows_after", e);
		}
		public Model.ProductMouldTest GetFirst()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTest>("ProductMouldTest.get_first", null);
		}
		public Model.ProductMouldTest GetLast()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTest>("ProductMouldTest.get_last", null);
		}
		public Model.ProductMouldTest GetNext(Model.ProductMouldTest e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTest>("ProductMouldTest.get_next", e);
		}
		public Model.ProductMouldTest GetPrev(Model.ProductMouldTest e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTest>("ProductMouldTest.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldTest.exists", id);
		}
		
		public Model.ProductMouldTest GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTest>("ProductMouldTest.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.ProductMouldTest e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.ProductMouldTestId)==null?null:Get(e.ProductMouldTestId).Id);
			return sqlmapper.QueryForObject<bool>("ProductMouldTest.existsexcept", paras);
		}
		
		
		
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ProductMouldTest.existsPrimary", id);
		}
    }
}
