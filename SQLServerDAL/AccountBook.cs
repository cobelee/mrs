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
    public class AccountBook : IAccountBook
    {
        protected MRS.Model.AccountBook Parse(SqlDataReader Reader)
        {
            MRS.Model.AccountBook accountBook = new MRS.Model.AccountBook();
            accountBook.BXDId = Convert.ToInt32(Reader[DSL.AccountBook.BXDID_FIELD]);
            accountBook.BXDate = Convert.ToDateTime(Reader[DSL.AccountBook.BXDATE_FIELD]);
            accountBook.YBH = Reader[DSL.AccountBook.YBH_FIELD].ToString().Trim();
            accountBook.PsnType = Reader[DSL.AccountBook.PSN_TYPE_FIELD].ToString().Trim();
            accountBook.AttNumber = Convert.ToInt32(Reader[DSL.AccountBook.ATT_NUMBER_FIELD]);
            accountBook.Accountant = Reader[DSL.AccountBook.ACCOUNTANT_FIELD].ToString().Trim();
            accountBook.YYF = Convert.ToDecimal(Reader[DSL.AccountBook.YYF_FIELD]);
            accountBook.BXJE = Convert.ToDecimal(Reader[DSL.AccountBook.BXJE_FIELD]);
            accountBook.ZLF = Convert.ToDecimal(Reader[DSL.AccountBook.ZLF_FIELD]);
            accountBook.TCJJ = Convert.ToDecimal(Reader[DSL.AccountBook.TCJJ_FIELD]);
            accountBook.GRZFei = Convert.ToDecimal(Reader[DSL.AccountBook.GRZFEI_FIELD]);
            accountBook.GRZFu = Convert.ToDecimal(Reader[DSL.AccountBook.GRZFU_FIELD]);
            accountBook.Name = Reader[DSL.AccountBook.NAME_FIELD].ToString().Trim();
            accountBook.JobNumber = Reader[DSL.AccountBook.JOB_NUMBER_FIELD].ToString().Trim();
            accountBook.IdentityCard = Reader[DSL.AccountBook.IDENTITY_CARD_FIELD].ToString().Trim();
            accountBook.Birthday = Convert.ToDateTime(Reader[DSL.AccountBook.BIRTHDAY_FIELD]);
            accountBook.Organization = Reader[DSL.AccountBook.ORGANIZATION_FIELD].ToString().Trim();
            accountBook.Sex = Reader[DSL.AccountBook.SEX_FIELD].ToString().Trim();
            accountBook.ChargeUpSign = Reader[DSL.AccountBook.CHARGE_UP_SIGN_FIELD].ToString().Trim();
            accountBook.ChargeUpDate = Convert.ToDateTime(Reader[DSL.AccountBook.CHARGE_UP_DATE_FIELD]);
            accountBook.Cashier = Reader[DSL.AccountBook.CASHIER_FIELD].ToString().Trim();

            return accountBook;
        }
        #region IAccountBook 成员

        /// <summary>
        /// 将所有未记帐的报销单登记到记帐簿。
        /// </summary>
        /// <param name="Cashier">记帐者。</param>
        /// <returns></returns>
        public bool Charge_Up_BXD_To_AccountBook(string Cashier)
        {
            bool IsChargeUp = false;
            int i;
            SqlParameter cashier_parm = new SqlParameter(DSL.AccountBook.CASHIER_PARM, SqlDbType.NChar, 10);

            cashier_parm.Value = Cashier;

            SqlParameter[] parms = new SqlParameter[1];
            parms.SetValue(cashier_parm, 0);

            i = (int)SqlHelper.ExecuteScalar(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.CHARGE_UP_BXD_TO_ACCOUNTBOOK, parms);

            IsChargeUp = i > 0 ? true : false;
            return IsChargeUp;
        }


        public IList<MRS.Model.AccountBook> Select_AccountBook_PaymentList(DateTime BeginDate, DateTime EndDate)
        {
            IList<MRS.Model.AccountBook> accountBooks = new List<MRS.Model.AccountBook>();

            SqlParameter begin_date_parm = new SqlParameter(DSL.AccountBook.CHARGE_UP_BEGIN_DATE_PARM, SqlDbType.DateTime);
            SqlParameter end_date_parm = new SqlParameter(DSL.AccountBook.CHARGE_UP_END_DATE_PARM, SqlDbType.DateTime);

            begin_date_parm.Value = BeginDate;
            end_date_parm.Value = EndDate;

            SqlParameter[] parms = new SqlParameter[2];
            parms.SetValue(begin_date_parm, 0);
            parms.SetValue(end_date_parm, 1);
            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_ACCOUNT_BOOK_PAYMENT_LIST, parms))
            {
                while (reader.Read())
                {
                    MRS.Model.AccountBook abook = Parse(reader);
                    accountBooks.Add(abook);
                }
            }
            return accountBooks;
        }

        public DataTable Create_Report_ZHJFYLF_Stat(int mPeriodId, decimal zhjfylf_greater_than)
        {
            DataTable report = new DataTable("ZHJFYLF");
            Common.DBUtility.SQLProcedure Procedure = new SQLProcedure(ConnectionString.ConnectionStringMRS, CommandText.REPORT_ZHJFYLF_STAT);
            Procedure.SetInputValue(DSL.AccountBook.MPERIOD_ID_PARM, mPeriodId);
            Procedure.SetInputValue(DSL.AccountBook.ZHJFYLF_PARM, zhjfylf_greater_than);

            Procedure.ExecuteAdapter().Fill(report);
            return report;
        }

        /// <summary>
        /// 综合减负医药费报告,按选定月份统计。
        /// </summary>
        /// <param name="beginDate">开始日期时间（包括）</param>
        /// <param name="endDate">结束日期时间（不包括）</param>
        /// <param name="zhjfylf_greater_than">大于此综合减负医药费</param>
        /// <returns></returns>
        public DataTable Create_Report_ZHJFYLF_Stat_ByMonth(DateTime beginDate, DateTime endDate, decimal zhjfylf_greater_than)
        {
            DataTable report = new DataTable("ZHJFYLF");
            Common.DBUtility.SQLProcedure Procedure = new SQLProcedure(ConnectionString.ConnectionStringMRS, CommandText.REPORT_ZHJFYLF_STAT_BYMONTH);
            Procedure.SetInputValue(DSL.AccountBook.BEGINDATE_PARM, beginDate);
            Procedure.SetInputValue(DSL.AccountBook.ENDDATE_PARM, endDate);
            Procedure.SetInputValue(DSL.AccountBook.ZHJFYLF_PARM, zhjfylf_greater_than);

            Procedure.ExecuteAdapter().Fill(report);
            return report;

        }

        #endregion
    }
}
