using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;

namespace MRS.BLL
{
    public class Report
    {
        IReport dal = MRS.DALFactory.DataAccess.CreateReport();
        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ�����ʹ��������档
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJLNSYQK()
        {
            return dal.GetReportZJLNSYQK();
        }

        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ𼾶�ʹ��������档
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJJDSYQK(int mPeriodId)
        {
            return dal.GetReportZJJDSYQK(mPeriodId);
        }

        /// <summary>
        /// ��ȡ�������걨���������
        /// </summary>
        /// <param name="ybh">ҽ����</param>
        /// <returns></returns>
        public DataTable GetReportGRLNBX(string ybh)
        {
            return dal.GetReportGRLNBX(ybh);
        }
    }
}