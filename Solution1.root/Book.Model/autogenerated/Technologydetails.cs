﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：Technologydetails.autogenerated.cs
// author: peidun
// create date：2009-12-9 11:22:32
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class Technologydetails
	{
		#region Data

		/// <summary>
		/// TechnologydetailsID
		/// </summary>
		private string _technologydetailsID;
		
		/// <summary>
		/// Procedureid
		/// </summary>
		private string _proceduresId;
		
		/// <summary>
		/// TechonlogyHeaderid
		/// </summary>
		private string _techonlogyHeaderId;
		
		/// <summary>
		/// 插入时间
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 修改时间
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// TechnologydetailsNo
		/// </summary>
		private string _technologydetailsNo;
		
		/// <summary>
		/// Technologystate
		/// </summary>
		private string _technologystate;
		
		/// <summary>
		/// TechnologyType
		/// </summary>
		private string _technologyType;
		
		/// <summary>
		/// 说明
		/// </summary>
		private string _description;

        /// <summary>
        /// 数量
        /// </summary>
        private double? _quantity;

        /// <summary>
        /// 损耗
        /// </summary>
        private string _sunhaoRange;
		
		/// <summary>
		/// 工艺路线头
		/// </summary>
		private TechonlogyHeader _techonlogyHeader;
		/// <summary>
		/// 标准工序
		/// </summary>
		private Procedures _procedures;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// TechnologydetailsID
		/// </summary>
		public string TechnologydetailsID
		{
			get 
			{
				return this._technologydetailsID;
			}
			set 
			{
				this._technologydetailsID = value;
			}
		}

		/// <summary>
		/// Procedureid
		/// </summary>
		public string ProceduresId
		{
			get 
			{
				return this._proceduresId;
			}
			set 
			{
				this._proceduresId = value;
			}
		}

		/// <summary>
		/// TechonlogyHeaderid
		/// </summary>
		public string TechonlogyHeaderId
		{
			get 
			{
				return this._techonlogyHeaderId;
			}
			set 
			{
				this._techonlogyHeaderId = value;
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
		/// TechnologydetailsNo
		/// </summary>
		public string TechnologydetailsNo
		{
			get 
			{
				return this._technologydetailsNo;
			}
			set 
			{
				this._technologydetailsNo = value;
			}
		}

		/// <summary>
		/// Technologystate
		/// </summary>
		public string Technologystate
		{
			get 
			{
				return this._technologystate;
			}
			set 
			{
				this._technologystate = value;
			}
		}

		/// <summary>
		/// TechnologyType
		/// </summary>
		public string TechnologyType
		{
			get 
			{
				return this._technologyType;
			}
			set 
			{
				this._technologyType = value;
			}
		}

		/// <summary>
		/// 说明
		/// </summary>
		public string Description
		{
			get 
			{
				return this._description;
			}
			set 
			{
				this._description = value;
			}
        }

        /// <summary>
        /// 数量
        /// </summary>
        public double? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        /// <summary>
        /// 损耗
        /// </summary>
        public string SunhaoRange
        {
            get { return _sunhaoRange; }
            set { _sunhaoRange = value; }
        }
	
		/// <summary>
		/// 工艺路线头
		/// </summary>
		public virtual TechonlogyHeader TechonlogyHeader
		{
			get
			{
				return this._techonlogyHeader;
			}
			set
			{
				this._techonlogyHeader = value;
			}
			
		}
		/// <summary>
		/// 标准工序
		/// </summary>
		public virtual Procedures Procedures
		{
			get
			{
				return this._procedures;
			}
			set
			{
				this._procedures = value;
			}
			
		}
		/// <summary>
		/// TechnologydetailsID
		/// </summary>
		public readonly static string PROPERTY_TECHNOLOGYDETAILSID = "TechnologydetailsID";
		
		/// <summary>
		/// Procedureid
		/// </summary>
		public readonly static string PROPERTY_PROCEDURESID = "ProceduresId";
		
		/// <summary>
		/// TechonlogyHeaderid
		/// </summary>
		public readonly static string PROPERTY_TECHONLOGYHEADERID = "TechonlogyHeaderId";
		
		/// <summary>
		/// 插入时间
		/// </summary>
		public readonly static string PROPERTY_INSERTTIME = "InsertTime";
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public readonly static string PROPERTY_UPDATETIME = "UpdateTime";
		
		/// <summary>
		/// TechnologydetailsNo
		/// </summary>
		public readonly static string PROPERTY_TECHNOLOGYDETAILSNO = "TechnologydetailsNo";
		
		/// <summary>
		/// Technologystate
		/// </summary>
		public readonly static string PROPERTY_TECHNOLOGYSTATE = "Technologystate";
		
		/// <summary>
		/// TechnologyType
		/// </summary>
		public readonly static string PROPERTY_TECHNOLOGYTYPE = "TechnologyType";
		
		/// <summary>
		/// 说明
		/// </summary>
		public readonly static string PROPERTY_DESCRIPTION = "Description";

        /// <summary>
        /// 数量
        /// </summary>
        public readonly static string PRORERTY_Quantity = "Quantity";

        public readonly static string PRORERTY_SunhaoRange = "SunhaoRange";
		#endregion
	}
}
