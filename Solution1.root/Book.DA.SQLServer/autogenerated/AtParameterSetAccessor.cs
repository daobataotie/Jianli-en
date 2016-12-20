﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtParameterSetAccessor.autogenerated.cs
// author: mayanjun
// create date：2012-3-26 14:47:51
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
    public partial class AtParameterSetAccessor
    {
		public Model.AtParameterSet Get(string id)
		{
			return this.Get<Model.AtParameterSet>(id);
		}
		
		public void Insert(Model.AtParameterSet e)
		{
			this.Insert<Model.AtParameterSet>(e);
		}
		
		public void Update(Model.AtParameterSet e)
		{
			this.Update<Model.AtParameterSet>(e);
		}
		
		public IList<Model.AtParameterSet> Select()
		{
			return this.Select<Model.AtParameterSet>();
		}
		
		public IList<Model.AtParameterSet> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.AtParameterSet>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.AtParameterSet>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.AtParameterSet>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.AtParameterSet>();
		}
		public int Count()
		{
			return this.Count<Model.AtParameterSet>();
		}
		public bool HasRowsBefore(Model.AtParameterSet e)
		{
			return sqlmapper.QueryForObject<bool>("AtParameterSet.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.AtParameterSet e)
		{
			return sqlmapper.QueryForObject<bool>("AtParameterSet.has_rows_after", e);
		}
		public Model.AtParameterSet GetFirst()
		{
			return sqlmapper.QueryForObject<Model.AtParameterSet>("AtParameterSet.get_first", null);
		}
		public Model.AtParameterSet GetLast()
		{
			return sqlmapper.QueryForObject<Model.AtParameterSet>("AtParameterSet.get_last", null);
		}
		public Model.AtParameterSet GetNext(Model.AtParameterSet e)
		{
			return sqlmapper.QueryForObject<Model.AtParameterSet>("AtParameterSet.get_next", e);
		}
		public Model.AtParameterSet GetPrev(Model.AtParameterSet e)
		{
			return sqlmapper.QueryForObject<Model.AtParameterSet>("AtParameterSet.get_prev", e);
		}
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("AtParameterSet.existsPrimary", id);
		}
    }
}