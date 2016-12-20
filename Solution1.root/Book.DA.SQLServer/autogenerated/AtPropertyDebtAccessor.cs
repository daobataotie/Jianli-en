﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtPropertyDebtAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-3-3 14:30:20
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
    public partial class AtPropertyDebtAccessor
    {
		public Model.AtPropertyDebt Get(string id)
		{
			return this.Get<Model.AtPropertyDebt>(id);
		}
		
		public void Insert(Model.AtPropertyDebt e)
		{
			this.Insert<Model.AtPropertyDebt>(e);
		}
		
		public void Update(Model.AtPropertyDebt e)
		{
			this.Update<Model.AtPropertyDebt>(e);
		}
		
		public IList<Model.AtPropertyDebt> Select()
		{
			return this.Select<Model.AtPropertyDebt>();
		}
		
		public IList<Model.AtPropertyDebt> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.AtPropertyDebt>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.AtPropertyDebt>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.AtPropertyDebt>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.AtPropertyDebt>();
		}
		public int Count()
		{
			return this.Count<Model.AtPropertyDebt>();
		}
		public bool HasRowsBefore(Model.AtPropertyDebt e)
		{
			return sqlmapper.QueryForObject<bool>("AtPropertyDebt.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.AtPropertyDebt e)
		{
			return sqlmapper.QueryForObject<bool>("AtPropertyDebt.has_rows_after", e);
		}
		public Model.AtPropertyDebt GetFirst()
		{
			return sqlmapper.QueryForObject<Model.AtPropertyDebt>("AtPropertyDebt.get_first", null);
		}
		public Model.AtPropertyDebt GetLast()
		{
			return sqlmapper.QueryForObject<Model.AtPropertyDebt>("AtPropertyDebt.get_last", null);
		}
		public Model.AtPropertyDebt GetNext(Model.AtPropertyDebt e)
		{
			return sqlmapper.QueryForObject<Model.AtPropertyDebt>("AtPropertyDebt.get_next", e);
		}
		public Model.AtPropertyDebt GetPrev(Model.AtPropertyDebt e)
		{
			return sqlmapper.QueryForObject<Model.AtPropertyDebt>("AtPropertyDebt.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("AtPropertyDebt.exists", id);
		}
		
		public Model.AtPropertyDebt GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.AtPropertyDebt>("AtPropertyDebt.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.AtPropertyDebt e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.PropertyDebtId)==null?null:Get(e.PropertyDebtId).Id);
			return sqlmapper.QueryForObject<bool>("AtPropertyDebt.existsexcept", paras);
		}
		
		
		
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("AtPropertyDebt.existsPrimary", id);
		}
    }
}