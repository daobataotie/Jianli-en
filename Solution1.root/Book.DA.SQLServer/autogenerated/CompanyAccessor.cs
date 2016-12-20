﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：CompanyAccessor.autogenerated.cs
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
    public partial class CompanyAccessor
    {
		public Model.Company Get(string id)
		{
			return this.Get<Model.Company>(id);
		}
		
		public void Insert(Model.Company e)
		{
			this.Insert<Model.Company>(e);
		}
		
		public void Update(Model.Company e)
		{
			this.Update<Model.Company>(e);
		}
		
		public IList<Model.Company> Select()
		{
			return this.Select<Model.Company>();
		}
		
		public IList<Model.Company> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.Company>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.Company>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.Company>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.Company>();
		}
		public int Count()
		{
			return this.Count<Model.Company>();
		}
		public bool HasRowsBefore(Model.Company e)
		{
			return sqlmapper.QueryForObject<bool>("Company.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.Company e)
		{
			return sqlmapper.QueryForObject<bool>("Company.has_rows_after", e);
		}
		public Model.Company GetFirst()
		{
			return sqlmapper.QueryForObject<Model.Company>("Company.get_first", null);
		}
		public Model.Company GetLast()
		{
			return sqlmapper.QueryForObject<Model.Company>("Company.get_last", null);
		}
		public Model.Company GetNext(Model.Company e)
		{
			return sqlmapper.QueryForObject<Model.Company>("Company.get_next", e);
		}
		public Model.Company GetPrev(Model.Company e)
		{
			return sqlmapper.QueryForObject<Model.Company>("Company.get_prev", e);
		}
		

    }
}