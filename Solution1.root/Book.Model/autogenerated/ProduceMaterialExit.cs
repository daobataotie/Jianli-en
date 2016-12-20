﻿//------------------------------------------------------------------------------
//
// 说明： 该文件中的内容是由代码生成器自动生成的，请勿手工修改！
//
// file name：ProduceMaterialExit.autogenerated.cs
// author: mayanjun
// create date：2012-2-4 11:20:37
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
	public partial class ProduceMaterialExit
	{
		#region Data

		/// <summary>
		/// 编号
		/// </summary>
		private string _produceMaterialExitId;
		
		/// <summary>
		/// 操作人
		/// </summary>
		private string _employee0Id;
		
		/// <summary>
		/// 退料人
		/// </summary>
		private string _employee1Id;
		
		/// <summary>
		/// 插入时间
		/// </summary>
		private DateTime? _insertTime;
		
		/// <summary>
		/// 修改时间
		/// </summary>
		private DateTime? _updateTime;
		
		/// <summary>
		/// 说明
		/// </summary>
		private string _produceExitMaterialDesc;
		
		/// <summary>
		/// 时间
		/// </summary>
		private DateTime? _produceExitMaterialDate;
		
		/// <summary>
		/// 
		/// </summary>
		private string _workHouseId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _depotId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _pronoteHeaderID;
		
		/// <summary>
		/// 
		/// </summary>
		private string _customerInvoiceXOId;
		
		/// <summary>
		/// 
		/// </summary>
		private string _supplierId;
		
		/// <summary>
		/// 
		/// </summary>
		private int? _auditState;
		
		/// <summary>
		/// 
		/// </summary>
		private string _auditEmpId;
		
		/// <summary>
		/// 库房
		/// </summary>
		private Depot _depot;
		/// <summary>
		/// 员工
		/// </summary>
		private Employee _auditEmp;
		/// <summary>
		/// 员工
		/// </summary>
		private Employee _employee1;
		/// <summary>
		/// 员工
		/// </summary>
		private Employee _employee0;
		/// <summary>
		/// 供应商
		/// </summary>
		private Supplier _supplier;
		/// <summary>
		/// 工作中心
		/// </summary>
		private WorkHouse _workHouse;
		 
		#endregion
		
		#region Properties
		
		/// <summary>
		/// 编号
		/// </summary>
		public string ProduceMaterialExitId
		{
			get 
			{
				return this._produceMaterialExitId;
			}
			set 
			{
				this._produceMaterialExitId = value;
			}
		}

		/// <summary>
		/// 操作人
		/// </summary>
		public string Employee0Id
		{
			get 
			{
				return this._employee0Id;
			}
			set 
			{
				this._employee0Id = value;
			}
		}

		/// <summary>
		/// 退料人
		/// </summary>
		public string Employee1Id
		{
			get 
			{
				return this._employee1Id;
			}
			set 
			{
				this._employee1Id = value;
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
		/// 说明
		/// </summary>
		public string ProduceExitMaterialDesc
		{
			get 
			{
				return this._produceExitMaterialDesc;
			}
			set 
			{
				this._produceExitMaterialDesc = value;
			}
		}

		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? ProduceExitMaterialDate
		{
			get 
			{
				return this._produceExitMaterialDate;
			}
			set 
			{
				this._produceExitMaterialDate = value;
			}
		}

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string DepotId
		{
			get 
			{
				return this._depotId;
			}
			set 
			{
				this._depotId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string PronoteHeaderID
		{
			get 
			{
				return this._pronoteHeaderID;
			}
			set 
			{
				this._pronoteHeaderID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string CustomerInvoiceXOId
		{
			get 
			{
				return this._customerInvoiceXOId;
			}
			set 
			{
				this._customerInvoiceXOId = value;
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

		/// <summary>
		/// 
		/// </summary>
		public string AuditEmpId
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
	
		/// <summary>
		/// 库房
		/// </summary>
		public virtual Depot Depot
		{
			get
			{
				return this._depot;
			}
			set
			{
				this._depot = value;
			}
			
		}
		/// <summary>
		/// 员工
		/// </summary>
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
		public virtual Employee Employee1
		{
			get
			{
				return this._employee1;
			}
			set
			{
				this._employee1 = value;
			}
			
		}
		/// <summary>
		/// 员工
		/// </summary>
		public virtual Employee Employee0
		{
			get
			{
				return this._employee0;
			}
			set
			{
				this._employee0 = value;
			}
			
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
		/// <summary>
		/// 编号
		/// </summary>
		public readonly static string PRO_ProduceMaterialExitId = "ProduceMaterialExitId";
		
		/// <summary>
		/// 操作人
		/// </summary>
		public readonly static string PRO_Employee0Id = "Employee0Id";
		
		/// <summary>
		/// 退料人
		/// </summary>
		public readonly static string PRO_Employee1Id = "Employee1Id";
		
		/// <summary>
		/// 插入时间
		/// </summary>
		public readonly static string PRO_InsertTime = "InsertTime";
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public readonly static string PRO_UpdateTime = "UpdateTime";
		
		/// <summary>
		/// 说明
		/// </summary>
		public readonly static string PRO_ProduceExitMaterialDesc = "ProduceExitMaterialDesc";
		
		/// <summary>
		/// 时间
		/// </summary>
		public readonly static string PRO_ProduceExitMaterialDate = "ProduceExitMaterialDate";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_WorkHouseId = "WorkHouseId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_DepotId = "DepotId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_PronoteHeaderID = "PronoteHeaderID";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_CustomerInvoiceXOId = "CustomerInvoiceXOId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_SupplierId = "SupplierId";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_AuditState = "AuditState";
		
		/// <summary>
		/// 
		/// </summary>
		public readonly static string PRO_AuditEmpId = "AuditEmpId";
		

		#endregion
	}
}
