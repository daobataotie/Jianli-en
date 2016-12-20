﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：HrAttendStatAccessor.autogenerated.cs
// author: mayanjun
// create date：2010-7-6 11:09:56
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
    public partial class HrAttendStatAccessor
    {
		public Model.HrAttendStat Get(string id)
		{
			return this.Get<Model.HrAttendStat>(id);
		}
		
		public void Insert(Model.HrAttendStat e)
		{
			this.Insert<Model.HrAttendStat>(e);
		}
		
		public void Update(Model.HrAttendStat e)
		{
			this.Update<Model.HrAttendStat>(e);
		}
		
		public IList<Model.HrAttendStat> Select()
		{
			return this.Select<Model.HrAttendStat>();
		}
		
		public IList<Model.HrAttendStat> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.HrAttendStat>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.HrAttendStat>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.HrAttendStat>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.HrAttendStat>();
		}
		public int Count()
		{
			return this.Count<Model.HrAttendStat>();
		}

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("HrAttendStat.existsPrimary", id);
		}
    }
}