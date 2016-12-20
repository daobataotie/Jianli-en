using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Book.UI.produceManager.MRSHeader
{
    public partial class LookDepotDistributed : DevExpress.XtraEditors.XtraForm
    {
        public LookDepotDistributed()
        {
            InitializeComponent();
        }

        public LookDepotDistributed(Model.Product product)
            : this()
        {
            this.Text = "Product:" + product.ProductName + ",inventory distribution";

            System.Data.DataTable dt = new BL.StockManager().SelectDepotDistributedByproduct(product.ProductId);
            double mStockQuantity1 = 0;
            string preDepotName = string.Empty;
            string CurrentDepotName;
            foreach (DataRow r in dt.Rows)
            {
                if (r["Depotname"].ToString() == preDepotName)
                    r["Depotname"] = "";
                else
                    preDepotName = r["Depotname"].ToString();
                mStockQuantity1 += double.Parse(r["StockQuantity1"].ToString());
            }
            DataRow dr;

            dr = dt.NewRow();

            dr[0] = mStockQuantity1.ToString();
            dr[1] = "----------";
            dr[2] = "Total inventory records";
            dt.Rows.InsertAt(dr, 0);

            this.bindingSource1.DataSource = dt;

        }
    }
}