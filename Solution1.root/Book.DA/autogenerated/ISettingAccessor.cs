﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ISettingAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:03
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book.DA
{
    public partial interface ISettingAccessor
    {
        bool HasRows();
		
        bool HasRows(string id);
		
		Model.Setting Get(string id);
		
		void Delete(string id);
		
		int Count();
		
		void Insert(Model.Setting e);
		
		void Update(Model.Setting e);
		
		IList<Model.Setting> Select();
		
		IList<Model.Setting> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription);

	}
}

