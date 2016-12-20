﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：StockEditorDetal.autogenerated.cs
// author: mayanjun
// create date：2010-11-10 9:17:47
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class StockEditorDetal
	{
		#region Data

		/// <summary>
		/// 详细编号
		/// </summary>
		private string _stockEditorDetalId;
		
		/// <summary>
		/// 商品编号
		/// </summary>
		private string _productId;
		
		/// <summary>
		/// 位置编号
		/// </summary>
		private string _depotPositionId;
		
		/// <summary>
		/// 头编号
		/// </summary>
		private string _stockEditorId;
		
		/// <summary>
		/// 数量
		/// </summary>
		private double? _stockEditorQuantity;
		
		/// <summary>
		/// 单位
		/// </summary>
		private string _productUnitName;
		
		/// <summary>
		/// 说明
		/// </summary>
		private string _directions;
		
		/// <summary>
		/// 
		/// </summary>
		private double? _stockQuantity;
		
		/// <summary>
		/// 库库货位
		/// </summary>
		private DepotPosition _depotPosition;
		/// <summary>
		/// 库存盘点录入
		/// </summary>
		private StockEditor _stockEditor;
		/// <summary>
		/// 产品
		/// </summary>
		private Product _product;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 详细编号
		/// </summary>
		public string StockEditorDetalId
		{
			get 
			{
				return this._stockEditorDetalId;
			}
			set 
			{
				this._stockEditorDetalId = value;
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
		/// 位置编号
		/// </summary>
		public string DepotPositionId
		{
			get 
			{
				return this._depotPositionId;
			}
			set 
			{
				this._depotPositionId = value;
			}
		}

		/// <summary>
		/// 头编号
		/// </summary>
		public string StockEditorId
		{
			get 
			{
				return this._stockEditorId;
			}
			set 
			{
				this._stockEditorId = value;
			}
		}

		/// <summary>
		/// 数量
		/// </summary>
		public double? StockEditorQuantity
		{
			get 
			{
				return this._stockEditorQuantity;
			}
			set 
			{
				this._stockEditorQuantity = value;
			}
		}

		/// <summary>
		/// 单位
		/// </summary>
		public string ProductUnitName
		{
			get 
			{
				return this._productUnitName;
			}
			set 
			{
				this._productUnitName = value;
			}
		}

		/// <summary>
		/// 说明
		/// </summary>
		public string Directions
		{
			get 
			{
				return this._directions;
			}
			set 
			{
				this._directions = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double? StockQuantity
		{
			get 
			{
				return this._stockQuantity;
			}
			set 
			{
				this._stockQuantity = value;
			}
		}
	
		/// <summary>
		/// 库库货位
		/// </summary>
		public virtual DepotPosition DepotPosition
		{
			get
			{
				return this._depotPosition;
			}
			set
			{
				this._depotPosition = value;
			}
			
		}
		/// <summary>
		/// 库存盘点录入
		/// </summary>
		public virtual StockEditor StockEditor
		{
			get
			{
				return this._stockEditor;
			}
			set
			{
				this._stockEditor = value;
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
		/// 详细编号
		/// </summary>
		public readonly static string PROPERTY_STOCKEDITORDETALID = "StockEditorDetalId";
		
		/// <summary>
		/// 商品编号
		/// </summary>
		public readonly static string PROPERTY_PRODUCTID = "ProductId";
		
		/// <summary>
		/// 位置编号
		/// </summary>
		public readonly static string PROPERTY_DEPOTPOSITIONID = "DepotPositionId";
		
		/// <summary>
		/// 头编号
		/// </summary>
		public readonly static string PROPERTY_STOCKEDITORID = "StockEditorId";
		
		/// <summary>
		/// 数量
		/// </summary>
		public readonly static string PROPERTY_STOCKEDITORQUANTITY = "StockEditorQuantity";
		
		/// <summary>
		/// 单位
		/// </summary>
		public readonly static string PROPERTY_PRODUCTUNITNAME = "ProductUnitName";
		
		/// <summary>
		/// 说明
		/// </summary>
		public readonly static string PROPERTY_DIRECTIONS = "Directions";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PROPERTY_STOCKQUANTITY = "StockQuantity";
		

		#endregion
	}
}