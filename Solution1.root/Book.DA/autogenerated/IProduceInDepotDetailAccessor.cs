﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IProduceInDepotDetailAccessor.autogenerated.cs
// author: peidun
// create date：2010-1-8 13:43:35
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IProduceInDepotDetailAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.ProduceInDepotDetail Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.ProduceInDepotDetail e);
		
		void Update(Model.ProduceInDepotDetail e);
		
		IList<Model.ProduceInDepotDetail> Select();
		
		IList<Model.ProduceInDepotDetail> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);

	}
}

