using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Report_ZHJFYLF_Stat_ByMonth .
    /// </summary>
    public class Report_ZHJFYLF_Stat_ByMonth
    {

        public string Text = "Report_ZHJFYLF_Stat_ByMonth";

        public SqlParameter PARM_BeginDate= new SqlParameter("@BeginDate", SqlDbType.DateTime);
        public SqlParameter PARM_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
        public SqlParameter PARM_ZHJFYLF = new SqlParameter("@ZHJFYLF", SqlDbType.Decimal, 9);
    }
}
