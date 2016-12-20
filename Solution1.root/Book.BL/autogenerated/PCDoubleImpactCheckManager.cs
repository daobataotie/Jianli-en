﻿//------------------------------------------------------------------------------
//
// 说明：该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCDoubleImpactCheckManager.autogenerated.cs
// author: mayanjun
// create date：2011-11-24 17:38:15
//
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Book.BL
{
    public partial class PCDoubleImpactCheckManager
    {
        ///<summary>
        /// Data accessor of dbo.PCDoubleImpactCheck
        ///</summary>
        private static readonly DA.IPCDoubleImpactCheckAccessor accessor = (DA.IPCDoubleImpactCheckAccessor)Accessors.Get("PCDoubleImpactCheckAccessor");

        /// <summary>
        /// Select by primary key.
        /// </summary>		
        public Model.PCDoubleImpactCheck Get(string pCDoubleImpactCheckID)
        {
            return accessor.Get(pCDoubleImpactCheckID);
        }

        public bool HasRows(string pCDoubleImpactCheckID)
        {
            return accessor.HasRows(pCDoubleImpactCheckID);
        }

        public bool HasRows(int PCDoubleImpactCheckType)
        {
            return accessor.HasRows(PCDoubleImpactCheckType);
        }

        public bool HasRowsBefore(Model.PCDoubleImpactCheck e)
        {
            return accessor.HasRowsBefore(e);
        }

        public bool HasRowsAfter(Model.PCDoubleImpactCheck e)
        {
            return accessor.HasRowsAfter(e);
        }

        public Model.PCDoubleImpactCheck GetFirst(int PCDoubleImpactCheckType)
        {
            return accessor.GetFirst(PCDoubleImpactCheckType);
        }

        public Model.PCDoubleImpactCheck GetLast(int PCDoubleImpactCheckType)
        {
            return accessor.GetLast(PCDoubleImpactCheckType);
        }

        public Model.PCDoubleImpactCheck GetPrev(Model.PCDoubleImpactCheck e)
        {
            return accessor.GetPrev(e);
        }

        public Model.PCDoubleImpactCheck GetNext(Model.PCDoubleImpactCheck e)
        {
            return accessor.GetNext(e);
        }
        /// <summary>
        /// Select all.
        /// </summary>
        public IList<Model.PCDoubleImpactCheck> Select()
        {
            return accessor.Select();
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Count()
        {
            return accessor.Count();
        }

        /// <summary>
        /// 获取指定状态、指定分页，并按指定要求排序的记录
        /// </summary>
        public IList<Model.PCDoubleImpactCheck> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
        {
            return accessor.Select(orderDescription, pagingDescription);
        }
        public bool ExistsPrimary(string id)
        {
            return accessor.ExistsPrimary(id);
        }

    }
}