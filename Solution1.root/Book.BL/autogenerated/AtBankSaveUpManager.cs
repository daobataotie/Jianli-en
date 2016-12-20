﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtBankSaveUpManager.autogenerated.cs
// author: mayanjun
// create date：2011-3-3 14:30:18
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class AtBankSaveUpManager
    {
		///<summary>
		/// Data accessor of dbo.AtBankSaveUp
		///</summary>
		private static readonly DA.IAtBankSaveUpAccessor accessor = (DA.IAtBankSaveUpAccessor)Accessors.Get("AtBankSaveUpAccessor");
		
		/// <summary>
		/// Select by primary key.
		/// </summary>		
		public Model.AtBankSaveUp Get(string saveUpId)
		{
			return accessor.Get(saveUpId);
		}
		
		public bool HasRows(string saveUpId)
		{
			return accessor.HasRows(saveUpId);
		}
		
		public bool HasRows()
		{
			return accessor.HasRows();
		}
		
		public bool Exists(string id)
		{
			return accessor.Exists(id);
		}
		
		public Model.AtBankSaveUp GetById(string id)
		{
			return accessor.GetById(id);
		}		
		public bool ExistsExcept(Model.AtBankSaveUp e)
		{
			return accessor.ExistsExcept(e);
		}
		
		
		public bool HasRowsBefore(Model.AtBankSaveUp e)
		{
			return accessor.HasRowsBefore(e);
		}
		
		public bool HasRowsAfter(Model.AtBankSaveUp e)
		{
			return accessor.HasRowsAfter(e);
		}
		
		public Model.AtBankSaveUp GetFirst()
		{
			return accessor.GetFirst();
		}
		
		public Model.AtBankSaveUp GetLast()
		{
			return accessor.GetLast();
		}
		
		public Model.AtBankSaveUp GetPrev(Model.AtBankSaveUp e)
		{
			return accessor.GetPrev(e);
		}
		
		public Model.AtBankSaveUp GetNext(Model.AtBankSaveUp e)
		{
			return accessor.GetNext(e);
		}
		/// <summary>
		/// Select all.
		/// </summary>
		public IList<Model.AtBankSaveUp> Select()
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
		public IList<Model.AtBankSaveUp> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return accessor.Select(orderDescription, pagingDescription);
		}
		public bool ExistsPrimary(string id)
		{
		    return accessor.ExistsPrimary(id);	
	    }
		
    }
}