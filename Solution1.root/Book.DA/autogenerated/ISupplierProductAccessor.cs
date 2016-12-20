﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ISupplierProductAccessor.autogenerated.cs
// author: mayanjun
// create date：2012-8-30 17:02:24
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface ISupplierProductAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.SupplierProduct Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.SupplierProduct e);
		
		void Update(Model.SupplierProduct e);
		
		IList<Model.SupplierProduct> Select();
		
		IList<Model.SupplierProduct> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);
		bool HasRowsBefore(Model.SupplierProduct e);
		
		bool HasRowsAfter(Model.SupplierProduct e);
		
		Model.SupplierProduct GetFirst();
		
		Model.SupplierProduct GetLast();
		
		Model.SupplierProduct GetPrev(Model.SupplierProduct e);
		
		Model.SupplierProduct GetNext(Model.SupplierProduct e);

	}
}
