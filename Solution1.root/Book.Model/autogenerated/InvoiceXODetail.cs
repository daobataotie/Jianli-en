﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceXODetail.autogenerated.cs
// author: mayanjun
// create date：2011-11-25 10:02:04
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class InvoiceXODetail
    {
        #region Data

        /// <summary>
        /// 货品编号
        /// </summary>
        private string _invoiceXODetailId;

        /// <summary>
        /// 主键
        /// </summary>
        private string _primaryKeyId;

        /// <summary>
        /// 单据编号
        /// </summary>
        private string _invoiceId;

        /// <summary>
        /// 货品数量
        /// </summary>
        private double? _invoiceXODetailQuantity;

        /// <summary>
        /// 货品单价
        /// </summary>
        private decimal? _invoiceXODetailPrice;

        /// <summary>
        /// 货品金额
        /// </summary>
        private decimal? _invoiceXODetailMoney;

        /// <summary>
        /// 已出货数量
        /// </summary>
        private double? _invoiceXODetailBeenQuantity;

        /// <summary>
        /// 实际金额
        /// </summary>
        private decimal? _totalMoney;

        /// <summary>
        /// 未出货数量
        /// </summary>
        private double? _invoiceXODetailQuantity0;

        /// <summary>
        /// 标志
        /// </summary>
        private int? _detailsFlag;

        /// <summary>
        /// 备注
        /// </summary>
        private string _invoiceXODetailNote;

        /// <summary>
        /// 单位
        /// </summary>
        private string _invoiceProductUnit;

        /// <summary>
        /// 
        /// </summary>
        private bool? _isCustomerProduct;

        /// <summary>
        /// 
        /// </summary>
        private string _customerId;

        /// <summary>
        /// 产品编号
        /// </summary>
        private string _productId;

        /// <summary>
        /// 
        /// </summary>
        private double? _invoiceMPSQuantity;

        /// <summary>
        /// 
        /// </summary>
        private bool? _checkeds;

        /// <summary>
        /// 
        /// </summary>
        private double? _invoiceAllowance;

        /// <summary>
        /// 
        /// </summary>
        private bool? _islargess;

        /// <summary>
        /// 
        /// </summary>
        private int? _detailMPSState;

        /// <summary>
        /// 
        /// </summary>
        private int? _inumber;

        /// <summary>
        /// 是否核准商品
        /// </summary>
        private bool? _isConfirmed;

        /// <summary>
        /// 退货数量
        /// </summary>
        private double? _invoiceXTDetailQuantity;

        /// <summary>
        /// Remark
        /// </summary>
        private string _Remark;

        /// <summary>
        /// 需排单
        /// </summary>
        private bool _isNeedMPS;


        /// <summary>
        /// 客户
        /// </summary>
        private Customer _customer;
        /// <summary>
        /// 产品
        /// </summary>
        private Product _product;
        /// <summary>
        /// 客户产品
        /// </summary>
        private CustomerProducts _primaryKey;
        /// <summary>
        /// 销售订单
        /// </summary>
        private InvoiceXO _invoice;

        #endregion

        #region Properties

        /// <summary>
        /// 货品编号
        /// </summary>
        public string InvoiceXODetailId
        {
            get
            {
                return this._invoiceXODetailId;
            }
            set
            {
                this._invoiceXODetailId = value;
            }
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string PrimaryKeyId
        {
            get
            {
                return this._primaryKeyId;
            }
            set
            {
                this._primaryKeyId = value;
            }
        }

        /// <summary>
        /// 单据编号
        /// </summary>
        public string InvoiceId
        {
            get
            {
                return this._invoiceId;
            }
            set
            {
                this._invoiceId = value;
            }
        }

        /// <summary>
        /// 货品数量
        /// </summary>
        public double? InvoiceXODetailQuantity
        {
            get
            {
                return this._invoiceXODetailQuantity;
            }
            set
            {
                this._invoiceXODetailQuantity = value;
            }
        }

        /// <summary>
        /// 货品单价
        /// </summary>
        public decimal? InvoiceXODetailPrice
        {
            get
            {
                return this._invoiceXODetailPrice;
            }
            set
            {
                this._invoiceXODetailPrice = value;
            }
        }

        /// <summary>
        /// 货品金额
        /// </summary>
        public decimal? InvoiceXODetailMoney
        {
            get
            {
                return this._invoiceXODetailMoney;
            }
            set
            {
                this._invoiceXODetailMoney = value;
            }
        }

        /// <summary>
        /// 已出货数量
        /// </summary>
        public double? InvoiceXODetailBeenQuantity
        {
            get
            {
                return this._invoiceXODetailBeenQuantity;
            }
            set
            {
                this._invoiceXODetailBeenQuantity = value;
            }
        }

        /// <summary>
        /// 实际金额
        /// </summary>
        public decimal? TotalMoney
        {
            get
            {
                return this._totalMoney;
            }
            set
            {
                this._totalMoney = value;
            }
        }

        /// <summary>
        /// 未出货数量
        /// </summary>
        public double? InvoiceXODetailQuantity0
        {
            get
            {
                return this._invoiceXODetailQuantity0;
            }
            set
            {
                this._invoiceXODetailQuantity0 = value;
            }
        }

        /// <summary>
        /// 标志
        /// </summary>
        public int? DetailsFlag
        {
            get
            {
                return this._detailsFlag;
            }
            set
            {
                this._detailsFlag = value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string InvoiceXODetailNote
        {
            get
            {
                return this._invoiceXODetailNote;
            }
            set
            {
                this._invoiceXODetailNote = value;
            }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string InvoiceProductUnit
        {
            get
            {
                return this._invoiceProductUnit;
            }
            set
            {
                this._invoiceProductUnit = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsCustomerProduct
        {
            get
            {
                return this._isCustomerProduct;
            }
            set
            {
                this._isCustomerProduct = value;
            }
        }

        /// <summary>
        /// 
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
        /// 产品编号
        /// </summary>
        public string ProductId
        {
            get
            {
                return this._productId;
            }
            set
            {
                this._productId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceMPSQuantity
        {
            get
            {
                return this._invoiceMPSQuantity;
            }
            set
            {
                this._invoiceMPSQuantity = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool? Checkeds
        {
            get
            {
                return this._checkeds;
            }
            set
            {
                this._checkeds = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceAllowance
        {
            get
            {
                return this._invoiceAllowance;
            }
            set
            {
                this._invoiceAllowance = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool? Islargess
        {
            get
            {
                return this._islargess;
            }
            set
            {
                this._islargess = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? DetailMPSState
        {
            get
            {
                return this._detailMPSState;
            }
            set
            {
                this._detailMPSState = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? Inumber
        {
            get
            {
                return this._inumber;
            }
            set
            {
                this._inumber = value;
            }
        }

        /// <summary>
        /// 是否核准商品
        /// </summary>
        public bool? IsConfirmed
        {
            get
            {
                return this._isConfirmed;
            }
            set
            {
                this._isConfirmed = value;
            }
        }

        /// <summary>
        /// 退货数量
        /// </summary>
        public double? InvoiceXTDetailQuantity
        {
            get
            {
                return this._invoiceXTDetailQuantity;
            }
            set
            {
                this._invoiceXTDetailQuantity = value;
            }
        }

        /// <summary>
        /// Remark
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        /// <summary>
        /// 需排单
        /// </summary>
        public bool IsNeedMPS
        {
            get { return _isNeedMPS; }
            set { _isNeedMPS = value; }
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
        /// 产品
        /// </summary>
        public virtual Product Product
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
            }

        }
        /// <summary>
        /// 客户产品
        /// </summary>
        public virtual CustomerProducts PrimaryKey
        {
            get
            {
                return this._primaryKey;
            }
            set
            {
                this._primaryKey = value;
            }

        }
        /// <summary>
        /// 销售订单
        /// </summary>
        public virtual InvoiceXO Invoice
        {
            get
            {
                return this._invoice;
            }
            set
            {
                this._invoice = value;
            }

        }
        /// <summary>
        /// 货品编号
        /// </summary>
        public readonly static string PRO_InvoiceXODetailId = "InvoiceXODetailId";

        /// <summary>
        /// 主键
        /// </summary>
        public readonly static string PRO_PrimaryKeyId = "PrimaryKeyId";

        /// <summary>
        /// 单据编号
        /// </summary>
        public readonly static string PRO_InvoiceId = "InvoiceId";

        /// <summary>
        /// 货品数量
        /// </summary>
        public readonly static string PRO_InvoiceXODetailQuantity = "InvoiceXODetailQuantity";

        /// <summary>
        /// 货品单价
        /// </summary>
        public readonly static string PRO_InvoiceXODetailPrice = "InvoiceXODetailPrice";

        /// <summary>
        /// 货品金额
        /// </summary>
        public readonly static string PRO_InvoiceXODetailMoney = "InvoiceXODetailMoney";

        /// <summary>
        /// 已出货数量
        /// </summary>
        public readonly static string PRO_InvoiceXODetailBeenQuantity = "InvoiceXODetailBeenQuantity";

        /// <summary>
        /// 实际金额
        /// </summary>
        public readonly static string PRO_TotalMoney = "TotalMoney";

        /// <summary>
        /// 未出货数量
        /// </summary>
        public readonly static string PRO_InvoiceXODetailQuantity0 = "InvoiceXODetailQuantity0";

        /// <summary>
        /// 标志
        /// </summary>
        public readonly static string PRO_DetailsFlag = "DetailsFlag";

        /// <summary>
        /// 备注
        /// </summary>
        public readonly static string PRO_InvoiceXODetailNote = "InvoiceXODetailNote";

        /// <summary>
        /// 单位
        /// </summary>
        public readonly static string PRO_InvoiceProductUnit = "InvoiceProductUnit";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_IsCustomerProduct = "IsCustomerProduct";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_CustomerId = "CustomerId";

        /// <summary>
        /// 产品编号
        /// </summary>
        public readonly static string PRO_ProductId = "ProductId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_InvoiceMPSQuantity = "InvoiceMPSQuantity";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Checkeds = "Checkeds";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_InvoiceAllowance = "InvoiceAllowance";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Islargess = "Islargess";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_DetailMPSState = "DetailMPSState";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Inumber = "Inumber";

        /// <summary>
        /// 是否核准商品
        /// </summary>
        public readonly static string PRO_IsConfirmed = "IsConfirmed";

        /// <summary>
        /// 退货数量
        /// </summary>
        public readonly static string PRO_InvoiceXTDetailQuantity = "InvoiceXTDetailQuantity";

        /// <summary>
        /// Remark
        /// </summary>
        public readonly static string PRO_Remark = "Remark";

        /// <summary>
        /// 需排单
        /// </summary>
        public readonly static string PRO_IsNeedMPS = "IsNeedMPS";
        #endregion
    }
}
