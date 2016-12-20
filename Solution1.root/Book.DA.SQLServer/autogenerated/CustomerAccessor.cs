﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：CustomerAccessor.autogenerated.cs
// author: peidun
// create date：2010-4-22 11:01:39
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
    public partial class CustomerAccessor
    {
		public Model.Customer Get(string id)
		{
			return this.Get<Model.Customer>(id);
		}
		
		public void Insert(Model.Customer e)
        {
         
			this.Insert<Model.Customer>(e);
           
		}
		
		public void Update(Model.Customer e)
		{
			this.Update<Model.Customer>(e);
		}
		
		public IList<Model.Customer> Select()
		{
			return this.Select<Model.Customer>();
		}
		
		public IList<Model.Customer> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.Customer>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.Customer>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.Customer>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.Customer>();
		}
		public int Count()
		{
			return this.Count<Model.Customer>();
		}
		public bool HasRowsBefore(Model.Customer e)
		{
			return sqlmapper.QueryForObject<bool>("Customer.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.Customer e)
		{
			return sqlmapper.QueryForObject<bool>("Customer.has_rows_after", e);
		}
		public Model.Customer GetFirst()
		{
			return sqlmapper.QueryForObject<Model.Customer>("Customer.get_first", null);
		}
		public Model.Customer GetLast()
		{
			return sqlmapper.QueryForObject<Model.Customer>("Customer.get_last", null);
		}
		public Model.Customer GetNext(Model.Customer e)
		{
			return sqlmapper.QueryForObject<Model.Customer>("Customer.get_next", e);
		}
		public Model.Customer GetPrev(Model.Customer e)
		{
			return sqlmapper.QueryForObject<Model.Customer>("Customer.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("Customer.exists", id);
		}
		
		public Model.Customer GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.Customer>("Customer.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.Customer e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.CustomerId)==null?null:Get(e.CustomerId).Id);
			return sqlmapper.QueryForObject<bool>("Customer.existsexcept", paras);
		}
		
		
		
		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("Customer.existsPrimary", id);
		}
    }
}