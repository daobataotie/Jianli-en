﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IAcInvoiceXOBillDetailAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-09-28 08:45:15
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IAcInvoiceXOBillDetailAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.AcInvoiceXOBillDetail Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.AcInvoiceXOBillDetail e);
		
		void Update(Model.AcInvoiceXOBillDetail e);
		
		IList<Model.AcInvoiceXOBillDetail> Select();
		
		IList<Model.AcInvoiceXOBillDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);

	}
}
