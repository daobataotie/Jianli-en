﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCFogCheckDetailManager.autogenerated.cs
// author: mayanjun
// create date：2012-3-17 09:38:32
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PCFogCheckDetailManager
    {
		///<summary>
		/// Data accessor of dbo.PCFogCheckDetail
		///</summary>
		private static readonly DA.IPCFogCheckDetailAccessor accessor = (DA.IPCFogCheckDetailAccessor)Accessors.Get("PCFogCheckDetailAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.PCFogCheckDetail Get(string pCImpactCheckDetailId)
		{
			return accessor.Get(pCImpactCheckDetailId);
		}
		
		public bool HasRows(string pCImpactCheckDetailId)
		{
			return accessor.HasRows(pCImpactCheckDetailId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.PCFogCheckDetail> Select()
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
		public IList<Model.PCFogCheckDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}
