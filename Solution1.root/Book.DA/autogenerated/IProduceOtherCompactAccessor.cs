﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IProduceOtherCompactAccessor.autogenerated.cs
// author: peidun
// create date：2010-1-4 16:17:51
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IProduceOtherCompactAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.ProduceOtherCompact Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.ProduceOtherCompact e);
		
		void Update(Model.ProduceOtherCompact e);
		
		IList<Model.ProduceOtherCompact> Select();
		
		IList<Model.ProduceOtherCompact> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		bool HasRowsBefore(Model.ProduceOtherCompact e);
		
		bool HasRowsAfter(Model.ProduceOtherCompact e);
		
		Model.ProduceOtherCompact GetFirst();
		
		Model.ProduceOtherCompact GetLast();
		
		Model.ProduceOtherCompact GetPrev(Model.ProduceOtherCompact e);
		
		Model.ProduceOtherCompact GetNext(Model.ProduceOtherCompact e);
        bool ExistsPrimary(string key);

	}
}
