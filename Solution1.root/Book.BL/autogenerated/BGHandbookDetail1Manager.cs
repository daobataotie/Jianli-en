﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：BGHandbookDetail1Manager.autogenerated.cs
// author: mayanjun
// create date：2013-4-16 11:59:01
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class BGHandbookDetail1Manager
    {
		///<summary>
		/// Data accessor of dbo.BGHandbookDetail1
		///</summary>
		private static readonly DA.IBGHandbookDetail1Accessor accessor = (DA.IBGHandbookDetail1Accessor)Accessors.Get("BGHandbookDetail1Accessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.BGHandbookDetail1 Get(string bGHandbookDetail1Id)
		{
			return accessor.Get(bGHandbookDetail1Id);
		}
		
		public bool HasRows(string bGHandbookDetail1Id)
		{
			return accessor.HasRows(bGHandbookDetail1Id);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.BGHandbookDetail1 GetById(string id)
		{
			return accessor.GetById(id);
		}		
		public bool ExistsExcept(Model.BGHandbookDetail1 e)
		{
			return accessor.ExistsExcept(e);
		}
		
		
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.BGHandbookDetail1> Select()
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
		public IList<Model.BGHandbookDetail1> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}