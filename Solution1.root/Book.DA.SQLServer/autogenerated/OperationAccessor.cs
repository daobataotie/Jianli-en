﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：OperationAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-5-11 10:51:07
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
    public partial class OperationAccessor
    {
		public Model.Operation Get(string id)
		{
			return this.Get<Model.Operation>(id);
		}
		
		public void Insert(Model.Operation e)
		{
			this.Insert<Model.Operation>(e);
		}
		
		public void Update(Model.Operation e)
		{
			this.Update<Model.Operation>(e);
		}
		
		public IList<Model.Operation> Select()
		{
			return this.Select<Model.Operation>();
		}
		
		public IList<Model.Operation> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.Operation>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.Operation>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.Operation>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.Operation>();
		}
		public int Count()
		{
			return this.Count<Model.Operation>();
		}
		public bool HasRowsBefore(Model.Operation e)
		{
			return sqlmapper.QueryForObject<bool>("Operation.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.Operation e)
		{
			return sqlmapper.QueryForObject<bool>("Operation.has_rows_after", e);
		}
		public Model.Operation GetFirst()
		{
			return sqlmapper.QueryForObject<Model.Operation>("Operation.get_first", null);
		}
		public Model.Operation GetLast()
		{
			return sqlmapper.QueryForObject<Model.Operation>("Operation.get_last", null);
		}
		public Model.Operation GetNext(Model.Operation e)
		{
			return sqlmapper.QueryForObject<Model.Operation>("Operation.get_next", e);
		}
		public Model.Operation GetPrev(Model.Operation e)
		{
			return sqlmapper.QueryForObject<Model.Operation>("Operation.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("Operation.existsPrimary", id);
		}
    }
}
