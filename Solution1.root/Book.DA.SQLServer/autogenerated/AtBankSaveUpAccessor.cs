﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtBankSaveUpAccessor.autogenerated.cs
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
    public partial class AtBankSaveUpAccessor
    {
		public Model.AtBankSaveUp Get(string id)
		{
			return this.Get<Model.AtBankSaveUp>(id);
		}
		
		public void Insert(Model.AtBankSaveUp e)
		{
			this.Insert<Model.AtBankSaveUp>(e);
		}
		
		public void Update(Model.AtBankSaveUp e)
		{
			this.Update<Model.AtBankSaveUp>(e);
		}
		
		public IList<Model.AtBankSaveUp> Select()
		{
			return this.Select<Model.AtBankSaveUp>();
		}
		
		public IList<Model.AtBankSaveUp> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.AtBankSaveUp>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.AtBankSaveUp>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.AtBankSaveUp>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.AtBankSaveUp>();
		}
		public int Count()
		{
			return this.Count<Model.AtBankSaveUp>();
		}
		public bool HasRowsBefore(Model.AtBankSaveUp e)
		{
			return sqlmapper.QueryForObject<bool>("AtBankSaveUp.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.AtBankSaveUp e)
		{
			return sqlmapper.QueryForObject<bool>("AtBankSaveUp.has_rows_after", e);
		}
		public Model.AtBankSaveUp GetFirst()
		{
			return sqlmapper.QueryForObject<Model.AtBankSaveUp>("AtBankSaveUp.get_first", null);
		}
		public Model.AtBankSaveUp GetLast()
		{
			return sqlmapper.QueryForObject<Model.AtBankSaveUp>("AtBankSaveUp.get_last", null);
		}
		public Model.AtBankSaveUp GetNext(Model.AtBankSaveUp e)
		{
			return sqlmapper.QueryForObject<Model.AtBankSaveUp>("AtBankSaveUp.get_next", e);
		}
		public Model.AtBankSaveUp GetPrev(Model.AtBankSaveUp e)
		{
			return sqlmapper.QueryForObject<Model.AtBankSaveUp>("AtBankSaveUp.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("AtBankSaveUp.exists", id);
		}
		
		public Model.AtBankSaveUp GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.AtBankSaveUp>("AtBankSaveUp.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.AtBankSaveUp e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.SaveUpId)==null?null:Get(e.SaveUpId).Id);
			return sqlmapper.QueryForObject<bool>("AtBankSaveUp.existsexcept", paras);
		}
		
		
		
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("AtBankSaveUp.existsPrimary", id);
		}
    }
}
