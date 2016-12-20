﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IProduceOtherReturnMaterialAccessor.autogenerated.cs
// author: mayanjun
// create date：2011-08-31 15:05:11
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IProduceOtherReturnMaterialAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.ProduceOtherReturnMaterial Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.ProduceOtherReturnMaterial e);
		
		void Update(Model.ProduceOtherReturnMaterial e);
		
		IList<Model.ProduceOtherReturnMaterial> Select();
		
		IList<Model.ProduceOtherReturnMaterial> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);
		bool HasRowsBefore(Model.ProduceOtherReturnMaterial e);
		
		bool HasRowsAfter(Model.ProduceOtherReturnMaterial e);
		
		Model.ProduceOtherReturnMaterial GetFirst();
		
		Model.ProduceOtherReturnMaterial GetLast();
		
		Model.ProduceOtherReturnMaterial GetPrev(Model.ProduceOtherReturnMaterial e);
		
		Model.ProduceOtherReturnMaterial GetNext(Model.ProduceOtherReturnMaterial e);

	}
}

