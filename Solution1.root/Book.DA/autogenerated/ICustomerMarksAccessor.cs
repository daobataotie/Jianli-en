﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ICustomerMarksAccessor.autogenerated.cs
// author: mayanjun
// create date：2013-5-8 13:43:43
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface ICustomerMarksAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.CustomerMarks Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.CustomerMarks e);
		
		void Update(Model.CustomerMarks e);
		
		IList<Model.CustomerMarks> Select();
		
		IList<Model.CustomerMarks> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);

		bool Exists(string id);
		
		Model.CustomerMarks GetById(string id);
		
		bool ExistsExcept(Model.CustomerMarks e);
		
	}
}

