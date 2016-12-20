﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCOtherCheckAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-11-10 15:05:57
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
    public partial class PCOtherCheckAccessor
    {
		public Model.PCOtherCheck Get(string id)
		{
			return this.Get<Model.PCOtherCheck>(id);
		}
		
		public void Insert(Model.PCOtherCheck e)
		{
			this.Insert<Model.PCOtherCheck>(e);
		}
		
		public void Update(Model.PCOtherCheck e)
		{
			this.Update<Model.PCOtherCheck>(e);
		}
		
		public IList<Model.PCOtherCheck> Select()
		{
			return this.Select<Model.PCOtherCheck>();
		}
		
		public IList<Model.PCOtherCheck> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.PCOtherCheck>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.PCOtherCheck>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.PCOtherCheck>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.PCOtherCheck>();
		}
		public int Count()
		{
			return this.Count<Model.PCOtherCheck>();
		}
		public bool HasRowsBefore(Model.PCOtherCheck e)
		{
			return sqlmapper.QueryForObject<bool>("PCOtherCheck.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.PCOtherCheck e)
		{
			return sqlmapper.QueryForObject<bool>("PCOtherCheck.has_rows_after", e);
		}
		public Model.PCOtherCheck GetFirst()
		{
			return sqlmapper.QueryForObject<Model.PCOtherCheck>("PCOtherCheck.get_first", null);
		}
		public Model.PCOtherCheck GetLast()
		{
			return sqlmapper.QueryForObject<Model.PCOtherCheck>("PCOtherCheck.get_last", null);
		}
		public Model.PCOtherCheck GetNext(Model.PCOtherCheck e)
		{
			return sqlmapper.QueryForObject<Model.PCOtherCheck>("PCOtherCheck.get_next", e);
		}
		public Model.PCOtherCheck GetPrev(Model.PCOtherCheck e)
		{
			return sqlmapper.QueryForObject<Model.PCOtherCheck>("PCOtherCheck.get_prev", e);
		}
		

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("PCOtherCheck.existsPrimary", id);
		}
    }
}