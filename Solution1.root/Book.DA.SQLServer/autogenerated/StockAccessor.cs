﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：StockAccessor.autogenerated.cs
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
    public partial class StockAccessor
    {
		public Model.Stock Get(string id)
		{
			return this.Get<Model.Stock>(id);
		}
		
		public void Insert(Model.Stock e)
		{
			this.Insert<Model.Stock>(e);
		}
		
		public void Update(Model.Stock e)
		{
			this.Update<Model.Stock>(e);
		}
		
		public IList<Model.Stock> Select()
		{
			return this.Select<Model.Stock>();
		}
		
		public IList<Model.Stock> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.Stock>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.Stock>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.Stock>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.Stock>();
		}
		public int Count()
		{
			return this.Count<Model.Stock>();
		}

    }
}