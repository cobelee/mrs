using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Report_GRLNBX .
    /// </summary>
    public class Report_GRLNBX
    {

        public string Text = "Report_GRLNBX";

        public SqlParameter PARM_YBH = new SqlParameter("@YBH", SqlDbType.NChar, 20
);
    }
}
