using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Report_ZHJFYLF_Stat .
    /// </summary>
    public class Report_ZHJFYLF_Stat
    {

        public string Text = "Report_ZHJFYLF_Stat";

        public SqlParameter PARM_MPeriodId = new SqlParameter("@MPeriodId", SqlDbType.Int);
        public SqlParameter PARM_ZHJFYLF = new SqlParameter("@ZHJFYLF", SqlDbType.Decimal, 9
);
    }
}
