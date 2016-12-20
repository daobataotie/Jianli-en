﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;
namespace Book.UI.produceManager.PronoteHeader
{
    public partial class ROJGZHishi : DevExpress.XtraReports.UI.XtraReport
    {
        private BL.PronoteHeaderManager pronoteHeaderManager = new Book.BL.PronoteHeaderManager();
        private BL.PronotedetailsMaterialManager pronotedetailsMaterialManager = new Book.BL.PronotedetailsMaterialManager();

        private Model.PronoteHeader pronoteHeader;
        private BL.PronoteProceduresDetailManager pronoteProceduresDetailManager = new Book.BL.PronoteProceduresDetailManager();
        private System.Collections.Generic.IList<Model.PronoteMachine> machineList = new System.Collections.Generic.List<Model.PronoteMachine>();
        private BL.PronoteMachineManager pronoteMachineManager = new BL.PronoteMachineManager();
        BL.MRSdetailsManager mRSDetailsManager = new BL.MRSdetailsManager();
        public ROJGZHishi(string pronoteHeaderId, int flag)
        {
            InitializeComponent();
            this.pronoteHeader = this.pronoteHeaderManager.GetDetails(pronoteHeaderId);

            //CompanyInfo
            this.xrLabelCompanyInfoName.Text = BL.Settings.CompanyChineseName;
            this.xrLabelDataName.Text = Properties.Resources.Pronotedetails;
            if (flag == 5)
            {
                this.xrLabelDataName.Text = Properties.Resources.GZZhiShi;
            }
            else if (flag == 4)
            {
                this.xrLabelDataName.Text = Properties.Resources.ZZJiaGong;
            }
            this.xrLabelPrintDate.Text = this.xrLabelPrintDate.Text + DateTime.Now.ToShortDateString();
            if (pronoteHeader.WorkHouse != null)
                this.xrLabelWorkHouse.Text = this.pronoteHeader.WorkHouse.Workhousename;

            Model.MRSdetails mrsdetail = this.mRSDetailsManager.Get(this.pronoteHeader.MRSdetailsId);
            if (mrsdetail != null)
                this.xrLabelBeforepPackage.Text = mrsdetail.BeforePackageProduct == null ? string.Empty : (mrsdetail.BeforePackageProduct.IsCustomerProduct.HasValue && mrsdetail.BeforePackageProduct.IsCustomerProduct.Value ? mrsdetail.BeforePackageProduct.ProductName + "{" + mrsdetail.BeforePackageProduct.CustomerProductName + "}" : mrsdetail.BeforePackageProduct.ProductName);
            else
                this.xrLabelBeforepPackage.Text = string.Empty;
            //生產通知
            this.xrLabelPronoteHeaderID.Text = this.pronoteHeader.PronoteHeaderID;
            this.xrLabelPronoteDte.Text = this.pronoteHeader.PronoteDate.Value.ToString("yyyy-MM-dd");
            this.xrLabelMRP.Text = this.pronoteHeader.MRSHeaderId;
            if (this.pronoteHeader.Employee0 != null && flag != 1)
            {
                this.xrLabelEmployee.Text = this.pronoteHeader.Employee0.EmployeeName;
            }
            this.xrLabel14.Text = this.pronoteHeader.AuditEmp == null ? "" : this.pronoteHeader.AuditEmp.EmployeeName;
            if (pronoteHeader.Product != null)
            {

                this.xrLabelProductName.Text = pronoteHeader.Product.ProductName;
                this.xrLabelCustomerProductName.Text = pronoteHeader.Product.CustomerProductName;
                this.xrRichTextProDesc.Rtf = this.pronoteHeader.Product.ProductDescription;
            }
            Model.InvoiceXO xo = new BL.InvoiceXOManager().Get(this.pronoteHeader.InvoiceXOId);
            if (xo != null)
            {
                this.xrLabelCheckedStandard.Text = xo.xocustomer.CheckedStandard;
                this.xrLabelCustomer.Text = xo.xocustomer.CustomerShortName;
                this.xrLabelCustomerXOId.Text = xo.CustomerInvoiceXOId;
                if (flag != 0)
                {
                    this.xrLabelXOJHDate.Text = xo.InvoiceYjrq.Value.ToString("yyyy-MM-dd");
                    this.xrLabelPiHao.Text = xo.CustomerLotNumber;
                }
            }
            this.xrLabelCount.Text = pronoteHeader.DetailsSum.ToString();
            this.xrLabelUnit.Text = pronoteHeader.ProductUnit;
            this.xrLabelPronotedesc.Text = this.pronoteHeader.Pronotedesc;
            //this.lblChakuang.Text = this.pronoteHeader.Chakuang;
            //this.lblPaihe.Text = this.pronoteHeader.Paihe;
            //this.lblMoshu.Text = this.pronoteHeader.Moshu;
            //if (this.pronoteHeader.DetailProcedures != null && this.pronoteHeader.DetailProcedures.Count > 0)
            //{
            //    this.pronoteHeader.DetailProcedures = this.pronoteHeader.DetailProcedures.OrderByDescending(p => p.PronoteProceduresDate).ToList();

            //    if (this.pronoteHeader.DetailProcedures.First().WorkHouse != null)
            //        this.xrLabelhouseId.Text = this.pronoteHeader.DetailProcedures.First().WorkHouse.Workhousename;
            //}


            this.xrSubreport1.ReportSource = new RO1();
            this.xrSubreport2.ReportSource = new RO2();
        }

        private void RO_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            RO1 material = this.xrSubreport1.ReportSource as RO1;
            material.PronoteHeader = this.pronoteHeader;
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            RO2 material = this.xrSubreport2.ReportSource as RO2;
            material.PronoteHeader = this.pronoteHeader;
        }

    }
}
