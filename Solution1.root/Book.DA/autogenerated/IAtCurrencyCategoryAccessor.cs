﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IAtCurrencyCategoryAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-6-8 10:03:41
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IAtCurrencyCategoryAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.AtCurrencyCategory Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.AtCurrencyCategory e);
		
		void Update(Model.AtCurrencyCategory e);
		
		IList<Model.AtCurrencyCategory> Select();
		
		IList<Model.AtCurrencyCategory> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);

		bool Exists(string id);
		
		Model.AtCurrencyCategory GetById(string id);
		
		bool ExistsExcept(Model.AtCurrencyCategory e);
		
	}
}

