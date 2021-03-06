using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Select_BXD_BY_YBH .
    /// </summary>
    public class Select_BXD_BY_YBH
    {

        public string Text = "Select_BXD_BY_YBH";

        public SqlParameter PARM_YBH = new SqlParameter("@YBH", SqlDbType.NChar, 20
);
        public SqlParameter PARM_BeginDate = new SqlParameter("@BeginDate", SqlDbType.DateTime, 8
);
        public SqlParameter PARM_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime, 8
);
    }
}
