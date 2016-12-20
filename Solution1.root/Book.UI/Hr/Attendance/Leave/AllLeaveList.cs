﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Book.UI.Hr.Attendance.Leave
{
    public partial class AllLeaveList : DevExpress.XtraEditors.XtraForm
    {
        BL.LeaveManager leaveManager = new Book.BL.LeaveManager();
        public AllLeaveList()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("LeaveType", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["Id"] = 0;
            dr["LeaveType"] = "All day";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["Id"] = 1;
            dr["LeaveType"] = "Half day AM";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["Id"] = 2;
            dr["LeaveType"] = "Half day PM";
            dt.Rows.Add(dr);

            this.repositoryItemLookUpEdit1.DataSource = dt;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.dateEdit1.EditValue != null)
                this.bindingSource1.DataSource = leaveManager.SelectByDate(this.dateEdit1.DateTime);
            else
            {
                MessageBox.Show("Date cannot be empty！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}