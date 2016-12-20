﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PricingWayManager.autogenerated.cs
// author: peidun
// create date：2009-12-9 10:27:05
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PricingWayManager
    {
		///<summary>
		/// Data accessor of dbo.PricingWay
		///</summary>
		private static readonly DA.IPricingWayAccessor accessor = (DA.IPricingWayAccessor)Accessors.Get("PricingWayAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.PricingWay Get(string pricingWayID)
		{
			return accessor.Get(pricingWayID);
		}
		
		public bool HasRows(string pricingWayID)
		{
			return accessor.HasRows(pricingWayID);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool HasRowsBefore(Model.PricingWay e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.PricingWay e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.PricingWay GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.PricingWay GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.PricingWay GetPrev(Model.PricingWay e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.PricingWay GetNext(Model.PricingWay e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.PricingWay> Select()
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
		public IList<Model.PricingWay> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}