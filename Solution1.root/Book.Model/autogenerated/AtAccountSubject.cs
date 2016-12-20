﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：AtAccountSubject.autogenerated.cs
// author: mayanjun
// create date：2011-3-3 14:30:23
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class AtAccountSubject
	{
		#region Data

		/// <summary>
		/// 
		/// </summary>
		private string _subjectId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _subjectName;
		
		/// <summary>
		/// 
		/// </summary>
		private string _commonSummary;
		
		/// <summary>
		/// 
		/// </summary>
		private string _englishName;
		
		/// <summary>
		/// 
		/// </summary>
		private string _accountingCategoryId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _theLending;
		
		/// <summary>
		/// 
		/// </summary>
		private decimal? _theBalance;
		
		/// <summary>
		/// 
		/// </summary>
		private bool? _offsetSubject;
		
		/// <summary>
		/// 
		/// </summary>
		private bool? _ruleSubject;
		
		/// <summary>
		/// 
		/// </summary>
		private string _underSubject;
		
		/// <summary>
		/// 
		/// </summary>
		private string _mark;
		
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
		private string _id;

        private string _isCash;
		
		/// <summary>
		/// 
		/// </summary>
		private AtAccountingCategory _accountingCategory;
		 
		#endregion
		
		#region Properties
		
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
		public string SubjectName
		{
			get 
			{
				return this._subjectName;
			}
			set 
			{
				this._subjectName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string CommonSummary
		{
			get 
			{
				return this._commonSummary;
			}
			set 
			{
				this._commonSummary = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string EnglishName
		{
			get 
			{
				return this._englishName;
			}
			set 
			{
				this._englishName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string AccountingCategoryId
		{
			get 
			{
				return this._accountingCategoryId;
			}
			set 
			{
				this._accountingCategoryId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string TheLending
		{
			get 
			{
				return this._theLending;
			}
			set 
			{
				this._theLending = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public decimal? TheBalance
		{
			get 
			{
				return this._theBalance;
			}
			set 
			{
				this._theBalance = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool? OffsetSubject
		{
			get 
			{
				return this._offsetSubject;
			}
			set 
			{
				this._offsetSubject = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool? RuleSubject
		{
			get 
			{
				return this._ruleSubject;
			}
			set 
			{
				this._ruleSubject = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string UnderSubject
		{
			get 
			{
				return this._underSubject;
			}
			set 
			{
				this._underSubject = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Mark
		{
			get 
			{
				return this._mark;
			}
			set 
			{
				this._mark = value;
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
		public string Id
		{
			get 
			{
				return this._id;
			}
			set 
			{
				this._id = value;
			}
        }

        public string IsCash
        {
            get { return _isCash; }
            set { _isCash = value; }
        }
	
		/// <summary>
		/// 
		/// </summary>
		public virtual AtAccountingCategory AccountingCategory
		{
			get
			{
				return this._accountingCategory;
			}
			set
			{
				this._accountingCategory = value;
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_SubjectId = "SubjectId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_SubjectName = "SubjectName";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_CommonSummary = "CommonSummary";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_EnglishName = "EnglishName";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_AccountingCategoryId = "AccountingCategoryId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_TheLending = "TheLending";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_TheBalance = "TheBalance";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_OffsetSubject = "OffsetSubject";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_RuleSubject = "RuleSubject";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_UnderSubject = "UnderSubject";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_Mark = "Mark";
		
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
		public readonly static string PRO_Id = "Id";

        public readonly static string PRO_IsCash = "IsCash";
		

		#endregion
	}
}