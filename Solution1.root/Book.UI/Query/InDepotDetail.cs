using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Book.UI.Query
{
    public partial class InDepotDetail : DevExpress.XtraReports.UI.XtraReport
    {
        BL.DepotInDetailManager manager = new Book.BL.DepotInDetailManager();
        public InDepotDetail()
        {
            InitializeComponent();
        }
        public InDepotDetail(InDepot condition)
            : this()
        {
            this.lblCompanyName.Text = BL.Settings.CompanyChineseName;
            this.lblReportName.Text = Properties.Resources.InDepotDetail;
            this.lblDateRange.Text = "Date range£º" + condition.StartDate.ToString("yyyy-MM-dd") + "-" + condition.EndDate.ToString("yyyy-MM-dd");
            this.lblPrintDate.Text = "Print date£º" + DateTime.Now.ToString("yyyy-MM-dd");

            IList<Model.DepotInDetail> details = manager.SelectByCondition(condition.StartDate, condition.EndDate, condition.InDepotIdStart, condition.InDepotIdEnd, condition.DepotIdStart, condition.DepotIdEnd, condition.SupplierStart, condition.SupplierEnd);
            if (details == null)
                throw new Helper.InvalidValueException("No data");
            this.DataSource = details;

            this.TCDate.DataBindings.Add("Text", this.DataSource, Model.DepotInDetail.PRO_Date, "{0:yyyy-MM-dd}");
            this.TCInDepotId.DataBindings.Add("Text", this.DataSource, Model.DepotInDetail.PRO_DepotInId);
            this.TCDepot.DataBindings.Add("Text", this.DataSource, "DepotPosition." + "Depot." + Model.Depot.PRO_DepotName);
            this.TCProduct.DataBindings.Add("Text", this.DataSource, "Product");
            this.TCUnit.DataBindings.Add("Text", this.DataSource, Model.DepotInDetail.PRO_ProductUnit);
            this.TCPosition.DataBindings.Add("Text", this.DataSource, "DepotPosition");
            this.TCNum.DataBindings.Add("Text", this.DataSource, Model.DepotInDetail.PRO_DepotInQuantity);

            this.lblTotalNum.Summary.FormatString = "{0:0}";
            this.lblTotalNum.Summary.Func = SummaryFunc.Sum;
            this.lblTotalNum.Summary.IgnoreNullValues = true;
            this.lblTotalNum.Summary.Running = SummaryRunning.Report;
            this.lblTotalNum.DataBindings.Add("Text", this.DataSource, Model.DepotInDetail.PRO_DepotInQuantity);
        }
    }
}
