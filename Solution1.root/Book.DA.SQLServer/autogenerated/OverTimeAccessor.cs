﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：OverTimeAccessor.autogenerated.cs
// author: peidun
// create date：2010-3-20 11:59:56
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
    public partial class OverTimeAccessor
    {
		public Model.OverTime Get(string id)
		{
			return this.Get<Model.OverTime>(id);
		}
		
		public void Insert(Model.OverTime e)
		{
			this.Insert<Model.OverTime>(e);
		}
		
		public void Update(Model.OverTime e)
		{
			this.Update<Model.OverTime>(e);
		}
		
		public IList<Model.OverTime> Select()
		{
			return this.Select<Model.OverTime>();
		}
		
		public IList<Model.OverTime> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.OverTime>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.OverTime>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.OverTime>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.OverTime>();
		}
		public int Count()
		{
			return this.Count<Model.OverTime>();
		}
		public bool HasRowsBefore(Model.OverTime e)
		{
			return sqlmapper.QueryForObject<bool>("OverTime.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.OverTime e)
		{
			return sqlmapper.QueryForObject<bool>("OverTime.has_rows_after", e);
		}
		public Model.OverTime GetFirst()
		{
			return sqlmapper.QueryForObject<Model.OverTime>("OverTime.get_first", null);
		}
		public Model.OverTime GetLast()
		{
			return sqlmapper.QueryForObject<Model.OverTime>("OverTime.get_last", null);
		}
		public Model.OverTime GetNext(Model.OverTime e)
		{
			return sqlmapper.QueryForObject<Model.OverTime>("OverTime.get_next", e);
		}
		public Model.OverTime GetPrev(Model.OverTime e)
		{
			return sqlmapper.QueryForObject<Model.OverTime>("OverTime.get_prev", e);
		}
		

    }
}
