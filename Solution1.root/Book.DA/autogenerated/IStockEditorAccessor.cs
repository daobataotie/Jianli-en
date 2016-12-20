﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IStockEditorAccessor.autogenerated.cs
// author: mayanjun
// create date：2010-11-4 11:02:32
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IStockEditorAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.StockEditor Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.StockEditor e);
		
		void Update(Model.StockEditor e);
		
		IList<Model.StockEditor> Select();
		
		IList<Model.StockEditor> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);
		bool HasRowsBefore(Model.StockEditor e);
		
		bool HasRowsAfter(Model.StockEditor e);
		
		Model.StockEditor GetFirst();
		
		Model.StockEditor GetLast();
		
		Model.StockEditor GetPrev(Model.StockEditor e);
		
		Model.StockEditor GetNext(Model.StockEditor e);

	}
}
