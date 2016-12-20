﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtCashAccountDetail.autogenerated.cs
// author: mayanjun
// create date：2014/8/11 19:50:50
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class AtCashAccountDetail
    {
        #region Data

        /// <summary>
        /// 
        /// </summary>
        private string _atCashAccountDetailId;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _atCashAccountDetaiDate;

        /// <summary>
        /// 
        /// </summary>
        private string _atCashAccountId;

        /// <summary>
        /// 
        /// </summary>
        private string _subjectId;

        /// <summary>
        /// 
        /// </summary>
        private string _note;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _income;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _pay;

        /// <summary>
        /// 
        /// </summary>
        private decimal? _balance;

        /// <summary>
        /// 
        /// </summary>
        private AtCashAccount _atCashAccount;

        private AtAccountSubject _subject;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string AtCashAccountDetailId
        {
            get
            {
                return this._atCashAccountDetailId;
            }
            set
            {
                this._atCashAccountDetailId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? AtCashAccountDetaiDate
        {
            get
            {
                return this._atCashAccountDetaiDate;
            }
            set
            {
                this._atCashAccountDetaiDate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AtCashAccountId
        {
            get
            {
                return this._atCashAccountId;
            }
            set
            {
                this._atCashAccountId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SubjectId
        {
            get
            {
                return this._subjectId;
            }
            set
            {
                this._subjectId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            get
            {
                return this._note;
            }
            set
            {
                this._note = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Income
        {
            get
            {
                return this._income;
            }
            set
            {
                this._income = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Pay
        {
            get
            {
                return this._pay;
            }
            set
            {
                this._pay = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual AtCashAccount AtCashAccount
        {
            get
            {
                return this._atCashAccount;
            }
            set
            {
                this._atCashAccount = value;
            }

        }

        public AtAccountSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_AtCashAccountDetailId = "AtCashAccountDetailId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_AtCashAccountDetaiDate = "AtCashAccountDetaiDate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_AtCashAccountId = "AtCashAccountId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_SubjectId = "SubjectId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Note = "Note";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Income = "Income";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Pay = "Pay";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Balance = "Balance";


        #endregion
    }
}