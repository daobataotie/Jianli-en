﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ShouldPayAccount.autogenerated.cs
// author: mayanjun
// create date：2014/8/11 19:47:23
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class ShouldPayAccount
    {
        #region Data

        /// <summary>
        /// 
        /// </summary>
        private string _shouldPayAccountId;

        /// <summary>
        /// 
        /// </summary>
        private string _invoiceDate;

        /// <summary>
        /// 
        /// </summary>
        private string _payDate;

        /// <summary>
        /// 
        /// </summary>
        private string _supplierId;

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
        private string _atSummonId;

        /// <summary>
        /// 
        /// </summary>
        private string _atBillsIncomeId;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _jinE;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _shuiE;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _zheRang;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _total;

        private decimal? _payZheRang;

        private string _employeeId;

        private string _shouldPayAccountConditionId;

        private Employee _employee;

        private ShouldPayAccountCondition _shouldPayAccountCondition; 


        /// <summary>
        /// 供应商
        /// </summary>
        private Supplier _supplier;
        /// <summary>
        /// 票据收付
        /// </summary>
        private AtBillsIncome _atBillsIncome;
        /// <summary>
        /// 传票主档
        /// </summary>
        private AtSummon _atSummon;

        #endregion

        #region Properties

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
        public string InvoiceDate
        {
            get
            {
                return this._invoiceDate;
            }
            set
            {
                this._invoiceDate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PayDate
        {
            get
            {
                return this._payDate;
            }
            set
            {
                this._payDate = value;
            }
        }

        /// <summary>
        /// 
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
        public string AtSummonId
        {
            get
            {
                return this._atSummonId;
            }
            set
            {
                this._atSummonId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AtBillsIncomeId
        {
            get
            {
                return this._atBillsIncomeId;
            }
            set
            {
                this._atBillsIncomeId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? JinE
        {
            get
            {
                return this._jinE;
            }
            set
            {
                this._jinE = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? ShuiE
        {
            get
            {
                return this._shuiE;
            }
            set
            {
                this._shuiE = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? ZheRang
        {
            get
            {
                return this._zheRang;
            }
            set
            {
                this._zheRang = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }

        public decimal? PayZheRang
        {
            get { return _payZheRang; }
            set { _payZheRang = value; }
        }

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string ShouldPayAccountConditionId
        {
            get { return _shouldPayAccountConditionId; }
            set { _shouldPayAccountConditionId = value; }
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
        /// 票据收付
        /// </summary>
        public virtual AtBillsIncome AtBillsIncome
        {
            get
            {
                return this._atBillsIncome;
            }
            set
            {
                this._atBillsIncome = value;
            }

        }
        /// <summary>
        /// 传票主档
        /// </summary>
        public virtual AtSummon AtSummon
        {
            get
            {
                return this._atSummon;
            }
            set
            {
                this._atSummon = value;
            }

        }
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        public ShouldPayAccountCondition ShouldPayAccountCondition
        {
            get { return _shouldPayAccountCondition; }
            set { _shouldPayAccountCondition = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ShouldPayAccountId = "ShouldPayAccountId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_InvoiceDate = "InvoiceDate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_PayDate = "PayDate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_SupplierId = "SupplierId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_InsertTime = "InsertTime";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_UpdateTime = "UpdateTime";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_AtSummonId = "AtSummonId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_AtBillsIncomeId = "AtBillsIncomeId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_JinE = "JinE";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ShuiE = "ShuiE";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ZheRang = "ZheRang";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Total = "Total";

        public readonly static string PRO_PayZheRang = "PayZheRang";

        public readonly static string PRO_EmployeeId = "EmployeeId";

        public readonly static string PRO_ShouldPayAccountConditionId = "ShouldPayAccountConditionId";
        #endregion
    }
}