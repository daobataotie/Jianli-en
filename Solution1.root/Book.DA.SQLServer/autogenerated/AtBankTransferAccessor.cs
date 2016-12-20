﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtBankTransferAccessor.autogenerated.cs
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
    public partial class AtBankTransferAccessor
    {
		public Model.AtBankTransfer Get(string id)
		{
			return this.Get<Model.AtBankTransfer>(id);
		}
		
		public void Insert(Model.AtBankTransfer e)
		{
			this.Insert<Model.AtBankTransfer>(e);
		}
		
		public void Update(Model.AtBankTransfer e)
		{
			this.Update<Model.AtBankTransfer>(e);
		}
		
		public IList<Model.AtBankTransfer> Select()
		{
			return this.Select<Model.AtBankTransfer>();
		}
		
		public IList<Model.AtBankTransfer> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.AtBankTransfer>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.AtBankTransfer>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.AtBankTransfer>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.AtBankTransfer>();
		}
		public int Count()
		{
			return this.Count<Model.AtBankTransfer>();
		}
		public bool HasRowsBefore(Model.AtBankTransfer e)
		{
			return sqlmapper.QueryForObject<bool>("AtBankTransfer.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.AtBankTransfer e)
		{
			return sqlmapper.QueryForObject<bool>("AtBankTransfer.has_rows_after", e);
		}
		public Model.AtBankTransfer GetFirst()
		{
			return sqlmapper.QueryForObject<Model.AtBankTransfer>("AtBankTransfer.get_first", null);
		}
		public Model.AtBankTransfer GetLast()
		{
			return sqlmapper.QueryForObject<Model.AtBankTransfer>("AtBankTransfer.get_last", null);
		}
		public Model.AtBankTransfer GetNext(Model.AtBankTransfer e)
		{
			return sqlmapper.QueryForObject<Model.AtBankTransfer>("AtBankTransfer.get_next", e);
		}
		public Model.AtBankTransfer GetPrev(Model.AtBankTransfer e)
		{
			return sqlmapper.QueryForObject<Model.AtBankTransfer>("AtBankTransfer.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("AtBankTransfer.exists", id);
		}
		
		public Model.AtBankTransfer GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.AtBankTransfer>("AtBankTransfer.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.AtBankTransfer e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.TransferId)==null?null:Get(e.TransferId).Id);
			return sqlmapper.QueryForObject<bool>("AtBankTransfer.existsexcept", paras);
		}
		
		
		
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("AtBankTransfer.existsPrimary", id);
		}
    }
}