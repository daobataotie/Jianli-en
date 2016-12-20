﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IShouldPayAccountAccessor.autogenerated.cs
// author: mayanjun
// create date：2014/8/11 19:47:22
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IShouldPayAccountAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.ShouldPayAccount Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.ShouldPayAccount e);
		
		void Update(Model.ShouldPayAccount e);
		
		IList<Model.ShouldPayAccount> Select();
		
		IList<Model.ShouldPayAccount> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);
		bool HasRowsBefore(Model.ShouldPayAccount e);
		
		bool HasRowsAfter(Model.ShouldPayAccount e);
		
		Model.ShouldPayAccount GetFirst();
		
		Model.ShouldPayAccount GetLast();
		
		Model.ShouldPayAccount GetPrev(Model.ShouldPayAccount e);
		
		Model.ShouldPayAccount GetNext(Model.ShouldPayAccount e);

	}
}
