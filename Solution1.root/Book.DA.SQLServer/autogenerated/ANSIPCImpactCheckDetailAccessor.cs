﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ANSIPCImpactCheckDetailAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-11-23 09:50:26
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
    public partial class ANSIPCImpactCheckDetailAccessor
    {
		public Model.ANSIPCImpactCheckDetail Get(string id)
		{
			return this.Get<Model.ANSIPCImpactCheckDetail>(id);
		}
		
		public void Insert(Model.ANSIPCImpactCheckDetail e)
		{
			this.Insert<Model.ANSIPCImpactCheckDetail>(e);
		}
		
		public void Update(Model.ANSIPCImpactCheckDetail e)
		{
			this.Update<Model.ANSIPCImpactCheckDetail>(e);
		}
		
		public IList<Model.ANSIPCImpactCheckDetail> Select()
		{
			return this.Select<Model.ANSIPCImpactCheckDetail>();
		}
		
		public IList<Model.ANSIPCImpactCheckDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.ANSIPCImpactCheckDetail>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.ANSIPCImpactCheckDetail>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.ANSIPCImpactCheckDetail>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.ANSIPCImpactCheckDetail>();
		}
		public int Count()
		{
			return this.Count<Model.ANSIPCImpactCheckDetail>();
		}

		public bool ExistsPrimary(string id)
		{			
			return sqlmapper.QueryForObject<bool>("ANSIPCImpactCheckDetail.existsPrimary", id);
		}
    }
}