﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：QualityTestPlanAccessor.autogenerated.cs
// author: peidun
// create date：2009-10-13 上午 11:45:04
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Book.DA.SQLServer
{
    public partial class QualityTestPlanAccessor
    {
		public Model.QualityTestPlan Get(string id)
		{
			return this.Get<Model.QualityTestPlan>(id);
		}
		
		public void Insert(Model.QualityTestPlan e)
		{
			this.Insert<Model.QualityTestPlan>(e);
		}
		
		public void Update(Model.QualityTestPlan e)
		{
			this.Update<Model.QualityTestPlan>(e);
		}
		
		public IList<Model.QualityTestPlan> Select()
		{
			return this.Select<Model.QualityTestPlan>();
		}
		
		public IList<Model.QualityTestPlan> Select(Helper.OrderDescription orderDescription, Helper.PagingDescription pagingDescription)
		{
			return this.Select<Model.QualityTestPlan>(orderDescription,pagingDescription);
		}
		public void Delete(string id)
		{
			this.Delete<Model.QualityTestPlan>(id);
		}
		public bool HasRows(string id)
		{
			return this.HasRows<Model.QualityTestPlan>(id);
		}
		public bool HasRows()
		{
			return this.HasRows<Model.QualityTestPlan>();
		}
		public int Count()
		{
			return this.Count<Model.QualityTestPlan>();
		}
		public bool HasRowsBefore(Model.QualityTestPlan e)
		{
			return sqlmapper.QueryForObject<bool>("QualityTestPlan.has_rows_before", e);
		}
		public bool HasRowsAfter(Model.QualityTestPlan e)
		{
			return sqlmapper.QueryForObject<bool>("QualityTestPlan.has_rows_after", e);
		}
		public Model.QualityTestPlan GetFirst()
		{
			return sqlmapper.QueryForObject<Model.QualityTestPlan>("QualityTestPlan.get_first", null);
		}
		public Model.QualityTestPlan GetLast()
		{
			return sqlmapper.QueryForObject<Model.QualityTestPlan>("QualityTestPlan.get_last", null);
		}
		public Model.QualityTestPlan GetNext(Model.QualityTestPlan e)
		{
			return sqlmapper.QueryForObject<Model.QualityTestPlan>("QualityTestPlan.get_next", e);
		}
		public Model.QualityTestPlan GetPrev(Model.QualityTestPlan e)
		{
			return sqlmapper.QueryForObject<Model.QualityTestPlan>("QualityTestPlan.get_prev", e);
		}
		

		public bool Exists(string id)
		{
			return sqlmapper.QueryForObject<bool>("QualityTestPlan.exists", id);
		}
		
		public Model.QualityTestPlan GetById(string id)
		{
			return sqlmapper.QueryForObject<Model.QualityTestPlan>("QualityTestPlan.get_by_id", id);
		}
		
		public bool ExistsExcept(Model.QualityTestPlan e)
		{
			Hashtable paras = new Hashtable();
			paras.Add("newId", e.Id);
            paras.Add("oldId", Get(e.QualityTestPlanId).Id);
			return sqlmapper.QueryForObject<bool>("QualityTestPlan.existsexcept", paras);
		}
    }
}
