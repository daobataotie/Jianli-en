﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductOnlineCheckDetailAccessor.autogenerated.cs
// author: mayanjun
// create date：2013-3-26 10:59:39
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
    public partial class ProductOnlineCheckDetailAccessor
    {
		public Model.ProductOnlineCheckDetail Get(string id)
		{
			return this.Get<Model.ProductOnlineCheckDetail>(id);
		}
		
		public void Insert(Model.ProductOnlineCheckDetail e)
		{
			this.Insert<Model.ProductOnlineCheckDetail>(e);
		}
		
		public void Update(Model.ProductOnlineCheckDetail e)
		{
			this.Update<Model.ProductOnlineCheckDetail>(e);
		}
		
		public IList<Model.ProductOnlineCheckDetail> Select()
		{
			return this.Select<Model.ProductOnlineCheckDetail>();
		}
		
		public IList<Model.ProductOnlineCheckDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ProductOnlineCheckDetail>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ProductOnlineCheckDetail>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ProductOnlineCheckDetail>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ProductOnlineCheckDetail>();
		}
		public int Count()
		{
			return this.Count<Model.ProductOnlineCheckDetail>();
		}
		public bool HasRowsBefore(Model.ProductOnlineCheckDetail e)
		{
			return sqlmapper.QueryForObject<bool>("ProductOnlineCheckDetail.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.ProductOnlineCheckDetail e)
		{
			return sqlmapper.QueryForObject<bool>("ProductOnlineCheckDetail.has_rows_after", e);
		}
		public Model.ProductOnlineCheckDetail GetFirst()
		{
			return sqlmapper.QueryForObject<Model.ProductOnlineCheckDetail>("ProductOnlineCheckDetail.get_first", null);
		}
		public Model.ProductOnlineCheckDetail GetLast()
		{
			return sqlmapper.QueryForObject<Model.ProductOnlineCheckDetail>("ProductOnlineCheckDetail.get_last", null);
		}
		public Model.ProductOnlineCheckDetail GetNext(Model.ProductOnlineCheckDetail e)
		{
			return sqlmapper.QueryForObject<Model.ProductOnlineCheckDetail>("ProductOnlineCheckDetail.get_next", e);
		}
		public Model.ProductOnlineCheckDetail GetPrev(Model.ProductOnlineCheckDetail e)
		{
			return sqlmapper.QueryForObject<Model.ProductOnlineCheckDetail>("ProductOnlineCheckDetail.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ProductOnlineCheckDetail.existsPrimary", id);
		}
    }
}