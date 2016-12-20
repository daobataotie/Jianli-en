﻿//------------------------------------------------------------------------------
//
// file name：PCOtherCheckDetailAccessor.cs
// author: mayanjun
// create date：2011-11-10 15:05:57
//
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Book.DA.SQLServer
{
    /// <summary>
    /// Data accessor of PCOtherCheckDetail
    /// </summary>
    public partial class PCOtherCheckDetailAccessor : EntityAccessor, IPCOtherCheckDetailAccessor
    {
        public IList<Book.Model.PCOtherCheckDetail> Selct(Book.Model.PCOtherCheck _Pcoc)
        {
            return sqlmapper.QueryForList<Model.PCOtherCheckDetail>("PCOtherCheckDetail.select_byPCOtherCheckId", _Pcoc.PCOtherCheckId);
        }

        public void DeleteByPCOCId(string pcocId)
        {
            sqlmapper.Delete("PCOtherCheckDetail.DeleteByPCOCId", pcocId);
        }

        public string SelectByInvoiceCusID(string ID)
        {
            //return sqlmapper.QueryForObject<string>("PCOtherCheckDetail.SelectByInvoiceCusID", ID);
            string sql = "select distinct Cast(PCOtherCheckId as varchar) + ' ' from PCOtherCheckDetail where FromInvoiceID in (select InvoiceId from InvoiceCGDetail where InvoiceCOId in (select InvoiceId from InvoiceCO where InvoiceXOId=(select InvoiceId from InvoiceXO where CustomerInvoiceXOId='" + ID + "'))) or FromInvoiceID in (select ProduceOtherInDepotId from ProduceOtherInDepotDetail where ProduceOtherCompactId in (select ProduceOtherCompactId from ProduceOtherCompact where InvoiceXOId =(select InvoiceId from InvoiceXO where CustomerInvoiceXOId='" + ID + "'))) for xml path('')";
            if (SQLDB.SqlHelper.ExecuteScalar(sqlmapper.DataSource.ConnectionString, CommandType.Text, sql, null) != DBNull.Value && SQLDB.SqlHelper.ExecuteScalar(sqlmapper.DataSource.ConnectionString, CommandType.Text, sql, null) != null)
                return SQLDB.SqlHelper.ExecuteScalar(sqlmapper.DataSource.ConnectionString, CommandType.Text, sql, null).ToString();
            else
                return null;
        }
    }
}
