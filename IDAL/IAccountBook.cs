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
    }
}
