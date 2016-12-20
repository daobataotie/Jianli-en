﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：TradeCategoryManager.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:02
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class TradeCategoryManager
    {
		///<summary>
		/// Data accessor of dbo.TradeCategory
		///</summary>
		private static readonly DA.ITradeCategoryAccessor accessor = (DA.ITradeCategoryAccessor)Accessors.Get("TradeCategoryAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.TradeCategory Get(string tradeCategoryId)
		{
			return accessor.Get(tradeCategoryId);
		}
		
		public bool HasRows(string tradeCategoryId)
		{
			return accessor.HasRows(tradeCategoryId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.TradeCategory GetById(string id)
		{
			return accessor.GetById(id);
		}
		
		public bool ExistsExcept(Model.TradeCategory e)
		{
			return accessor.ExistsExcept(e);
		}
		public bool HasRowsBefore(Model.TradeCategory e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.TradeCategory e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.TradeCategory GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.TradeCategory GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.TradeCategory GetPrev(Model.TradeCategory e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.TradeCategory GetNext(Model.TradeCategory e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.TradeCategory> Select()
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
		public IList<Model.TradeCategory> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}
