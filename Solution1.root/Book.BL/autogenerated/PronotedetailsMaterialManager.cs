﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PronotedetailsMaterialManager.autogenerated.cs
// author: mayanjun
// create date：2010-9-15 10:11:06
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PronotedetailsMaterialManager
    {
		///<summary>
		/// Data accessor of dbo.PronotedetailsMaterial
		///</summary>
		private static readonly DA.IPronotedetailsMaterialAccessor accessor = (DA.IPronotedetailsMaterialAccessor)Accessors.Get("PronotedetailsMaterialAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.PronotedetailsMaterial Get(string pronotedetailsMaterialId)
		{
			return accessor.Get(pronotedetailsMaterialId);
		}
		
		public bool HasRows(string pronotedetailsMaterialId)
		{
			return accessor.HasRows(pronotedetailsMaterialId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.PronotedetailsMaterial> Select()
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
		public IList<Model.PronotedetailsMaterial> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }

    }
}
