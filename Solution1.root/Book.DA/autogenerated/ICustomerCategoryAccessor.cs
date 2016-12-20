﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ICustomerCategoryAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-26 下午 05:56:40
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface ICustomerCategoryAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.CustomerCategory Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.CustomerCategory e);
		
		void Update(Model.CustomerCategory e);
		
		IList<Model.CustomerCategory> Select();
		
		IList<Model.CustomerCategory> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		bool HasRowsBefore(Model.CustomerCategory e);
		
		bool HasRowsAfter(Model.CustomerCategory e);
		
		Model.CustomerCategory GetFirst();
		
		Model.CustomerCategory GetLast();
		
		Model.CustomerCategory GetPrev(Model.CustomerCategory e);
		
		Model.CustomerCategory GetNext(Model.CustomerCategory e);

		bool Exists(string id);
		
		Model.CustomerCategory GetById(string id);
		
		bool ExistsExcept(Model.CustomerCategory e);
	}
}
