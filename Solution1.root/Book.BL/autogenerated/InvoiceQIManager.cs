﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceQIManager.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:01
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class InvoiceQIManager
    {
		///<summary>
		/// Data accessor of dbo.InvoiceQI
		///</summary>
		private static readonly DA.IInvoiceQIAccessor accessor = (DA.IInvoiceQIAccessor)Accessors.Get("InvoiceQIAccessor");
		
		
		public bool HasRows(string invoiceId)
		{
			return accessor.HasRows(invoiceId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool HasRowsBefore(Model.InvoiceQI e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.InvoiceQI e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.InvoiceQI GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.InvoiceQI GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.InvoiceQI GetPrev(Model.InvoiceQI e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.InvoiceQI GetNext(Model.InvoiceQI e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.InvoiceQI> Select()
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
		public IList<Model.InvoiceQI> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}