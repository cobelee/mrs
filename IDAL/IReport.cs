using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IReport
    {
        /// <summary>
        /// 获取公司补充医保资金历年使用情况报告。
        /// </summary>
        /// <returns></returns>
        DataTable GetReportZJLNSYQK();

        /// <summary>
        /// 获取公司补充医保资金季度使用情况报告。
        /// </summary>
        /// <returns></returns>
        DataTable GetReportZJJDSYQK(int mPeriodId);

        /// <summary>
        /// 获取个人历年报销情况报告
        /// </summary>
        /// <param name="ybh">医保号</param>
        /// <returns></returns>
        DataTable GetReportGRLNBX(string ybh);
    }
}
