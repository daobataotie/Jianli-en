﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：BomPackageDetails.autogenerated.cs
// author: mayanjun
// create date：2011-09-22 13:56:59
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class BomPackageDetails
    {
        #region Data

        /// <summary>
        /// 
        /// </summary>
        private string _bomPackageDetailsId;

        /// <summary>
        /// 
        /// </summary>
        private string _bomId;

        /// <summary>
        /// 
        /// </summary>
        private string _productId;

        /// <summary>
        /// 
        /// </summary>
        private double? _quantity;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _effectsDate;

        /// <summary>
        /// 
        /// </summary>
        private double? _consumeRate;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _expiringDate;

        /// <summary>
        /// 
        /// </summary>
        private string _description;

        /// <summary>
        /// 
        /// </summary>
        private string _packageUnit;

        /// <summary>
        /// 
        /// </summary>
        private double? _useQuantity;

        /// <summary>
        /// 
        /// </summary>
        private int? _inumber;

        /// <summary>
        /// Bom母件信息
        /// </summary>
        private BomParentPartInfo _bom;
        /// <summary>
        /// 产品
        /// </summary>
        private Product _product;

        /// <summary>
        /// 下个生产站
        /// </summary>
        private string _nextWorkHouseId;

        /// <summary>
        /// 下个生产站
        /// </summary>
        private WorkHouse _nextWorkHouse;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string BomPackageDetailsId
        {
            get
            {
                return this._bomPackageDetailsId;
            }
            set
            {
                this._bomPackageDetailsId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BomId
        {
            get
            {
                return this._bomId;
            }
            set
            {
                this._bomId = value;
            }
        }

        /// <summary>
        /// 
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
        public double? Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? EffectsDate
        {
            get
            {
                return this._effectsDate;
            }
            set
            {
                this._effectsDate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? ConsumeRate
        {
            get
            {
                return this._consumeRate;
            }
            set
            {
                this._consumeRate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExpiringDate
        {
            get
            {
                return this._expiringDate;
            }
            set
            {
                this._expiringDate = value;
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public string PackageUnit
        {
            get
            {
                return this._packageUnit;
            }
            set
            {
                this._packageUnit = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? UseQuantity
        {
            get
            {
                return this._useQuantity;
            }
            set
            {
                this._useQuantity = value;
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
        /// 下个生产站
        /// </summary>
        public string NextWorkHouseId
        {
            get { return _nextWorkHouseId; }
            set { _nextWorkHouseId = value; }
        }

        /// <summary>
        /// Bom母件信息
        /// </summary>
        public virtual BomParentPartInfo Bom
        {
            get
            {
                return this._bom;
            }
            set
            {
                this._bom = value;
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
        /// 下个生产站
        /// </summary>
        public WorkHouse NextWorkHouse
        {
            get { return _nextWorkHouse; }
            set { _nextWorkHouse = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_BomPackageDetailsId = "BomPackageDetailsId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_BomId = "BomId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ProductId = "ProductId";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Quantity = "Quantity";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_EffectsDate = "EffectsDate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ConsumeRate = "ConsumeRate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_ExpiringDate = "ExpiringDate";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Description = "Description";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_PackageUnit = "PackageUnit";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_UseQuantity = "UseQuantity";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_Inumber = "Inumber";

        /// <summary>
        /// 下个生产站
        /// </summary>
        public readonly static string PRO_NextWorkHouseId = "NextWorkHouseId";
        #endregion
    }
}