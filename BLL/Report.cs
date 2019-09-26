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
        /// 获取公司补充医保资金历年使用情况报告。
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJLNSYQK()
        {
            return dal.GetReportZJLNSYQK();
        }

        /// <summary>
        /// 获取公司补充医保资金季度使用情况报告。
        /// </summary>
        /// <returns></returns>
        public DataTable GetReportZJJDSYQK(int mPeriodId)
        {
            return dal.GetReportZJJDSYQK(mPeriodId);
        }

        /// <summary>
        /// 获取个人历年报销情况报告
        /// </summary>
        /// <param name="ybh">医保号</param>
        /// <returns></returns>
        public DataTable GetReportGRLNBX(string ybh)
        {
            return dal.GetReportGRLNBX(ybh);
        }
    }
}
