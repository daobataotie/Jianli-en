//------------------------------------------------------------------------------
//
// file name：MRSHeader.cs
// author: peidun
// create date：2009-12-18 11:23:48
//
//------------------------------------------------------------------------------
using System;
namespace Book.Model
{
    /// <summary>
    /// 物料需求计划头
    /// </summary>
    [Serializable]
    public partial class MRSHeader
    {
        private System.Collections.Generic.IList<MRSdetails> details;


        public System.Collections.Generic.IList<MRSdetails> Details
        {
            get { return details; }
            set { details = value; }
        }

        public readonly static string PROPERTY_GETSOURCETYPE = "GetSourceType";

        public string GetSourceType
        {
            get
            {
                string sourceType = string.Empty;
                switch (_sourceType == null ? "-1" : _sourceType)
                {
                    case "0":
                        sourceType = "Self made";
                        break;
                    case "1":
                        sourceType = "Purchase";
                        break;
                    case "2":
                        sourceType = "Consumption";
                        break;
                    case "3":
                        sourceType = "Outsourcing";
                        break;
                    case "4":
                        sourceType = "Self made(Assembly)";
                        break;
                    case "5":
                        sourceType = "Self made(Semi-finished products)";
                        break;
                    case "6":
                        sourceType = "Outsourcing(Semi-finished products)";
                        break;
                    default:
                        break;
                }
                return sourceType;
            }
        }
        /// <summary>
        /// 记住所有移动过的头文档的行，以减少之后的迭代
        /// </summary>
        public bool IsNodTheCurent { get; set; }

        private string _customerInvoiceXOId;

        public string CustomerInvoiceXOId
        {
            get { return _customerInvoiceXOId; }
            set { _customerInvoiceXOId = value; }
        }

        public readonly static string PROPERTY_CustomerInvoiceXOId = "CustomerInvoiceXOId";

        private bool _IsChecked;

        public bool IsChecked
        {
            get { return _IsChecked; }
            set { _IsChecked = value; }
        }
        private bool _isCloseed;

        public bool IsCloseed
        {
            get { return _isCloseed; }
            set { _isCloseed = value; }
        }
        private DateTime? _yjrqDate;

        public DateTime? YjrqDate
        {
            get { return _yjrqDate; }
            set { _yjrqDate = value; }
        }
        private string _piHao;

        public string PiHao
        {
            get { return _piHao; }
            set { _piHao = value; }
        }

        private string _employee0Name;

             public string Employee0Name
        {
            get { return _employee0Name; }
            set { _employee0Name = value; }
        }
             private string _employee1Name;

         public string Employee1Name
        {
            get { return _employee1Name; }
            set { _employee1Name = value; }
        }
         private string _customerShortName;

         public string CustomerShortName
         {
             get { return _customerShortName; }
             set { _customerShortName = value; }
         }
        public readonly static string PROPERTY_IsChecked = "IsChecked";
    }
}
