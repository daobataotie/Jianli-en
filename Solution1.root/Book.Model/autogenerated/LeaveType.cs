﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：LeaveType.autogenerated.cs
// author: mayanjun
// create date：2012-3-3 15:18:25
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    public partial class LeaveType
    {
        #region Data

        /// <summary>
        /// 休假类别编号
        /// </summary>
        private string _leaveTypeId;

        /// <summary>
        /// 插入时间
        /// </summary>
        private DateTime? _insertTime;

        /// <summary>
        /// 修改时间
        /// </summary>
        private DateTime? _updateTime;

        /// <summary>
        /// 名称
        /// </summary>
        private string _leaveTypeName;

        /// <summary>
        /// 补助
        /// </summary>
        private double? _payRate;

        /// <summary>
        /// 是否纳入扣款
        /// </summary>
        private bool? _isCountToPunish;

        /// <summary>
        /// 
        /// </summary>
        private bool? _doAttendance;


        #endregion

        #region Properties

        /// <summary>
        /// 休假类别编号
        /// </summary>
        public string LeaveTypeId
        {
            get
            {
                return this._leaveTypeId;
            }
            set
            {
                this._leaveTypeId = value;
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
        /// 名称
        /// </summary>
        public string LeaveTypeName
        {
            get
            {
                return this._leaveTypeName;
            }
            set
            {
                this._leaveTypeName = value;
            }
        }

        /// <summary>
        /// 补助
        /// </summary>
        public double? PayRate
        {
            get
            {
                return this._payRate;
            }
            set
            {
                this._payRate = value;
            }
        }

        /// <summary>
        /// 是否纳入扣款
        /// </summary>
        public bool? IsCountToPunish
        {
            get
            {
                return this._isCountToPunish;
            }
            set
            {
                this._isCountToPunish = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool? doAttendance
        {
            get
            {
                return this._doAttendance;
            }
            set
            {
                this._doAttendance = value;
            }
        }

        /// <summary>
        /// 休假类别编号
        /// </summary>
        public readonly static string PRO_LeaveTypeId = "LeaveTypeId";

        /// <summary>
        /// 插入时间
        /// </summary>
        public readonly static string PRO_InsertTime = "InsertTime";

        /// <summary>
        /// 修改时间
        /// </summary>
        public readonly static string PRO_UpdateTime = "UpdateTime";

        /// <summary>
        /// 名称
        /// </summary>
        public readonly static string PRO_LeaveTypeName = "LeaveTypeName";

        /// <summary>
        /// 补助
        /// </summary>
        public readonly static string PRO_PayRate = "PayRate";

        /// <summary>
        /// 是否纳入扣款
        /// </summary>
        public readonly static string PRO_IsCountToPunish = "IsCountToPunish";

        /// <summary>
        /// 
        /// </summary>
        public readonly static string PRO_doAttendance = "doAttendance";


        #endregion
    }
}