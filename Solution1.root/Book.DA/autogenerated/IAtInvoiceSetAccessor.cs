﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IAtInvoiceSetAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-3-3 14:30:19
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IAtInvoiceSetAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.AtInvoiceSet Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.AtInvoiceSet e);
		
		void Update(Model.AtInvoiceSet e);
		
		IList<Model.AtInvoiceSet> Select();
		
		IList<Model.AtInvoiceSet> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);
		bool HasRowsBefore(Model.AtInvoiceSet e);
		
		bool HasRowsAfter(Model.AtInvoiceSet e);
		
		Model.AtInvoiceSet GetFirst();
		
		Model.AtInvoiceSet GetLast();
		
		Model.AtInvoiceSet GetPrev(Model.AtInvoiceSet e);
		
		Model.AtInvoiceSet GetNext(Model.AtInvoiceSet e);

		bool Exists(string id);
		
		Model.AtInvoiceSet GetById(string id);
		
		bool ExistsExcept(Model.AtInvoiceSet e);
		
	}
}
