using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Book.UI.produceManager.PCImpactCheck
{
    public partial class RO : DevExpress.XtraReports.UI.XtraReport
    {
        public RO(Model.PCImpactCheck _pcic)
        {
            InitializeComponent();
            if (_pcic == null)
                return;
            this.DataSource = _pcic.Details;
 
            //CompanyInfo
            this.lblCompanyInfoName.Text = BL.Settings.CompanyChineseName;
            this.lblDataName.Text = Properties.Resources.PCImpactCheck;
            this.lblPrintDate.Text += DateTime.Now.ToShortDateString();

            //Control
            this.lblPCImpactCheckId.Text = _pcic.PCImpactCheckId;
            this.lblPCImpactCheckDate.Text = _pcic.PCImpactCheckDate.Value.ToShortDateString();
            this.lblInvoiceCusXOId.Text = _pcic.InvoiceCusXOId;
            this.lblPronoteHeaderId.Text = _pcic.PronoteHeaderId;
            this.lblPCImpactCheckDesc.Text = _pcic.PCImpactCheckDesc;
            this.lblPCImpactCheckQuantity.Text = _pcic.PCImpactCheckQuantity.Value.ToString();
            this.lblEmployeeId.Text = _pcic.Employee == null ? "" : _pcic.Employee.ToString();
            this.lblWorkHouseId.Text = _pcic.WorkHouse == null ? "" : _pcic.WorkHouse.ToString();
            this.lblProductName.Text = _pcic.Product == null ? "" : _pcic.Product.ToString();
            this.lblDanJuTest.Text = _pcic.PCFromType > 0 ? "Outsourcing No.:" : "Processing No.:";
            this.lblCheckStandard.Text = _pcic.mCheckStandard;      //�ʼ��׼
            this.lblInvoiceXOQuantity.Text = _pcic.InvoiceXOQuantity.HasValue ? _pcic.InvoiceXOQuantity.Value.ToString() : "";
            this.lbl_ProuductUnit.Text = _pcic.ProductUnit == null ? "" : _pcic.ProductUnit.ToString();
            //Details
            this.TCattrDate.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_attrDate, "{0:yyyy-MM-dd}");
            this.TCattrGlassUpL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassUpLDis);
            this.TCattrGlassUpR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassUpRDis);
            this.TCattrGlassDownL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassDownLDis);
            this.TCattrGlassDownR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassDownRDis);
            this.TCattrGlassLeftL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassLeftLDis);
            this.TCattrGlassLeftR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassLeftRDis);
            this.TCattrGlassRightL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassRightLDis);
            this.TCattrGlassRightR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGlassRightRDis);
            this.TCattrCentralL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrCentralLDis);
            this.TCattrCentralR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrCentralRDis);
            this.TCattrNoseCentral.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrNoseCentralDis);
            this.TCattrGuanZui.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrGuanZuiDis);
            this.TCattrJieHenL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrJieHenLDis);
            this.TCattrJieHenR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrJieHenRDis);
            this.TCattrWingL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrWingLDis);
            this.TCattrWingR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrWingRDis);
            this.TCattr_15L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr_15LDis);
            this.TCattr_15R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr_15RDis);
            this.TCattr0L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr0LDis);
            this.TCattr0R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr0RDis);
            this.TCattr15L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr15LDis);
            this.TCattr15R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr15RDis);
            this.TCattr30L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr30LDis);
            this.TCattr30R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr30RDis);
            this.TCattr45L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr45LDis);
            this.TCattr45R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr45RDis);
            this.TCattr60L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr60LDis);
            this.TCattr60R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr60RDis);
            this.TCattr75L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr75LDis);
            this.TCattr75R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr75RDis);
            this.TCattr90L.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr90LDis);
            this.TCattr90R.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_Attr90RDis);
            this.TCattrFootL.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrFootLDis);
            this.TCattrFootR.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_AttrFootRDis);
            //this.lblBanbie.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_attrBanBie);
            this.RT_retest.DataBindings.Add("Text", this.DataSource, Model.PCImpactCheckDetail.PRO_attrRetest);
        }
    }
}
