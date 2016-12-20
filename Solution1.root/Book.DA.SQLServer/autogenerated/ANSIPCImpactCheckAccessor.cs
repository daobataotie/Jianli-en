﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ANSIPCImpactCheckAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-11-23 16:59:40
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
    public partial class ANSIPCImpactCheckAccessor
    {
		public Model.ANSIPCImpactCheck Get(string id)
		{
			return this.Get<Model.ANSIPCImpactCheck>(id);
		}
		
		public void Insert(Model.ANSIPCImpactCheck e)
		{
			this.Insert<Model.ANSIPCImpactCheck>(e);
		}
		
		public void Update(Model.ANSIPCImpactCheck e)
		{
			this.Update<Model.ANSIPCImpactCheck>(e);
		}
		
		public IList<Model.ANSIPCImpactCheck> Select()
		{
			return this.Select<Model.ANSIPCImpactCheck>();
		}
		
		public IList<Model.ANSIPCImpactCheck> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ANSIPCImpactCheck>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ANSIPCImpactCheck>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ANSIPCImpactCheck>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ANSIPCImpactCheck>();
		}
		public int Count()
		{
			return this.Count<Model.ANSIPCImpactCheck>();
		}
		public bool HasRowsBefore(Model.ANSIPCImpactCheck e)
		{
			return sqlmapper.QueryForObject<bool>("ANSIPCImpactCheck.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.ANSIPCImpactCheck e)
		{
			return sqlmapper.QueryForObject<bool>("ANSIPCImpactCheck.has_rows_after", e);
		}
		public Model.ANSIPCImpactCheck GetFirst()
		{
			return sqlmapper.QueryForObject<Model.ANSIPCImpactCheck>("ANSIPCImpactCheck.get_first", null);
		}
		public Model.ANSIPCImpactCheck GetLast()
		{
			return sqlmapper.QueryForObject<Model.ANSIPCImpactCheck>("ANSIPCImpactCheck.get_last", null);
		}
		public Model.ANSIPCImpactCheck GetNext(Model.ANSIPCImpactCheck e)
		{
			return sqlmapper.QueryForObject<Model.ANSIPCImpactCheck>("ANSIPCImpactCheck.get_next", e);
		}
		public Model.ANSIPCImpactCheck GetPrev(Model.ANSIPCImpactCheck e)
		{
			return sqlmapper.QueryForObject<Model.ANSIPCImpactCheck>("ANSIPCImpactCheck.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ANSIPCImpactCheck.existsPrimary", id);
		}
    }
}
