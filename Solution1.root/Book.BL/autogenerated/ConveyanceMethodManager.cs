﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ConveyanceMethodManager.autogenerated.cs
// author: mayanjun
// create date：2010-8-9 15:00:23
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class ConveyanceMethodManager
    {
		///<summary>
		/// Data accessor of dbo.ConveyanceMethod
		///</summary>
		private static readonly DA.IConveyanceMethodAccessor accessor = (DA.IConveyanceMethodAccessor)Accessors.Get("ConveyanceMethodAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.ConveyanceMethod Get(string conveyanceMethodId)
		{
			return accessor.Get(conveyanceMethodId);
		}
		
		public bool HasRows(string conveyanceMethodId)
		{
			return accessor.HasRows(conveyanceMethodId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.ConveyanceMethod GetById(string id)
		{
			return accessor.GetById(id);
		}		
		public bool ExistsExcept(Model.ConveyanceMethod e)
		{
			return accessor.ExistsExcept(e);
		}
		
		
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.ConveyanceMethod> Select()
		{
			return accessor.Select();
		}
		
		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int Count()
		{
			return accessor.Count();
		}
		
		/// <summary>
		/// 获取指定状态、指定分页，并按指定要求排序的记录
		/// </summary>
		public IList<Model.ConveyanceMethod> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}