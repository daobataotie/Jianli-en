﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductMouldTestDetailAccessor.autogenerated.cs
// author: mayanjun
// create date：2010-10-4 11:45:52
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
    public partial class ProductMouldTestDetailAccessor
    {
		public Model.ProductMouldTestDetail Get(string id)
		{
			return this.Get<Model.ProductMouldTestDetail>(id);
		}
		
		public void Insert(Model.ProductMouldTestDetail e)
		{
			this.Insert<Model.ProductMouldTestDetail>(e);
		}
		
		public void Update(Model.ProductMouldTestDetail e)
		{
			this.Update<Model.ProductMouldTestDetail>(e);
		}
		
		public IList<Model.ProductMouldTestDetail> Select()
		{
			return this.Select<Model.ProductMouldTestDetail>();
		}
		
		public IList<Model.ProductMouldTestDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ProductMouldTestDetail>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ProductMouldTestDetail>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ProductMouldTestDetail>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ProductMouldTestDetail>();
		}
		public int Count()
		{
			return this.Count<Model.ProductMouldTestDetail>();
		}
		public bool HasRowsBefore(Model.ProductMouldTestDetail e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldTestDetail.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.ProductMouldTestDetail e)
		{
			return sqlmapper.QueryForObject<bool>("ProductMouldTestDetail.has_rows_after", e);
		}
		public Model.ProductMouldTestDetail GetFirst()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTestDetail>("ProductMouldTestDetail.get_first", null);
		}
		public Model.ProductMouldTestDetail GetLast()
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTestDetail>("ProductMouldTestDetail.get_last", null);
		}
		public Model.ProductMouldTestDetail GetNext(Model.ProductMouldTestDetail e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTestDetail>("ProductMouldTestDetail.get_next", e);
		}
		public Model.ProductMouldTestDetail GetPrev(Model.ProductMouldTestDetail e)
		{
			return sqlmapper.QueryForObject<Model.ProductMouldTestDetail>("ProductMouldTestDetail.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ProductMouldTestDetail.existsPrimary", id);
		}
    }
}
