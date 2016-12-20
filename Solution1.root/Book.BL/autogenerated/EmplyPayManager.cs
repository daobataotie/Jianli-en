﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：EmplyPayManager.autogenerated.cs
// author: peidun
// create date：2010-3-24 11:21:40
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class EmplyPayManager
    {
		///<summary>
		/// Data accessor of dbo.EmplyPay
		///</summary>
		private static readonly DA.IEmplyPayAccessor accessor = (DA.IEmplyPayAccessor)Accessors.Get("EmplyPayAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.EmplyPay Get(string emplyPayId)
		{
			return accessor.Get(emplyPayId);
		}
		
		public bool HasRows(string emplyPayId)
		{
			return accessor.HasRows(emplyPayId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool HasRowsBefore(Model.EmplyPay e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.EmplyPay e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.EmplyPay GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.EmplyPay GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.EmplyPay GetPrev(Model.EmplyPay e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.EmplyPay GetNext(Model.EmplyPay e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.EmplyPay> Select()
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
		public IList<Model.EmplyPay> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}