﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCDoubleImpactCheckDetailManager.autogenerated.cs
// author: mayanjun
// create date：2011-11-24 17:38:50
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PCDoubleImpactCheckDetailManager
    {
		///<summary>
		/// Data accessor of dbo.PCDoubleImpactCheckDetail
		///</summary>
		private static readonly DA.IPCDoubleImpactCheckDetailAccessor accessor = (DA.IPCDoubleImpactCheckDetailAccessor)Accessors.Get("PCDoubleImpactCheckDetailAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.PCDoubleImpactCheckDetail Get(string pCDoubleImpactCheckDetailID)
		{
			return accessor.Get(pCDoubleImpactCheckDetailID);
		}
		
		public bool HasRows(string pCDoubleImpactCheckDetailID)
		{
			return accessor.HasRows(pCDoubleImpactCheckDetailID);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.PCDoubleImpactCheckDetail> Select()
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
		public IList<Model.PCDoubleImpactCheckDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}