﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：RetailDetailAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:04
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
    public partial class RetailDetailAccessor
    {
		public Model.RetailDetail Get(string id)
		{
			return this.Get<Model.RetailDetail>(id);
		}
		
		public void Insert(Model.RetailDetail e)
		{
			this.Insert<Model.RetailDetail>(e);
		}
		
		public void Update(Model.RetailDetail e)
		{
			this.Update<Model.RetailDetail>(e);
		}
		
		public IList<Model.RetailDetail> Select()
		{
			return this.Select<Model.RetailDetail>();
		}
		
		public IList<Model.RetailDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.RetailDetail>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.RetailDetail>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.RetailDetail>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.RetailDetail>();
		}
		public int Count()
		{
			return this.Count<Model.RetailDetail>();
		}

    }
}
