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
        /// �ۺϼ���ҽҩ�ѱ���
        /// </summary>
        /// <param name="mPeriodId">ҽ�����Id.</param>
        /// <param name="?"></param>
        /// <returns></returns>
        DataTable Create_Report_ZHJFYLF_Stat(int mPeriodId, decimal zhjfylf_greater_than);
    }
}