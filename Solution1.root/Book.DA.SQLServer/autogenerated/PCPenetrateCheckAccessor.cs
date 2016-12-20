﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCPenetrateCheckAccessor.autogenerated.cs
// author: mayanjun
// create date：2012-3-21 11:02:47
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
    public partial class PCPenetrateCheckAccessor
    {
		public Model.PCPenetrateCheck Get(string id)
		{
			return this.Get<Model.PCPenetrateCheck>(id);
		}
		
		public void Insert(Model.PCPenetrateCheck e)
		{
			this.Insert<Model.PCPenetrateCheck>(e);
		}
		
		public void Update(Model.PCPenetrateCheck e)
		{
			this.Update<Model.PCPenetrateCheck>(e);
		}
		
		public IList<Model.PCPenetrateCheck> Select()
		{
			return this.Select<Model.PCPenetrateCheck>();
		}
		
		public IList<Model.PCPenetrateCheck> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.PCPenetrateCheck>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.PCPenetrateCheck>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.PCPenetrateCheck>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.PCPenetrateCheck>();
		}
		public int Count()
		{
			return this.Count<Model.PCPenetrateCheck>();
		}
		public bool HasRowsBefore(Model.PCPenetrateCheck e)
		{
			return sqlmapper.QueryForObject<bool>("PCPenetrateCheck.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.PCPenetrateCheck e)
		{
			return sqlmapper.QueryForObject<bool>("PCPenetrateCheck.has_rows_after", e);
		}
		public Model.PCPenetrateCheck GetFirst()
		{
			return sqlmapper.QueryForObject<Model.PCPenetrateCheck>("PCPenetrateCheck.get_first", null);
		}
		public Model.PCPenetrateCheck GetLast()
		{
			return sqlmapper.QueryForObject<Model.PCPenetrateCheck>("PCPenetrateCheck.get_last", null);
		}
		public Model.PCPenetrateCheck GetNext(Model.PCPenetrateCheck e)
		{
			return sqlmapper.QueryForObject<Model.PCPenetrateCheck>("PCPenetrateCheck.get_next", e);
		}
		public Model.PCPenetrateCheck GetPrev(Model.PCPenetrateCheck e)
		{
			return sqlmapper.QueryForObject<Model.PCPenetrateCheck>("PCPenetrateCheck.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("PCPenetrateCheck.existsPrimary", id);
		}
    }
}