using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Book.UI.produceManager.PCPGOnlineCheck
{
    public partial class subReportGX : DevExpress.XtraReports.UI.XtraReport
    {
        string sign = string.Empty;
        private BL.OpticsTestManager _OpticsTestManager = new Book.BL.OpticsTestManager();

        public subReportGX()
        {
            InitializeComponent();
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(subReportGX_BeforePrint);

            this.TCcsbh.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_OpticsTestId);
            this.TCsdcsbh.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_ManualId);
            this.TCcsrq.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_OptiscTestDate, "{0:yyyy-MM-dd}");
            this.TCxzjx.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_MachineName);
            this.TCxztj.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_Condition);
            this.TCcsyg.DataBindings.Add("Text", this.DataSource, "Employee." + Model.Employee.PROPERTY_EMPLOYEENAME);

            this.TCls.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LattrS);
            this.TCla.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LattrA);
            this.TClc.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LattrC);
            this.TClin.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LinPSM);
            this.TClout.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LoutPSM);
            this.TClup.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LupPSM);
            this.TCldown.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_LdownPSM);

            this.TCrs.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RattrS);
            this.TCra.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RattrA);
            this.TCrc.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RattrC);
            this.TCrin.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RinPSM);
            this.TCrout.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RoutPSM);
            this.TCrup.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RupPSM);
            this.TCrdown.DataBindings.Add("Text", this.DataSource, Model.OpticsTest.PRO_RdowmPSM);
        }
        public subReportGX(string s)
            : this()
        {
            this.sign = s;
        }

        public string _PCPGOnlineCheckDetailId { get; set; }

        private void subReportGX_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.sign == string.Empty)
                this.DataSource = this._OpticsTestManager.mSelect(this._PCPGOnlineCheckDetailId);
            else
                this.DataSource = this._OpticsTestManager.FSelect(this._PCPGOnlineCheckDetailId);

        }
    }
}