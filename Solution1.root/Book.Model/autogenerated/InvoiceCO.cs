﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceCO.autogenerated.cs
// author: mayanjun
// create date：2012-04-10 15:02:02
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class InvoiceCO
	{
		#region Data

		/// <summary>
		/// 供应商编号
		/// </summary>
		private string _supplierId;
		
		/// <summary>
		/// 采购订单总额
		/// </summary>
		private decimal? _invoiceTotal;
		
		/// <summary>
		/// 预交日期
		/// </summary>
		private DateTime? _invoiceYjrq;
		
		/// <summary>
		/// 采订税率
		/// </summary>
		private double? _invoiceTaxrate;
		
		/// <summary>
		/// 采订税额
		/// </summary>
		private decimal? _invoiceTax;
		
		/// <summary>
		/// 订单合计
		/// </summary>
		private decimal? _invoiceHeji;
		
		/// <summary>
		/// 折让额
		/// </summary>
		private decimal? _invoiceDiscount;
		
		/// <summary>
		/// 应付款
		/// </summary>
		private decimal? _invoicePayable;
		
		/// <summary>
		/// 付款日期
		/// </summary>
		private DateTime? _invoicePayDate;
		
		/// <summary>
		/// 传票编号
		/// </summary>
		private string _invoiceCPBH;
		
		/// <summary>
		/// 课税类别
		/// </summary>
		private string _invoiceKSLB;
		
		/// <summary>
		/// 开立方式
		/// </summary>
		private string _invoiceKLFS;
		
		/// <summary>
		/// 发票编号
		/// </summary>
		private string _invoiceFPBH;
		
		/// <summary>
		/// 开票联式
		/// </summary>
		private string _invoiceKPLS;
		
		/// <summary>
		/// 发票金额
		/// </summary>
		private decimal? _invoiceFPJE;
		
		/// <summary>
		/// 税率计算方式
		/// </summary>
		private int? _taxCaluType;
		
		/// <summary>
		/// 订单标志
		/// </summary>
		private int? _invoiceFlag;
		
		/// <summary>
		/// 发票日期
		/// </summary>
		private DateTime? _invoiceFPDate;
		
		/// <summary>
		/// 
		/// </summary>
		private string _invoiceXOId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _mRSHeaderId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _invoiceCustomXOId;
		
		/// <summary>
		/// 客户
		/// </summary>
		private string _customerId;
		
		/// <summary>
		/// 
		/// </summary>
		private bool? _isClose;
		
		/// <summary>
		/// 
		/// </summary>
		private string _supplierLotNumber;
		
		/// <summary>
		/// 客户
		/// </summary>
		private Customer _customer;
		/// <summary>
		/// 供应商
		/// </summary>
		private Supplier _supplier;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string SupplierId
		{
			get 
			{
				return this._supplierId;
			}
			set 
			{
				this._supplierId = value;
			}
		}

		/// <summary>
		/// 采购订单总额
		/// </summary>
		public decimal? InvoiceTotal
		{
			get 
			{
				return this._invoiceTotal;
			}
			set 
			{
				this._invoiceTotal = value;
			}
		}

		/// <summary>
		/// 预交日期
		/// </summary>
		public DateTime? InvoiceYjrq
		{
			get 
			{
				return this._invoiceYjrq;
			}
			set 
			{
				this._invoiceYjrq = value;
			}
		}

		/// <summary>
		/// 采订税率
		/// </summary>
		public double? InvoiceTaxrate
		{
			get 
			{
				return this._invoiceTaxrate;
			}
			set 
			{
				this._invoiceTaxrate = value;
			}
		}

		/// <summary>
		/// 采订税额
		/// </summary>
		public decimal? InvoiceTax
		{
			get 
			{
				return this._invoiceTax;
			}
			set 
			{
				this._invoiceTax = value;
			}
		}

		/// <summary>
		/// 订单合计
		/// </summary>
		public decimal? InvoiceHeji
		{
			get 
			{
				return this._invoiceHeji;
			}
			set 
			{
				this._invoiceHeji = value;
			}
		}

		/// <summary>
		/// 折让额
		/// </summary>
		public decimal? InvoiceDiscount
		{
			get 
			{
				return this._invoiceDiscount;
			}
			set 
			{
				this._invoiceDiscount = value;
			}
		}

		/// <summary>
		/// 应付款
		/// </summary>
		public decimal? InvoicePayable
		{
			get 
			{
				return this._invoicePayable;
			}
			set 
			{
				this._invoicePayable = value;
			}
		}

		/// <summary>
		/// 付款日期
		/// </summary>
		public DateTime? InvoicePayDate
		{
			get 
			{
				return this._invoicePayDate;
			}
			set 
			{
				this._invoicePayDate = value;
			}
		}

		/// <summary>
		/// 传票编号
		/// </summary>
		public string InvoiceCPBH
		{
			get 
			{
				return this._invoiceCPBH;
			}
			set 
			{
				this._invoiceCPBH = value;
			}
		}

		/// <summary>
		/// 课税类别
		/// </summary>
		public string InvoiceKSLB
		{
			get 
			{
				return this._invoiceKSLB;
			}
			set 
			{
				this._invoiceKSLB = value;
			}
		}

		/// <summary>
		/// 开立方式
		/// </summary>
		public string InvoiceKLFS
		{
			get 
			{
				return this._invoiceKLFS;
			}
			set 
			{
				this._invoiceKLFS = value;
			}
		}

		/// <summary>
		/// 发票编号
		/// </summary>
		public string InvoiceFPBH
		{
			get 
			{
				return this._invoiceFPBH;
			}
			set 
			{
				this._invoiceFPBH = value;
			}
		}

		/// <summary>
		/// 开票联式
		/// </summary>
		public string InvoiceKPLS
		{
			get 
			{
				return this._invoiceKPLS;
			}
			set 
			{
				this._invoiceKPLS = value;
			}
		}

		/// <summary>
		/// 发票金额
		/// </summary>
		public decimal? InvoiceFPJE
		{
			get 
			{
				return this._invoiceFPJE;
			}
			set 
			{
				this._invoiceFPJE = value;
			}
		}

		/// <summary>
		/// 税率计算方式
		/// </summary>
		public int? TaxCaluType
		{
			get 
			{
				return this._taxCaluType;
			}
			set 
			{
				this._taxCaluType = value;
			}
		}

		/// <summary>
		/// 订单标志
		/// </summary>
		public int? InvoiceFlag
		{
			get 
			{
				return this._invoiceFlag;
			}
			set 
			{
				this._invoiceFlag = value;
			}
		}

		/// <summary>
		/// 发票日期
		/// </summary>
		public DateTime? InvoiceFPDate
		{
			get 
			{
				return this._invoiceFPDate;
			}
			set 
			{
				this._invoiceFPDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string InvoiceXOId
		{
			get 
			{
				return this._invoiceXOId;
			}
			set 
			{
				this._invoiceXOId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string MRSHeaderId
		{
			get 
			{
				return this._mRSHeaderId;
			}
			set 
			{
				this._mRSHeaderId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string InvoiceCustomXOId
		{
			get 
			{
				return this._invoiceCustomXOId;
			}
			set 
			{
				this._invoiceCustomXOId = value;
			}
		}

		/// <summary>
		/// 客户
		/// </summary>
		public string CustomerId
		{
			get 
			{
				return this._customerId;
			}
			set 
			{
				this._customerId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool? IsClose
		{
			get 
			{
				return this._isClose;
			}
			set 
			{
				this._isClose = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string SupplierLotNumber
		{
			get 
			{
				return this._supplierLotNumber;
			}
			set 
			{
				this._supplierLotNumber = value;
			}
		}
	
		/// <summary>
		/// 客户
		/// </summary>
		public virtual Customer Customer
		{
			get
			{
				return this._customer;
			}
			set
			{
				this._customer = value;
			}
			
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public virtual Supplier Supplier
		{
			get
			{
				return this._supplier;
			}
			set
			{
				this._supplier = value;
			}
			
		}
        /// <summary>
        /// 币种类别
        /// </summary>
        public virtual AtCurrencyCategory AtCurrencyCategory
        {
            get
            {
                return this._atCurrencyCategory;
            }
            set
            {
                this._atCurrencyCategory = value;
            }

        }
        	/// <summary>
		/// 币种类别
		/// </summary>
		private AtCurrencyCategory _atCurrencyCategory;
        /// <summary>
        /// 
        /// </summary>
        private string _atCurrencyCategoryId;
        /// <summary>
		/// 
		/// </summary>
		public string AtCurrencyCategoryId
		{
			get 
			{
				return this._atCurrencyCategoryId;
			}
			set 
			{
				this._atCurrencyCategoryId = value;
			}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public readonly static string PRO_SupplierId = "SupplierId";
		
		/// <summary>
		/// 采购订单总额
		/// </summary>
		public readonly static string PRO_InvoiceTotal = "InvoiceTotal";
		
		/// <summary>
		/// 预交日期
		/// </summary>
		public readonly static string PRO_InvoiceYjrq = "InvoiceYjrq";
		
		/// <summary>
		/// 采订税率
		/// </summary>
		public readonly static string PRO_InvoiceTaxrate = "InvoiceTaxrate";
		
		/// <summary>
		/// 采订税额
		/// </summary>
		public readonly static string PRO_InvoiceTax = "InvoiceTax";
		
		/// <summary>
		/// 订单合计
		/// </summary>
		public readonly static string PRO_InvoiceHeji = "InvoiceHeji";
		
		/// <summary>
		/// 折让额
		/// </summary>
		public readonly static string PRO_InvoiceDiscount = "InvoiceDiscount";
		
		/// <summary>
		/// 应付款
		/// </summary>
		public readonly static string PRO_InvoicePayable = "InvoicePayable";
		
		/// <summary>
		/// 付款日期
		/// </summary>
		public readonly static string PRO_InvoicePayDate = "InvoicePayDate";
		
		/// <summary>
		/// 传票编号
		/// </summary>
		public readonly static string PRO_InvoiceCPBH = "InvoiceCPBH";
		
		/// <summary>
		/// 课税类别
		/// </summary>
		public readonly static string PRO_InvoiceKSLB = "InvoiceKSLB";
		
		/// <summary>
		/// 开立方式
		/// </summary>
		public readonly static string PRO_InvoiceKLFS = "InvoiceKLFS";
		
		/// <summary>
		/// 发票编号
		/// </summary>
		public readonly static string PRO_InvoiceFPBH = "InvoiceFPBH";
		
		/// <summary>
		/// 开票联式
		/// </summary>
		public readonly static string PRO_InvoiceKPLS = "InvoiceKPLS";
		
		/// <summary>
		/// 发票金额
		/// </summary>
		public readonly static string PRO_InvoiceFPJE = "InvoiceFPJE";
		
		/// <summary>
		/// 税率计算方式
		/// </summary>
		public readonly static string PRO_TaxCaluType = "TaxCaluType";
		
		/// <summary>
		/// 订单标志
		/// </summary>
		public readonly static string PRO_InvoiceFlag = "InvoiceFlag";
		
		/// <summary>
		/// 发票日期
		/// </summary>
		public readonly static string PRO_InvoiceFPDate = "InvoiceFPDate";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_InvoiceXOId = "InvoiceXOId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_MRSHeaderId = "MRSHeaderId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_InvoiceCustomXOId = "InvoiceCustomXOId";
		
		/// <summary>
		/// 客户
		/// </summary>
		public readonly static string PRO_CustomerId = "CustomerId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_IsClose = "IsClose";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_SupplierLotNumber = "SupplierLotNumber";
		
        /// <summary>
		/// 
		/// </summary>
        public readonly static string PRO_AtCurrencyCategoryId = "AtCurrencyCategoryId";
		#endregion
	}
}