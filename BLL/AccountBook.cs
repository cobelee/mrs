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
        /// ������δ���ʵı������Ǽǵ����ʲ���
        /// </summary>
        /// <param name="Cashier">�����ߡ�</param>
        /// <returns></returns>
        public bool Charge_Up_BXD_To_AccountBook(string Cashier)
        {
            return dalAccountBook.Charge_Up_BXD_To_AccountBook(Cashier);
        }

        public IList<MRS.Model.AccountBook> Select_AccountBook_PaymentList(DateTime BeginDate, DateTime EndDate)
        {
            return dalAccountBook.Select_AccountBook_PaymentList(BeginDate, EndDate);
        }

        #region IAccountBook ��Ա

        /// <summary>
        /// ��ȡ�ۺϼ���ҽ�Ʒѱ��档
        /// </summary>
        /// <param name="mPeriodId">ҽ�����Id.</param>
        /// <param name="zhjfylf_greater_than">�ۺϼ���ҽ�Ʒ�ȡֵ���������ڵ��ڸ�ֵ��</param>
        /// <returns></returns>
        public DataTable Create_Report_ZHJFYLF_Stat(int mPeriodId, decimal zhjfylf_greater_than)
        {
            return dalAccountBook.Create_Report_ZHJFYLF_Stat(mPeriodId, zhjfylf_greater_than);
        }

        #endregion
    }
}