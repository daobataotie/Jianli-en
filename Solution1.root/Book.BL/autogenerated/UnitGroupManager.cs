﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：UnitGroupManager.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:02
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class UnitGroupManager
    {
		///<summary>
		/// Data accessor of dbo.UnitGroup
		///</summary>
		private static readonly DA.IUnitGroupAccessor accessor = (DA.IUnitGroupAccessor)Accessors.Get("UnitGroupAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.UnitGroup Get(string unitGroupId)
		{
			return accessor.Get(unitGroupId);
		}
		
		public bool HasRows(string unitGroupId)
		{
			return accessor.HasRows(unitGroupId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.UnitGroup GetById(string id)
		{
			return accessor.GetById(id);
		}
		
		public bool ExistsExcept(Model.UnitGroup e)
		{
			return accessor.ExistsExcept(e);
		}
		public bool HasRowsBefore(Model.UnitGroup e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.UnitGroup e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.UnitGroup GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.UnitGroup GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.UnitGroup GetPrev(Model.UnitGroup e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.UnitGroup GetNext(Model.UnitGroup e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.UnitGroup> Select()
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
		public IList<Model.UnitGroup> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		
    }
}