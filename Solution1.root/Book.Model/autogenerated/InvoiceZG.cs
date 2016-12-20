﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：InvoiceZG.autogenerated.cs
// author: mayanjun
// create date：2012-11-27 15:39:26
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class InvoiceZG
    {
        #region Data

        /// <summary>
        /// 柜子编号
        /// </summary>
        private string _invoiceZGId;

        /// <summary>
        /// 客户编号
        /// </summary>
        private string _customerId;

        /// <summary>
        /// 编号
        /// </summary>
        private string _employeeId;

        /// <summary>
        /// 出货客户编号
        /// </summary>
        private string _xOCustomerId;

        /// <summary>
        /// 装柜日期
        /// </summary>
        private DateTime? _invoiceZGDate;

        /// <summary>
        /// 货运船只
        /// </summary>
        private string _perSS;

        /// <summary>
        /// S/O
        /// </summary>
        private string _sorO;

        /// <summary>
        /// ShippedOnAbout
        /// </summary>
        private string _shippedOnAbout;

        /// <summary>
        /// ArrivelOnAbout
        /// </summary>
        private string _arrivelOnAbout;

        /// <summary>
        /// 发货地
        /// </summary>
        private string _addressFrom;

        /// <summary>
        /// 收货地
        /// </summary>
        private string _addressTo;

        /// <summary>
        /// 备注
        /// </summary>
        private string _invoiceZGDes;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _insertTime;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _updateTime;

        /// <summary>
        /// 公司名称
        /// </summary>
        private string _shippedBy;

        private int? _auditState;

        private string _auditEmpId;

        private Employee _auditEmp;

        /// <summary>
        /// 客户
        /// </summary>
        private Customer _customer;
        /// <summary>
        /// 员工
        /// </summary>
        private Employee _employee;
        /// <summary>
        /// 客户
        /// </summary>
        private Customer _xOCustomer;

        /// <summary>
        ///  公司
        /// </summary>
        private Company _shipped;

        #endregion

        #region Properties

        /// <summary>
        /// 柜子编号
        /// </summary>
        public string InvoiceZGId
        {
            get
            {
                return this._invoiceZGId;
            }
            set
            {
                this._invoiceZGId = value;
            }
        }

        /// <summary>
        /// 客户编号
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
        /// 出货客户编号
        /// </summary>
        public string XOCustomerId
        {
            get
            {
                return this._xOCustomerId;
            }
            set
            {
                this._xOCustomerId = value;
            }
        }

        /// <summary>
        /// 装柜日期
        /// </summary>
        public DateTime? InvoiceZGDate
        {
            get
            {
                return this._invoiceZGDate;
            }
            set
            {
                this._invoiceZGDate = value;
            }
        }

        /// <summary>
        /// 货运船只
        /// </summary>
        public string PerSS
        {
            get
            {
                return this._perSS;
            }
            set
            {
                this._perSS = value;
            }
        }

        /// <summary>
        /// S/O
        /// </summary>
        public string SorO
        {
            get
            {
                return this._sorO;
            }
            set
            {
                this._sorO = value;
            }
        }

        /// <summary>
        /// ShippedOnAbout
        /// </summary>
        public string ShippedOnAbout
        {
            get
            {
                return this._shippedOnAbout;
            }
            set
            {
                this._shippedOnAbout = value;
            }
        }

        /// <summary>
        /// ArrivelOnAbout
        /// </summary>
        public string ArrivelOnAbout
        {
            get
            {
                return this._arrivelOnAbout;
            }
            set
            {
                this._arrivelOnAbout = value;
            }
        }

        /// <summary>
        /// 发货地
        /// </summary>
        public string AddressFrom
        {
            get
            {
                return this._addressFrom;
            }
            set
            {
                this._addressFrom = value;
            }
        }

        /// <summary>
        /// 收货地
        /// </summary>
        public string AddressTo
        {
            get
            {
                return this._addressTo;
            }
            set
            {
                this._addressTo = value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string InvoiceZGDes
        {
            get
            {
                return this._invoiceZGDes;
            }
            set
            {
                this._invoiceZGDes = value;
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
        /// 公司名称
        /// </summary>
        public string ShippedBy
        {
            get { return _shippedBy; }
            set { _shippedBy = value; }
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
        /// 客户
        /// </summary>
        public virtual Customer XOCustomer
        {
            get
            {
                return this._xOCustomer;
            }
            set
            {
                this._xOCustomer = value;
            }

        }

        /// <summary>
        ///  公司
        /// </summary>
        public Company Shipped
        {
            get { return _shipped; }
            set { _shipped = value; }
        }

        /// <summary>
        /// 柜子编号
        /// </summary>
        public readonly static string PRO_InvoiceZGId = "InvoiceZGId";

        /// <summary>
        /// 客户编号
        /// </summary>
        public readonly static string PRO_CustomerId = "CustomerId";

        /// <summary>
        /// 编号
        /// </summary>
        public readonly static string PRO_EmployeeId = "EmployeeId";

        /// <summary>
        /// 出货客户编号
        /// </summary>
        public readonly static string PRO_XOCustomerId = "XOCustomerId";

        /// <summary>
        /// 装柜日期
        /// </summary>
        public readonly static string PRO_InvoiceZGDate = "InvoiceZGDate";

        /// <summary>
        /// 货运船只
        /// </summary>
        public readonly static string PRO_PerSS = "PerSS";

        /// <summary>
        /// S/O
        /// </summary>
        public readonly static string PRO_SorO = "SorO";

        /// <summary>
        /// ShippedOnAbout
        /// </summary>
        public readonly static string PRO_ShippedOnAbout = "ShippedOnAbout";

        /// <summary>
        /// ArrivelOnAbout
        /// </summary>
        public readonly static string PRO_ArrivelOnAbout = "ArrivelOnAbout";

        /// <summary>
        /// 发货地
        /// </summary>
        public readonly static string PRO_AddressFrom = "AddressFrom";

        /// <summary>
        /// 收货地
        /// </summary>
        public readonly static string PRO_AddressTo = "AddressTo";

        /// <summary>
        /// 备注
        /// </summary>
        public readonly static string PRO_InvoiceZGDes = "InvoiceZGDes";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_InsertTime = "InsertTime";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_UpdateTime = "UpdateTime";

        /// <summary>
        /// 公司
        /// </summary>
        public readonly static string PRO_ShippedBy = "ShippedBy";

        public readonly static string PRO_AuditState = "AuditState";

        public readonly static string PRO_AuditEmpId = "AuditEmpId";
        #endregion
    }
}