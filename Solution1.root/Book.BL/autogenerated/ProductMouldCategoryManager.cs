﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductMouldCategoryManager.autogenerated.cs
// author: mayanjun
// create date：2013-3-7 14:17:18
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class ProductMouldCategoryManager
    {
		///<summary>
		/// Data accessor of dbo.ProductMouldCategory
		///</summary>
		private static readonly DA.IProductMouldCategoryAccessor accessor = (DA.IProductMouldCategoryAccessor)Accessors.Get("ProductMouldCategoryAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.ProductMouldCategory Get(string productMouldCategoryId)
		{
			return accessor.Get(productMouldCategoryId);
		}
		
		public bool HasRows(string productMouldCategoryId)
		{
			return accessor.HasRows(productMouldCategoryId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.ProductMouldCategory GetById(string id)
		{
			return accessor.GetById(id);
		}		
		public bool ExistsExcept(Model.ProductMouldCategory e)
		{
			return accessor.ExistsExcept(e);
		}
		
		
		public bool HasRowsBefore(Model.ProductMouldCategory e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.ProductMouldCategory e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.ProductMouldCategory GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.ProductMouldCategory GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.ProductMouldCategory GetPrev(Model.ProductMouldCategory e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.ProductMouldCategory GetNext(Model.ProductMouldCategory e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.ProductMouldCategory> Select()
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
		public IList<Model.ProductMouldCategory> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}