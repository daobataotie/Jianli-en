﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：XR1Accessor.autogenerated.cs
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
    public partial class XR1Accessor
    {
		public Model.XR1 Get(string id)
		{
			return this.Get<Model.XR1>(id);
		}
		
		public void Insert(Model.XR1 e)
		{
			this.Insert<Model.XR1>(e);
		}
		
		public void Update(Model.XR1 e)
		{
			this.Update<Model.XR1>(e);
		}
		
		public IList<Model.XR1> Select()
		{
			return this.Select<Model.XR1>();
		}
		
		public IList<Model.XR1> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.XR1>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.XR1>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.XR1>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.XR1>();
		}
		public int Count()
		{
			return this.Count<Model.XR1>();
		}

    }
}