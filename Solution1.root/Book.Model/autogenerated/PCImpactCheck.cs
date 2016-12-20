﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：PCImpactCheck.autogenerated.cs
// author: mayanjun
// create date：2011-12-29 09:25:29
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class PCImpactCheck
    {
        #region Data

        /// <summary>
        /// 主键编号
        /// </summary>
        private string _pCImpactCheckId;

        /// <summary>
        /// 工作中心编号
        /// </summary>
        private string _workHouseId;

        /// <summary>
        /// 编号
        /// </summary>
        private string _employeeId;

        /// <summary>
        /// 商品编号
        /// </summary>
        private string _productId;

        /// <summary>
        /// 插入时间
        /// </summary>
        private DateTime? _insertTime;

        /// <summary>
        /// 修改时间
        /// </summary>
        private DateTime? _updateTime;

        /// <summary>
        /// 测试日期
        /// </summary>
        private DateTime? _pCImpactCheckDate;

        /// <summary>
        /// 抽检数量
        /// </summary>
        private int? _pCImpactCheckQuantity;

        /// <summary>
        /// 客户订单编号
        /// </summary>
        private string _invoiceCusXOId;

        /// <summary>
        /// 加工单编号
        /// </summary>
        private string _pronoteHeaderId;

        /// <summary>
        /// 备注
        /// </summary>
        private string _pCImpactCheckDesc;

        /// <summary>
        /// 
        /// </summary>
        private int? _pCFromType;

        /// <summary>
        /// 
        /// </summary>
        private string _mCheckStandard;

        /// <summary>
        /// 客户订单数量
        /// </summary>
        private double? _invoiceXOQuantity;

        private int? _auditState;

        private string _auditEmpId;

        private string _ProductUnitId;

        private Employee _auditEmp;

        /// <summary>
        /// 员工
        /// </summary>
        private Employee _employee;
        /// <summary>
        /// 产品
        /// </summary>
        private Product _product;
        /// <summary>
        /// 工作中心
        /// </summary>
        private WorkHouse _workHouse;

        private ProductUnit _ProductUnit;
        #endregion

        #region Properties

        /// <summary>
        /// 主键编号
        /// </summary>
        public string PCImpactCheckId
        {
            get
            {
                return this._pCImpactCheckId;
            }
            set
            {
                this._pCImpactCheckId = value;
            }
        }

        /// <summary>
        /// 工作中心编号
        /// </summary>
        public string WorkHouseId
        {
            get
            {
                return this._workHouseId;
            }
            set
            {
                this._workHouseId = value;
            }
        }

        /// <summary>
        /// 编号
        /// </summary>
        public string EmployeeId
        {
            get
            {
                return this._employeeId;
            }
            set
            {
                this._employeeId = value;
            }
        }

        /// <summary>
        /// 商品编号
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
        /// 测试日期
        /// </summary>
        public DateTime? PCImpactCheckDate
        {
            get
            {
                return this._pCImpactCheckDate;
            }
            set
            {
                this._pCImpactCheckDate = value;
            }
        }

        /// <summary>
        /// 抽检数量
        /// </summary>
        public int? PCImpactCheckQuantity
        {
            get
            {
                return this._pCImpactCheckQuantity;
            }
            set
            {
                this._pCImpactCheckQuantity = value;
            }
        }

        /// <summary>
        /// 客户订单编号
        /// </summary>
        public string InvoiceCusXOId
        {
            get
            {
                return this._invoiceCusXOId;
            }
            set
            {
                this._invoiceCusXOId = value;
            }
        }

        /// <summary>
        /// 加工单编号
        /// </summary>
        public string PronoteHeaderId
        {
            get
            {
                return this._pronoteHeaderId;
            }
            set
            {
                this._pronoteHeaderId = value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string PCImpactCheckDesc
        {
            get
            {
                return this._pCImpactCheckDesc;
            }
            set
            {
                this._pCImpactCheckDesc = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? PCFromType
        {
            get
            {
                return this._pCFromType;
            }
            set
            {
                this._pCFromType = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string mCheckStandard
        {
            get
            {
                return this._mCheckStandard;
            }
            set
            {
                this._mCheckStandard = value;
            }
        }

        /// <summary>
        /// 客户订单数量
        /// </summary>
        public double? InvoiceXOQuantity
        {
            get
            {
                return this._invoiceXOQuantity;
            }
            set
            {
                this._invoiceXOQuantity = value;
            }
        }
        public int? AuditState
        {
            get
            {
                return this._auditState;
            }
            set
            {
                this._auditState = value;
            }
        }

        public virtual string AuditEmpId
        {
            get
            {
                return this._auditEmpId;

            }
            set
            {
                this._auditEmpId = value;
            }
        }

        public string ProductUnitId
        {
            get { return _ProductUnitId; }
            set { _ProductUnitId = value; }
        }

        public virtual Employee AuditEmp
        {
            get
            {
                return this._auditEmp;
            }
            set
            {
                this._auditEmp = value;
            }

        }

        /// <summary>
        /// 员工
        /// </summary>
        public virtual Employee Employee
        {
            get
            {
                return this._employee;
            }
            set
            {
                this._employee = value;
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
        /// 工作中心
        /// </summary>
        public virtual WorkHouse WorkHouse
        {
            get
            {
                return this._workHouse;
            }
            set
            {
                this._workHouse = value;
            }

        }

        public ProductUnit ProductUnit
        {
            get { return _ProductUnit; }
            set { _ProductUnit = value; }
        }
        /// <summary>
        /// 主键编号
        /// </summary>
        public readonly static string PRO_PCImpactCheckId = "PCImpactCheckId";

        /// <summary>
        /// 工作中心编号
        /// </summary>
        public readonly static string PRO_WorkHouseId = "WorkHouseId";

        /// <summary>
        /// 编号
        /// </summary>
        public readonly static string PRO_EmployeeId = "EmployeeId";

        /// <summary>
        /// 商品编号
        /// </summary>
        public readonly static string PRO_ProductId = "ProductId";

        /// <summary>
        /// 插入时间
        /// </summary>
        public readonly static string PRO_InsertTime = "InsertTime";

        /// <summary>
        /// 修改时间
        /// </summary>
        public readonly static string PRO_UpdateTime = "UpdateTime";

        /// <summary>
        /// 测试日期
        /// </summary>
        public readonly static string PRO_PCImpactCheckDate = "PCImpactCheckDate";

        /// <summary>
        /// 抽检数量
        /// </summary>
        public readonly static string PRO_PCImpactCheckQuantity = "PCImpactCheckQuantity";

        /// <summary>
        /// 客户订单编号
        /// </summary>
        public readonly static string PRO_InvoiceCusXOId = "InvoiceCusXOId";

        /// <summary>
        /// 加工单编号
        /// </summary>
        public readonly static string PRO_PronoteHeaderId = "PronoteHeaderId";

        /// <summary>
        /// 备注
        /// </summary>
        public readonly static string PRO_PCImpactCheckDesc = "PCImpactCheckDesc";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_PCFromType = "PCFromType";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_mCheckStandard = "mCheckStandard";

        /// <summary>
        /// 客户订单数量
        /// </summary>
        public readonly static string PRO_InvoiceXOQuantity = "InvoiceXOQuantity";

        public readonly static string PRO_AuditState = "AuditState";

        public readonly static string PRO_AuditEmpId = "AuditEmpId";

        public readonly static string PRO_ProductUnitId = "ProductUnitId";
        #endregion
    }
}