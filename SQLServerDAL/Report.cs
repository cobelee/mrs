using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using MRS.DSL;
using Common.DBUtility;

namespace MRS.SQLServerDAL
{
    public class Report:IReport
    {
        #region IReport ��Ա
        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ�����ʹ��������档
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJLNSYQK()
        {
            DataTable report = new DataTable("ZJLNSYQK");
            DBProcedure.Report_ZJLNSYQK prdCmdText = new DBProcedure.Report_ZJLNSYQK();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);

            using (SqlDataReader reader = prdHelper.ExecuteReader())
            {
                SqlDataReaderHelper rdHelper = new SqlDataReaderHelper(reader);
                rdHelper.LoopReadToTable(out report);
            }
            prdHelper.Dispose();
            return report;
        }

        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ𼾶�ʹ��������档
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJJDSYQK(int mPeriodId)
        {
            DataTable report = new DataTable("ZJJDSYQK");
            DBProcedure.Report_ZJJDSYQK prdCmdText = new DBProcedure.Report_ZJJDSYQK();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);
            prdHelper.SetInputValue(prdCmdText.PARM_MPeriodId.ParameterName, mPeriodId);

            using (SqlDataReader reader = prdHelper.ExecuteReader())
            {
                SqlDataReaderHelper rdHelper = new SqlDataReaderHelper(reader);
                rdHelper.LoopReadToTable(out report);
            }
            prdHelper.Dispose();
            return report;
        }

        /// <summary>
        /// ��ȡ�������걨���������
        /// </summary>
        /// <param name="ybh">ҽ����</param>
        /// <returns></returns>
        public DataTable GetReportGRLNBX(string ybh)
        {
            DataTable report = new DataTable("GRLNBX");
            DBProcedure.Report_GRLNBX prdCmdText = new DBProcedure.Report_GRLNBX();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);
            prdHelper.SetInputValue(prdCmdText.PARM_YBH.ParameterName, ybh);

            using (SqlDataReader reader = prdHelper.ExecuteReader())
            {
                SqlDataReaderHelper rdHelper = new SqlDataReaderHelper(reader);
                rdHelper.LoopReadToTable(out report);
            }
            prdHelper.Dispose();
            return report;
        }

        #endregion
    }
}