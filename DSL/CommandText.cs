using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.DSL
{
    public class CommandText
    {
        public static string SELECT_HSPTYPE = "Select_HspType";
        public static string SELECT_HSPTYPE_BY_ID = "Select_HspType_By_Id";
        public static string INSERT_HSPTYPE = "Insert_HspType";
        public static string UPDATE_HSPTYPE = "Update_HspType";
        public static string DELETE_HSPTYPE = "Delete_HspType";

        public static string SELECT_PSNTYPE = "Select_PsnType";
        public static string INSERT_PSNTYPE = "Insert_PsnType";
        public static string UPDATE_PSNTYPE = "Update_PsnType";
        public static string DELETE_PSNTYPE = "Delete_PsnType";

        public static string SELECT_MPERIOD = "Select_MPeriod";
        public static string INSERT_MPERIOD = "Insert_MPeriod";
        public static string UPDATE_MPERIOD = "Update_MPeriod";
        public static string DELETE_MPERIOD = "Delete_MPeriod";

        public static string SELECT_ACCOUNT = "Select_Account";
        public static string SELECT_ACCOUNT_BY_USERNAME = "Select_Account_By_UserName";
        public static string INSERT_ACCOUNT = "Insert_Account";
        public static string UPDATE_ACCOUNT = "Update_Account";
        public static string DELETE_ACCOUNT = "Delete_Account";

        public static string SELECT_BXD_BY_BXDID = "Select_BXD_BY_BXDId";
        public static string SELECT_BXD_BY_YBH = "Select_BXD_BY_YBH";
        public static string SELECT_BXD_TO_CHARGE_UP = "Select_BXD_To_Charge_Up";
        public static string INSERT_BXD = "Insert_BXD";
        public static string UPDATE_BXD = "Update_BXD";
        public static string DELETE_BXD = "Delete_BXD";
        public static string SAVE_BXMX_STAT_TO_BXD = "Save_BXMX_Stat_To_BXD";

        public static string SELECT_BXMX_BY_BXDID = "Select_BXMX_By_BXDId";
        public static string INSERT_BXMX = "Insert_BXMX";
        public static string UPDATE_BXMX = "Update_BXMX";
        public static string DELETE_BXMX = "Delete_BXMX";

        public static string SELECT_ACCOUNT_BOOK_PAYMENT_LIST = "Select_AccountBook_PaymentList";

        public static string CREATE_BX_WARRANT = "Create_BX_Warrant";
        public static string CHARGE_UP_BXD_TO_ACCOUNTBOOK = "Charge_Up_BXD_To_AccountBook";
        public static string REPORT_ZHJFYLF_STAT = "Report_ZHJFYLF_Stat";        //综合减负医疗费报告
    }
}
