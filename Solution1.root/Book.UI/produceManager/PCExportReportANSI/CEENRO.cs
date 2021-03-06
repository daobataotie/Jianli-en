using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Book.UI.produceManager.PCExportReportANSI
{
    public partial class CEENRO : DevExpress.XtraReports.UI.XtraReport
    {
        public CEENRO()
        {
            InitializeComponent();
        }

        public CEENRO(Model.PCExportReportANSI _PCExportReportANSI, int tag)
            : this()
        {
            if (tag == 1)
            {
                this.xrLabel1.Text = "ALAN    SAFETY    INC.";
            }
            else if (tag == 2)
            {
                this.xrLabel1.Text = "PPE   SAFETY   INC.";
            }
            this.LbCustomer.Text = _PCExportReportANSI.Customer == null ? null : _PCExportReportANSI.Customer.ToString();
            this.LbOrderId.Text = _PCExportReportANSI.InvoiceCusXOId == null ? null : _PCExportReportANSI.InvoiceCusXOId.ToString();
            this.LbProduct.Text = _PCExportReportANSI.Product.CustomerProductName == null ? null : _PCExportReportANSI.Product.CustomerProductName.ToString();
            this.LbOrderAmount.Text = _PCExportReportANSI.Amount.HasValue ? _PCExportReportANSI.Amount.ToString() : "0";
            this.LbTestAmount.Text = _PCExportReportANSI.AmountTest.HasValue ? _PCExportReportANSI.AmountTest.ToString() : "0";
            this.LbTesrPerson.Text = _PCExportReportANSI.Employee == null ? null : _PCExportReportANSI.Employee.ToString();
            this.LbReportDate.Text = _PCExportReportANSI.ReportDate == null ? null : _PCExportReportANSI.ReportDate.Value.ToShortDateString();
            this.LbClearlens.Text = _PCExportReportANSI.Clearlens == null ? null : _PCExportReportANSI.Clearlens.ToString();
            //this.lbTraceability.Text = _PCExportReportANSI.TraceMarking == null ? null : _PCExportReportANSI.TraceMarking.ToString();
            this.lbProtectionone.Text = _PCExportReportANSI.Protectionone == null ? null : _PCExportReportANSI.Protectionone.ToString();
            this.lbProtectiontwo.Text = _PCExportReportANSI.Protectiontwo == null ? null : _PCExportReportANSI.Protectiontwo.ToString();

            this.LbTestCS.Text = _PCExportReportANSI.ShouCeShu1.HasValue ? _PCExportReportANSI.ShouCeShu1.ToString() : "0";
            this.LbTestSp.Text = _PCExportReportANSI.ShouCeShu2.HasValue ? _PCExportReportANSI.ShouCeShu2.ToString() : "0";
            this.LbTestAR.Text = _PCExportReportANSI.ShouCeShu3.HasValue ? _PCExportReportANSI.ShouCeShu3.ToString() : "0";
            this.LbTestPR.Text = _PCExportReportANSI.ShouCeShu4.HasValue ? _PCExportReportANSI.ShouCeShu4.ToString() : "0";
            this.LbTestDP.Text = _PCExportReportANSI.ShouCeShu5.HasValue ? _PCExportReportANSI.ShouCeShu5.ToString() : "0";
            this.LbTestTS.Text = _PCExportReportANSI.ShouCeShu6.HasValue ? _PCExportReportANSI.ShouCeShu6.ToString() : "0";
            this.LbTestSQ.Text = _PCExportReportANSI.ShouCeShu7.HasValue ? _PCExportReportANSI.ShouCeShu7.ToString() : "0";
            this.LbTestIR.Text = _PCExportReportANSI.ShouCeShu8.HasValue ? _PCExportReportANSI.ShouCeShu8.ToString() : "0";
            this.LbTestHS.Text = _PCExportReportANSI.ShouCeShu9.HasValue ? _PCExportReportANSI.ShouCeShu9.ToString() : "0";
            this.LbTestMK.Text = _PCExportReportANSI.ShouCeShu10.HasValue ? _PCExportReportANSI.ShouCeShu10.ToString() : "0";
            this.LbTestIF.Text = _PCExportReportANSI.ShouCeShu11.HasValue ? _PCExportReportANSI.ShouCeShu11.ToString() : "0";
            this.LbTestUT.Text = _PCExportReportANSI.ShouCeShu12.HasValue ? _PCExportReportANSI.ShouCeShu12.ToString() : "0";

            this.LbJudgeCS.Text = _PCExportReportANSI.PanDing1.HasValue ? _PCExportReportANSI.PanDing1.ToString() : "0";
            this.LbJudgeSP.Text = _PCExportReportANSI.PanDing2.HasValue ? _PCExportReportANSI.PanDing2.ToString() : "0";
            this.LbJudgeAR.Text = _PCExportReportANSI.PanDing3.HasValue ? _PCExportReportANSI.PanDing3.ToString() : "0";
            this.LbJudgePR.Text = _PCExportReportANSI.PanDing4.HasValue ? _PCExportReportANSI.PanDing4.ToString() : "0";
            this.LbJudgeDP.Text = _PCExportReportANSI.PanDing5.HasValue ? _PCExportReportANSI.PanDing5.ToString() : "0";
            this.LbJudgeTS.Text = _PCExportReportANSI.PanDing6.HasValue ? _PCExportReportANSI.PanDing6.ToString() : "0";
            this.LbJudgeSQ.Text = _PCExportReportANSI.PanDing7.HasValue ? _PCExportReportANSI.PanDing7.ToString() : "0";
            this.LbJudgeIR.Text = _PCExportReportANSI.PanDing8.HasValue ? _PCExportReportANSI.PanDing8.ToString() : "0";
            this.LbJudgeHS.Text = _PCExportReportANSI.PanDing9.HasValue ? _PCExportReportANSI.PanDing9.ToString() : "0";
            this.LbJudgeMK.Text = _PCExportReportANSI.PanDing10.HasValue ? _PCExportReportANSI.PanDing10.ToString() : "0";
            this.LbJudgeIF.Text = _PCExportReportANSI.PanDing11.HasValue ? _PCExportReportANSI.PanDing11.ToString() : "0";
            this.LbJudgeUT.Text = _PCExportReportANSI.PanDingShu12.HasValue ? _PCExportReportANSI.PanDingShu12.ToString() : "0";
        }

    }
}
