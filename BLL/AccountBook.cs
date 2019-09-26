using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;

namespace MRS.BLL
{
    public class AccountBook : IAccountBook
    {
        private IAccountBook dalAccountBook = MRS.DALFactory.DataAccess.CreateAccountBook();

        /// <summary>
        /// 将所有未记帐的报销单登记到记帐簿。
        /// </summary>
        /// <param name="Cashier">记帐者。</param>
        /// <returns></returns>
        public bool Charge_Up_BXD_To_AccountBook(string Cashier)
        {
            return dalAccountBook.Charge_Up_BXD_To_AccountBook(Cashier);
        }

        public IList<MRS.Model.AccountBook> Select_AccountBook_PaymentList(DateTime BeginDate, DateTime EndDate)
        {
            return dalAccountBook.Select_AccountBook_PaymentList(BeginDate, EndDate);
        }

        #region IAccountBook 成员

        /// <summary>
        /// 获取综合减负医疗费报告。
        /// </summary>
        /// <param name="mPeriodId">医保年度Id.</param>
        /// <param name="zhjfylf_greater_than">综合减负医疗费取值条件。大于等于该值。</param>
        /// <returns></returns>
        public DataTable Create_Report_ZHJFYLF_Stat(int mPeriodId, decimal zhjfylf_greater_than)
        {
            return dalAccountBook.Create_Report_ZHJFYLF_Stat(mPeriodId, zhjfylf_greater_than);
        }

        #endregion
    }
}
