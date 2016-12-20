﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProductMouldTestDetail.autogenerated.cs
// author: mayanjun
// create date：2010-10-4 15:01:19
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class ProductMouldTestDetail
	{
		#region Data

		/// <summary>
		/// 
		/// </summary>
		private string _productMouldTestDetailId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _mouldId;
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// 
		/// </summary>
		private string _productMouldTestId;
		
		/// <summary>
		/// 产品模具
		/// </summary>
		private ProductMould _mould;
		/// <summary>
		/// 模具试模
		/// </summary>
		private ProductMouldTest _productMouldTest;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 
		/// </summary>
		public string ProductMouldTestDetailId
		{
			get 
			{
				return this._productMouldTestDetailId;
			}
			set 
			{
				this._productMouldTestDetailId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string MouldId
		{
			get 
			{
				return this._mouldId;
			}
			set 
			{
				this._mouldId = value;
			}
		}

		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		public string ProductMouldTestId
		{
			get 
			{
				return this._productMouldTestId;
			}
			set 
			{
				this._productMouldTestId = value;
			}
		}
	
		/// <summary>
		/// 产品模具
		/// </summary>
		public virtual ProductMould Mould
		{
			get
			{
				return this._mould;
			}
			set
			{
				this._mould = value;
			}
			
		}
		/// <summary>
		/// 模具试模
		/// </summary>
		public virtual ProductMouldTest ProductMouldTest
		{
			get
			{
				return this._productMouldTest;
			}
			set
			{
				this._productMouldTest = value;
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_PRODUCTMOULDTESTDETAILID = "ProductMouldTestDetailId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_MOULDID = "MouldId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_INSERTTIME = "InsertTime";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_UPDATETIME = "UpdateTime";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_PRODUCTMOULDTESTID = "ProductMouldTestId";
		

		#endregion
	}
}