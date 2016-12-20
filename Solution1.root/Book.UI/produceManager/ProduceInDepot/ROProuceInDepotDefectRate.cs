using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Book.UI.produceManager.ProduceInDepot
{
    public partial class ROProuceInDepotDefectRate : DevExpress.XtraReports.UI.XtraReport
    {
        public ROProuceInDepotDefectRate()
        {
            InitializeComponent();
        }

        public ROProuceInDepotDefectRate(ChooseDefectRateCls condition)
            : this()
        {
            if (!condition.attrJiLuFangShi)
            {
                this.TCRiQi_H.WidthF = 400;
                this.TCRiQi.WidthF = 400;
            }

            //CompanyInfo
            this.lblCompanyName.Text = BL.Settings.CompanyChineseName;
            this.lblReportDate.Text += DateTime.Now.ToString("yyyy-MM-dd");

            string PrintYearAndMonth = condition.StartDate.ToString("yyyy-MM-dd") + "~" + condition.EndDate.AddDays(-1).ToString("yyyy-MM-dd");

            switch (condition.attrProductStates)
            {
                case 0:
                    this.lblReportName.Text = PrintYearAndMonth + "���a�����yӋ��";
                    break;
                case 1:
                    this.lblReportName.Text = "���B" + PrintYearAndMonth + "�����yӋ��";
                    break;
                case 2:
                    this.lblReportName.Text = "����" + PrintYearAndMonth + "�����yӋ��";
                    break;
            }

            this.lblDateRange.Text = PrintYearAndMonth;
            if (!(condition.StartWorkHouse == null && condition.EndWorkHouse == null))
            {
                if (condition.StartWorkHouse != null && condition.EndWorkHouse != null)
                    this.lblWorkHouseRange.Text = condition.StartWorkHouse.Workhousename + "~" + condition.EndWorkHouse.Workhousename;
                else
                    this.lblWorkHouseRange.Text = condition.StartWorkHouse == null ? condition.EndWorkHouse.Workhousename : condition.StartWorkHouse.Workhousename;
            }

            string ProductAttrs = string.Empty;
            ProductAttrs += condition.attrQiangHua ? "���� " : "";
            ProductAttrs += condition.attrWuDu ? "�F��" : "";
            ProductAttrs += condition.attrWuQiangHuaWuDu ? "�o�����F��" : "";
            this.lblProductAttrRange.Text = ProductAttrs;

            this.lblJiLuFangShi.Text = condition.attrJiLuFangShi ? "չ�_" : "�ρ�";


            //IList<Model.ProduceInDepotDetail> deitals = new BL.ProduceInDepotDetailManager().Select_ChooseDefectRateCls(condition.StartDate, condition.EndDate, condition.StartProduceInDepotId, condition.EndProduceInDepotId, condition.StartProduct, condition.EndProduct, condition.StartPronoteHeaderId, condition.EndPronoteHeaderId, condition.StartWorkHouse, condition.EndWorkHouse, condition.StartCustomer, condition.EndCustomer, condition.attrJiLuFangShi, condition.attrQiangHua, condition.attrWuDu, condition.attrWuQiangHuaWuDu, condition.attrProductStates, condition.RejectionRate, condition.RejectionRateCompare, condition.EnableBLV);

            //�����ϼ�Total
            DataTable dat = new BL.ProduceInDepotDetailManager().SUMDTSelect_ChooseDefectRateCls(condition.DateType, condition.StartDate, condition.EndDate, condition.StartProduceInDepotId, condition.EndProduceInDepotId, condition.StartProduct, condition.EndProduct, condition.StartPronoteHeaderId, condition.EndPronoteHeaderId, condition.StartWorkHouse, condition.EndWorkHouse, condition.StartCustomer, condition.EndCustomer, condition.attrJiLuFangShi, condition.attrQiangHua, condition.attrWuDu, condition.attrWuQiangHuaWuDu, condition.attrProductStates, condition.RejectionRate, condition.RejectionRateCompare, condition.EnableBLV, condition.attrOrderColumn, condition.attrOrderType, null, null, condition.InvoiceStates);

            //�󶨾�������
            DataTable dt = new BL.ProduceInDepotDetailManager().DTSelect_ChooseDefectRateCls(condition.DateType, condition.StartDate, condition.EndDate, condition.StartProduceInDepotId, condition.EndProduceInDepotId, condition.StartProduct, condition.EndProduct, condition.StartPronoteHeaderId, condition.EndPronoteHeaderId, condition.StartWorkHouse, condition.EndWorkHouse, condition.StartCustomer, condition.EndCustomer, condition.attrJiLuFangShi, condition.attrQiangHua, condition.attrWuDu, condition.attrWuQiangHuaWuDu, condition.attrProductStates, condition.RejectionRate, condition.RejectionRateCompare, condition.EnableBLV, condition.attrOrderColumn, condition.attrOrderType, null, null, condition.InvoiceStates);

            if (dt == null || dt.Rows.Count == 0 || dat == null || dat.Rows.Count == 0)
                throw new Helper.InvalidValueException("�oӛ�");

            this.DataSource = dt;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dat.Rows.Count; i++)
            {
                sb.Append(dat.Rows[i]["Workhousename"] + "�������a������" + dat.Rows[i]["ProceduresSum"] + " �ϸ�����" + dat.Rows[i]["CheckOutSum"] + " �����ʣ�" + dat.Rows[i]["RejectionRate_1"] + "\t");
            }

            this.lblworkHouseData.Text = sb.ToString();

            //����ͳ��
            //this.lblworkHouseData.DataBindings.Add("Text",this.DataSource)
            //Details
            this.TCRiQi.DataBindings.Add("Text", this.DataSource, "ProduceInDepotDate");
            this.TCpingming.DataBindings.Add("Text", this.DataSource, "ProductName");
            this.TCgongsibumeng.DataBindings.Add("Text", this.DataSource, "Workhousename");
            this.TCfangwuqinghua.DataBindings.Add("Text", this.DataSource, "ProductWDQHua");
            this.TCProductType.DataBindings.Add("Text", this.DataSource, "ProductType");
            this.TCshuliang.DataBindings.Add("Text", this.DataSource, "ProceduresSum");
            this.TChegeshuliang.DataBindings.Add("Text", this.DataSource, "CheckOutSum");
            this.TCbulianglv.DataBindings.Add("Text", this.DataSource, "RejectionRate_1");
            this.TCdanwei.DataBindings.Add("Text", this.DataSource, "ProductUnit");
            this.TCmYuanliaowenti.DataBindings.Add("Text", this.DataSource, "mYuanliaowenti");
            this.TCmChouliaowenti.DataBindings.Add("Text", this.DataSource, "mChouliaowenti");
            this.TCmPaoguanwenti.DataBindings.Add("Text", this.DataSource, "mPaoguanwenti");
            this.TCmJingdiangudingdian.DataBindings.Add("Text", this.DataSource, "mJingdiangudingdian");
            this.TCmChapiancashang.DataBindings.Add("Text", this.DataSource, "mChapiancashang");
            this.TCmWanMocashang.DataBindings.Add("Text", this.DataSource, "mWanMocashang");
            this.TCmGuaiShouZhuangShang.DataBindings.Add("Text", this.DataSource, "mGuaiShouZhuangShang");
            this.TCmHuabancashang.DataBindings.Add("Text", this.DataSource, "mHuabancashang");
            this.TCmGuohuojizhua.DataBindings.Add("Text", this.DataSource, "mGuohuojizhua");
            this.TCmBaiyanHeiYan.DataBindings.Add("Text", this.DataSource, "mBaiyanHeiYan");
            this.TCmJieHeXianHuiwen.DataBindings.Add("Text", this.DataSource, "mJieHeXianHuiwen");
            this.TCmSuoShui.DataBindings.Add("Text", this.DataSource, "mSuoShui");
            this.TCmQiPao.DataBindings.Add("Text", this.DataSource, "mQiPao");
            this.TCmShechuqita.DataBindings.Add("Text", this.DataSource, "mShechuqita");
            this.TCmCaMoSunHua.DataBindings.Add("Text", this.DataSource, "mCaMoSunHua");
            this.TCmChaipiancashang.DataBindings.Add("Text", this.DataSource, "mChaipiancashang");
            this.TCmHeidianzazhi.DataBindings.Add("Text", this.DataSource, "mHeidianzazhi");
            this.TCmQianghuaqiancashang.DataBindings.Add("Text", this.DataSource, "mQianghuaqiancashang");
            this.TCmQianghuahoucashang.DataBindings.Add("Text", this.DataSource, "mQianghuahoucashang");
            this.TCmHanyao.DataBindings.Add("Text", this.DataSource, "mHanyao");
            this.TCmKeLimianxu.DataBindings.Add("Text", this.DataSource, "mKeLimianxu");
            this.TCmLiuheng.DataBindings.Add("Text", this.DataSource, "mLiuheng");
            this.TCmPengYaodiyao.DataBindings.Add("Text", this.DataSource, "mPengYaodiyao");
            this.TCmQianghuafangwuxian.DataBindings.Add("Text", this.DataSource, "mQianghuafangwuxian");
            this.TCmYoudian.DataBindings.Add("Text", this.DataSource, "mYoudian");
            this.TCmQianghuaQiTa.DataBindings.Add("Text", this.DataSource, "mQianghuaQiTa");
            this.TCmChangshangbuliang.DataBindings.Add("Text", this.DataSource, "mChangshangbuliang");
            this.TCmZuzhuangcashang.DataBindings.Add("Text", this.DataSource, "mZuzhuangcashang");
            this.TCmCashang.DataBindings.Add("Text", this.DataSource, "mCashang");

            #region ע�Ͱ�List
            //if (deitals == null || deitals.Count == 0)
            //    return;

            //if (condition.attrJiLuFangShi)
            //{
            //    foreach (Model.ProduceInDepotDetail d in deitals)
            //    {
            //        d.ProInDepotDetailDate = d.ProduceInDepot.ProduceInDepotDate.Value.ToString("yyyy-MM-dd");
            //        d.RejectionRate_1 = (d.NoHegeQuantity / (d.ProceduresSum.HasValue && d.ProceduresSum != 0 ? d.ProceduresSum : 1)).Value.ToString("0.#%");
            //    }
            //    this.DataSource = deitals;
            //}
            //else
            //{
            //    this.TCRiQi_H.WidthF = 310;
            //    this.TCRiQi.WidthF = 310;
            //    //�ϲ�
            //    IList<Model.ProduceInDepotDetail> _mDataSource = new List<Model.ProduceInDepotDetail>();

            //    var sumList = from Model.ProduceInDepotDetail item in deitals
            //                  group item by item.ProductId;
            //    foreach (IGrouping<string, Model.ProduceInDepotDetail> outg in sumList)
            //    {
            //        var sumInlist = from Model.ProduceInDepotDetail item in outg
            //                        group item by item.ProduceInDepot.WorkHouseId;
            //        foreach (IGrouping<string, Model.ProduceInDepotDetail> g in sumInlist)
            //        {
            //            Model.ProduceInDepotDetail d = new Book.Model.ProduceInDepotDetail();
            //            d.ProInDepotDetailDate = condition.StartDate.ToString("yyyy#MM#dd").Replace('#', '/') + "-" + condition.EndDate.ToString("yyyy#MM#dd").Replace('#', '/');
            //            d.ProductId = g.First().ProductId;
            //            d.Product = g.First().Product;
            //            d.ProduceInDepotId = g.First().ProduceInDepotId;
            //            d.ProduceInDepot = g.First().ProduceInDepot;
            //            d.ProceduresSum = (from i in g select i.ProceduresSum).Sum();       //��������
            //            d.CheckOutSum = (from i in g select i.CheckOutSum).Sum();           //�ϸ�����
            //            string nocheck = (d.NoHegeQuantity / (d.ProceduresSum.HasValue && d.ProceduresSum != 0 ? d.ProceduresSum : 1)).Value.ToString("0.#%");
            //            d.RejectionRate_1 = nocheck;        //ת����Ĳ�����
            //            d.ProductUnit = g.First().ProductUnit;
            //            d.HeiDian = (from i in g select i.HeiDian).Sum();
            //            d.ZaZhi = (from i in g select i.ZaZhi).Sum();
            //            d.mJinDian = (from i in g select i.mJinDian).Sum();
            //            d.mLiaoDian = (from i in g select i.mLiaoDian).Sum();
            //            d.mCaiShang = (from i in g select i.mCaiShang).Sum();
            //            d.mWanMo = (from i in g select i.mWanMo).Sum();
            //            d.mSuoShui = (from i in g select i.mSuoShui).Sum();
            //            d.mGuohuo = (from i in g select i.mGuohuo).Sum();
            //            d.mBaiYan = (from i in g select i.mBaiYan).Sum();
            //            d.mHeiYan = (from i in g select i.mHeiYan).Sum();
            //            d.HeiDian = (from i in g select i.HeiDian).Sum();
            //            d.mJieHeXian = (from i in g select i.mJieHeXian).Sum();
            //            d.mHuiWen = (from i in g select i.mHuiWen).Sum();
            //            d.mQiPao = (from i in g select i.mQiPao).Sum();
            //            d.mLengLiao = (from i in g select i.mLengLiao).Sum();
            //            d.mGuaiShouZhuangShang = (from i in g select i.mGuaiShouZhuangShang).Sum();
            //            d.mPengXu = (from i in g select i.mPengXu).Sum();
            //            d.mCaMoSunHua = (from i in g select i.mCaMoSunHua).Sum();
            //            d.mCaMoCiShu = (from i in g select i.mCaMoCiShu).Sum();
            //            d.mChaiCa = (from i in g select i.mChaiCa).Sum();
            //            d.mSheCa = (from i in g select i.mSheCa).Sum();
            //            d.mQiangCa = (from i in g select i.mQiangCa).Sum();
            //            d.mKeLi = (from i in g select i.mKeLi).Sum();
            //            d.mLiuheng = (from i in g select i.mLiuheng).Sum();
            //            d.mPengYao = (from i in g select i.mPengYao).Sum();
            //            d.mYuHuoJiZhua = (from i in g select i.mYuHuoJiZhua).Sum();
            //            d.mZaZhiJingDian = (from i in g select i.mZaZhiJingDian).Sum();
            //            d.mQiTa = (from i in g select i.mQiTa).Sum();

            //            _mDataSource.Add(d);
            //        }
            //    }
            //    this.DataSource = _mDataSource;
            //}

            //IList<Model.ProduceInDepotDetail> _orderSource = new List<Model.ProduceInDepotDetail>();

            //switch (condition.attrOrderColumn)
            //{
            //    case 0:
            //        if (condition.attrOrderType == 0)
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.ProduceInDepotDate
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        else
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.ProduceInDepotDate descending
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        break;
            //    case 1:
            //        if (condition.attrOrderType == 0)
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.Product.ProductName
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        else
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.Product.ProductName descending
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        break;
            //    case 2:
            //        if (condition.attrOrderType == 0)
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.WorkHouseHeader.Workhousename
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        else
            //        {
            //            _orderSource = (from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                            orderby d.WorkHouseHeader.Workhousename descending
            //                            select d).ToList<Model.ProduceInDepotDetail>();
            //        }
            //        break;
            //}

            //this.DataSource = _orderSource;

            ////��������ͳ��
            //var _WorkHouseList = from Model.ProduceInDepotDetail d in (this.DataSource as IList<Model.ProduceInDepotDetail>)
            //                     group d by d.ProduceInDepot.WorkHouseId;

            //StringBuilder sb = new StringBuilder();
            //double _mProceduresSum;   //��������
            //double _mCheckOutSum;     //�ϸ�����
            //string _mRejectionRate;    //������
            //foreach (IGrouping<string, Model.ProduceInDepotDetail> g in _WorkHouseList)
            //{
            //    _mProceduresSum = (from i in g select i.ProceduresSum).Sum().HasValue ? (from i in g select i.ProceduresSum).Sum().Value : 0;
            //    _mCheckOutSum = (from i in g select i.CheckOutSum).Sum().HasValue ? (from i in g select i.CheckOutSum).Sum().Value : 0;
            //    _mRejectionRate = ((_mProceduresSum - _mCheckOutSum) / (_mProceduresSum == 0 ? 1 : _mProceduresSum)).ToString("0.#%");

            //    sb.Append(g.First().WorkHouseHeader == null ? "" : g.First().WorkHouseHeader.Workhousename + ":  �����a����:  " + _mProceduresSum + " �ϸ���:  " + _mCheckOutSum.ToString() + " ������:  " + _mRejectionRate + "\t");
            //}

            //this.lblworkHouseData.Text = sb.ToString();



            ////Details
            //this.TCRiQi.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_ProInDepotDetailDate);
            //this.TCpingming.DataBindings.Add("Text", this.DataSource, "Product." + Model.Product.PRO_ProductName);
            ////this.TCriqi.DataBindings.Add("Text", this.DataSource, "ProduceInDepot." + Model.ProduceInDepot.PRO_ProduceInDepotDate);
            //this.TCshuliang.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_ProceduresSum);
            //this.TChegeshuliang.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_CheckOutSum);
            //this.TCbulianglv.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_RejectionRate_1);
            //this.TCdanwei.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_ProductUnit);
            //this.TCheidian.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_HeiDian);
            //this.TCzazhi.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_ZaZhi);
            //this.TCjindian.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mJinDian);
            //this.TCliaodian.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mLiaoDian);
            //this.TCcashang.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mCaiShang);
            //this.TCwanmo.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mWanMo);
            //this.TCsuoshui.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mSuoShui);
            //this.TCguohuo.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mGuohuo);
            //this.TCbaiyan.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mBaiYan);
            //this.TCheiyan.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mHeiYan);
            //this.TCjiehexian.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mJieHeXian);
            //this.TChuiwen.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mHuiWen);
            //this.TCqipao.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mQiPao);
            //this.TClengliao.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mLengLiao);
            //this.TCguaishouzhuangshang.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mGuaiShouZhuangShang);
            //this.TCpenxu.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mPengXu);
            //this.TCcamosunhuai.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mCaMoSunHua);
            //this.TCcamocishu.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mCaMoCiShu);
            //this.TCmChaiCa.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mChaiCa);
            //this.TCmSheCa.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mSheCa);
            //this.TCmQiangCa.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mQiangCa);
            //this.TCmKeLi.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mKeLi);
            //this.TCmLiuheng.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mLiuheng);
            //this.TCmPengYao.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mPengYao);
            //this.TCmYuHuoJiZhua.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mYuHuoJiZhua);
            //this.TCmZaZhiJingDian.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mZaZhiJingDian);
            //this.TCqita.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_mQiTa);
            //this.TCgongsibumeng.DataBindings.Add("Text", this.DataSource, "ProduceInDepot.WorkHouse." + Model.WorkHouse.PROPERTY_WORKHOUSENAME);
            //this.TCfangwuqinghua.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_PID_ProductWDQHua);
            //this.TCProductType.DataBindings.Add("Text", this.DataSource, Model.ProduceInDepotDetail.PRO_PID_ProductType);
            #endregion
        }
    }
}
