﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ShouldPayAccountDetail.autogenerated.cs
// author: mayanjun
// create date：2014/11/5 22:26:47
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class ShouldPayAccountDetail
	{
		#region Data

		/// <summary>
		/// 
		/// </summary>
		private string _shouldPayAccountDetailId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _shouldPayAccountId;
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime? _fPDate;
		
		/// <summary>
		/// 
		/// </summary>
		private string _fPId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _fPSupplierId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _fPHeader;
		
		/// <summary>
		/// 
		/// </summary>
		private decimal? _fPMoney;
		
		/// <summary>
		/// 
		/// </summary>
		private decimal? _fPTax;
		
		/// <summary>
		/// 
		/// </summary>
		private decimal? _fPTotalMoney;
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// 供应商
		/// </summary>
		private Supplier _fPSupplier;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 
		/// </summary>
		public string ShouldPayAccountDetailId
		{
			get 
			{
				return this._shouldPayAccountDetailId;
			}
			set 
			{
				this._shouldPayAccountDetailId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string ShouldPayAccountId
		{
			get 
			{
				return this._shouldPayAccountId;
			}
			set 
			{
				this._shouldPayAccountId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime? FPDate
		{
			get 
			{
				return this._fPDate;
			}
			set 
			{
				this._fPDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string FPId
		{
			get 
			{
				return this._fPId;
			}
			set 
			{
				this._fPId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string FPSupplierId
		{
			get 
			{
				return this._fPSupplierId;
			}
			set 
			{
				this._fPSupplierId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string FPHeader
		{
			get 
			{
				return this._fPHeader;
			}
			set 
			{
				this._fPHeader = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public decimal? FPMoney
		{
			get 
			{
				return this._fPMoney;
			}
			set 
			{
				this._fPMoney = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public decimal? FPTax
		{
			get 
			{
				return this._fPTax;
			}
			set 
			{
				this._fPTax = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public decimal? FPTotalMoney
		{
			get 
			{
				return this._fPTotalMoney;
			}
			set 
			{
				this._fPTotalMoney = value;
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
		/// 供应商
		/// </summary>
		public virtual Supplier FPSupplier
		{
			get
			{
				return this._fPSupplier;
			}
			set
			{
				this._fPSupplier = value;
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_ShouldPayAccountDetailId = "ShouldPayAccountDetailId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_ShouldPayAccountId = "ShouldPayAccountId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPDate = "FPDate";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPId = "FPId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPSupplierId = "FPSupplierId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPHeader = "FPHeader";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPMoney = "FPMoney";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPTax = "FPTax";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_FPTotalMoney = "FPTotalMoney";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_InsertTime = "InsertTime";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_UpdateTime = "UpdateTime";
		

		#endregion
	}
}