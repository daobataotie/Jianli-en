﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IUnitGroupAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:03
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IUnitGroupAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.UnitGroup Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.UnitGroup e);
		
		void Update(Model.UnitGroup e);
		
		IList<Model.UnitGroup> Select();
		
		IList<Model.UnitGroup> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		bool HasRowsBefore(Model.UnitGroup e);
		
		bool HasRowsAfter(Model.UnitGroup e);
		
		Model.UnitGroup GetFirst();
		
		Model.UnitGroup GetLast();
		
		Model.UnitGroup GetPrev(Model.UnitGroup e);
		
		Model.UnitGroup GetNext(Model.UnitGroup e);

		bool Exists(string id);
		
		Model.UnitGroup GetById(string id);
		
		bool ExistsExcept(Model.UnitGroup e);
	}
}

