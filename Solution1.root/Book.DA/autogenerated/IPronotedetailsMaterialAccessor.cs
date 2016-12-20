﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：IPronotedetailsMaterialAccessor.autogenerated.cs
// author: mayanjun
// create date：2010-9-15 10:11:07
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface IPronotedetailsMaterialAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.PronotedetailsMaterial Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.PronotedetailsMaterial e);
		
		void Update(Model.PronotedetailsMaterial e);
		
		IList<Model.PronotedetailsMaterial> Select();
		
		IList<Model.PronotedetailsMaterial> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);
		
		bool ExistsPrimary(string id);


    }
}
