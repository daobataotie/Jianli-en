﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：Package.autogenerated.cs
// author: peidun
// create date：2009-08-13 11:08:32
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class Package
	{
		#region Data

		/// <summary>
		/// 材料编号
		/// </summary>
		private string _packageId;
		
		/// <summary>
		/// 插入时间
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 修改时间
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// 材料名称
		/// </summary>
		private string _packageName;
		
		/// <summary>
		/// 说明
		/// </summary>
		private string _packageDescription;
		
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 材料编号
		/// </summary>
		public string PackageId
		{
			get 
			{
				return this._packageId;
			}
			set 
			{
				this._packageId = value;
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
		/// 材料名称
		/// </summary>
		public string PackageName
		{
			get 
			{
				return this._packageName;
			}
			set 
			{
				this._packageName = value;
			}
		}

		/// <summary>
		/// 说明
		/// </summary>
		public string PackageDescription
		{
			get 
			{
				return this._packageDescription;
			}
			set 
			{
				this._packageDescription = value;
			}
		}
	
		/// <summary>
		/// 材料编号
		/// </summary>
		public readonly static string PROPERTY_PACKAGEID = "PackageId";
		
		/// <summary>
		/// 插入时间
		/// </summary>
		public readonly static string PROPERTY_INSERTTIME = "InsertTime";
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public readonly static string PROPERTY_UPDATETIME = "UpdateTime";
		
		/// <summary>
		/// 材料名称
		/// </summary>
		public readonly static string PROPERTY_PACKAGENAME = "PackageName";
		
		/// <summary>
		/// 说明
		/// </summary>
		public readonly static string PROPERTY_PACKAGEDESCRIPTION = "PackageDescription";
		

		#endregion
	}
}