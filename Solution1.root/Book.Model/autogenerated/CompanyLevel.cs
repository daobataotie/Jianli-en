﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：CompanyLevel.autogenerated.cs
// author: peidun
// create date：2009-10-13 下午 05:12:55
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class CompanyLevel
	{
		#region Data

		/// <summary>
		/// 客户级别编号
		/// </summary>
		private string _companyLevelId;
		
		/// <summary>
		/// 插入时间
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 修改时间
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// 客户级别名称
		/// </summary>
		private string _companyLevelName;
		
		/// <summary>
		/// 客户级别货利率
		/// </summary>
		private double? _companyLevelProfitMargin;
		
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 客户级别编号
		/// </summary>
		public string CompanyLevelId
		{
			get 
			{
				return this._companyLevelId;
			}
			set 
			{
				this._companyLevelId = value;
			}
		}

		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime? InsertTime
		{
			get 
			{
				return this._insertTime;
			}
			set 
			{
				this._insertTime = value;
			}
		}

		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UpdateTime
		{
			get 
			{
				return this._updateTime;
			}
			set 
			{
				this._updateTime = value;
			}
		}

		/// <summary>
		/// 客户级别名称
		/// </summary>
		public string CompanyLevelName
		{
			get 
			{
				return this._companyLevelName;
			}
			set 
			{
				this._companyLevelName = value;
			}
		}

		/// <summary>
		/// 客户级别货利率
		/// </summary>
		public double? CompanyLevelProfitMargin
		{
			get 
			{
				return this._companyLevelProfitMargin;
			}
			set 
			{
				this._companyLevelProfitMargin = value;
			}
		}
	
		/// <summary>
		/// 客户级别编号
		/// </summary>
		public readonly static string PROPERTY_COMPANYLEVELID = "CompanyLevelId";
		
		/// <summary>
		/// 插入时间
		/// </summary>
		public readonly static string PROPERTY_INSERTTIME = "InsertTime";
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public readonly static string PROPERTY_UPDATETIME = "UpdateTime";
		
		/// <summary>
		/// 客户级别名称
		/// </summary>
		public readonly static string PROPERTY_COMPANYLEVELNAME = "CompanyLevelName";
		
		/// <summary>
		/// 客户级别货利率
		/// </summary>
		public readonly static string PROPERTY_COMPANYLEVELPROFITMARGIN = "CompanyLevelProfitMargin";
		

		#endregion
	}
}
