﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：TechnologydetailsAccessor.autogenerated.cs
// author: peidun
// create date：2009-12-8 16:29:53
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
    public partial class TechnologydetailsAccessor
    {
		public Model.Technologydetails Get(string id)
		{
			return this.Get<Model.Technologydetails>(id);
		}
		
		public void Insert(Model.Technologydetails e)
		{
			this.Insert<Model.Technologydetails>(e);
		}
		
		public void Update(Model.Technologydetails e)
		{
			this.Update<Model.Technologydetails>(e);
		}
		
		public IList<Model.Technologydetails> Select()
		{
			return this.Select<Model.Technologydetails>();
		}
		
		public IList<Model.Technologydetails> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.Technologydetails>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.Technologydetails>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.Technologydetails>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.Technologydetails>();
		}
		public int Count()
		{
			return this.Count<Model.Technologydetails>();
		}
		public bool HasRowsBefore(Model.Technologydetails e)
		{
			return sqlmapper.QueryForObject<bool>("Technologydetails.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.Technologydetails e)
		{
			return sqlmapper.QueryForObject<bool>("Technologydetails.has_rows_after", e);
		}
		public Model.Technologydetails GetFirst()
		{
			return sqlmapper.QueryForObject<Model.Technologydetails>("Technologydetails.get_first", null);
		}
		public Model.Technologydetails GetLast()
		{
			return sqlmapper.QueryForObject<Model.Technologydetails>("Technologydetails.get_last", null);
		}
		public Model.Technologydetails GetNext(Model.Technologydetails e)
		{
			return sqlmapper.QueryForObject<Model.Technologydetails>("Technologydetails.get_next", e);
		}
		public Model.Technologydetails GetPrev(Model.Technologydetails e)
		{
			return sqlmapper.QueryForObject<Model.Technologydetails>("Technologydetails.get_prev", e);
		}
		

    }
}
