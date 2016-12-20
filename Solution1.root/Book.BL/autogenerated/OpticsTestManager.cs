﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：OpticsTestManager.autogenerated.cs
// author: mayanjun
// create date：2012-4-21 09:55:31
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class OpticsTestManager
    {
		///<summary>
		/// Data accessor of dbo.OpticsTest
		///</summary>
		private static readonly DA.IOpticsTestAccessor accessor = (DA.IOpticsTestAccessor)Accessors.Get("OpticsTestAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.OpticsTest Get(string opticsTestId)
		{
			return accessor.Get(opticsTestId);
		}
		
		public bool HasRows(string opticsTestId)
		{
			return accessor.HasRows(opticsTestId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool HasRowsBefore(Model.OpticsTest e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.OpticsTest e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.OpticsTest GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.OpticsTest GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.OpticsTest GetPrev(Model.OpticsTest e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.OpticsTest GetNext(Model.OpticsTest e)
		{
			return accessor.GetNext(e);
		}

		public IList<Model.OpticsTest> Select()
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
		public IList<Model.OpticsTest> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
        public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}