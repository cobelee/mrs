using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Update_MPeriod .
    /// </summary>
    public class Update_MPeriod
    {

        public string Text = "Update_MPeriod";

        public SqlParameter PARM_Id = new SqlParameter("@Id", SqlDbType.Int);
        public SqlParameter PARM_Name = new SqlParameter("@Name", SqlDbType.NChar, 256
);
        public SqlParameter PARM_BeginDate = new SqlParameter("@BeginDate", SqlDbType.DateTime, 8
);
        public SqlParameter PARM_EndDate = new SqlParameter("@EndDate", SqlDbType.DateTime, 8
);
    }
}
