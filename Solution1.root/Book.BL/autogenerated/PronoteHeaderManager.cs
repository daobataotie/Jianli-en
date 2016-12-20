﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PronoteHeaderManager.autogenerated.cs
// author: mayanjun
// create date：2011-10-21 17:08:43
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PronoteHeaderManager
    {
		///<summary>
		/// Data accessor of dbo.PronoteHeader
		///</summary>
		private static readonly DA.IPronoteHeaderAccessor accessor = (DA.IPronoteHeaderAccessor)Accessors.Get("PronoteHeaderAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.PronoteHeader Get(string pronoteHeaderID)
		{
			return accessor.Get(pronoteHeaderID);
		}
		
		public bool HasRows(string pronoteHeaderID)
		{
			return accessor.HasRows(pronoteHeaderID);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		
		public bool HasRowsBefore(Model.PronoteHeader e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.PronoteHeader e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.PronoteHeader GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.PronoteHeader GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.PronoteHeader GetPrev(Model.PronoteHeader e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.PronoteHeader GetNext(Model.PronoteHeader e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.PronoteHeader> Select()
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
		public IList<Model.PronoteHeader> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}