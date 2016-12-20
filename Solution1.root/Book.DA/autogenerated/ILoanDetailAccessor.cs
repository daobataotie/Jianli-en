﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ILoanDetailAccessor.autogenerated.cs
// author: peidun
// create date：2010-3-15 14:33:28
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface ILoanDetailAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.LoanDetail Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.LoanDetail e);
		
		void Update(Model.LoanDetail e);
		
		IList<Model.LoanDetail> Select();
		
		IList<Model.LoanDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);

	}
}
