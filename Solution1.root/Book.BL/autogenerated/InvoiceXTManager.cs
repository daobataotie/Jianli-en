﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceXTManager.autogenerated.cs
// author: peidun
// create date：2009-10-28 16:07:29
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class InvoiceXTManager
    {
		///<summary>
		/// Data accessor of dbo.InvoiceXT
		///</summary>
		private static readonly DA.IInvoiceXTAccessor accessor = (DA.IInvoiceXTAccessor)Accessors.Get("InvoiceXTAccessor");
		
		
		public bool HasRows(string invoiceId)
		{
			return accessor.HasRows(invoiceId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool HasRowsBefore(Model.InvoiceXT e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.InvoiceXT e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.InvoiceXT GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.InvoiceXT GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.InvoiceXT GetPrev(Model.InvoiceXT e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.InvoiceXT GetNext(Model.InvoiceXT e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.InvoiceXT> Select()
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
		public IList<Model.InvoiceXT> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}