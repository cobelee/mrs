using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IAccountBook
    {
        bool Charge_Up_BXD_To_AccountBook(string Cashier);

        IList<MRS.Model.AccountBook> Select_AccountBook_PaymentList(DateTime BeginDate, DateTime EndDate);


        /// <summary>
        /// 综合减负医药费报告
        /// </summary>
        /// <param name="mPeriodId">医保年度Id.</param>
        /// <param name="?"></param>
        /// <returns></returns>
        DataTable Create_Report_ZHJFYLF_Stat(int mPeriodId, decimal zhjfylf_greater_than);

        /// <summary>
        /// 综合减负医药费报告,按选定月份统计。
        /// </summary>
        /// <param name="beginDate">开始日期时间（包括）</param>
        /// <param name="endDate">结束日期时间（不包括）</param>
        /// <param name="zhjfylf_greater_than">大于此综合减负医药费</param>
        /// <returns></returns>
        DataTable Create_Report_ZHJFYLF_Stat_ByMonth(DateTime beginDate, DateTime endDate, decimal zhjfylf_greater_than);
    }
}
