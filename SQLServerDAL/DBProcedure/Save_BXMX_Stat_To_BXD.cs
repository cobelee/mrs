using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Save_BXMX_Stat_To_BXD .
    /// </summary>
    public class Save_BXMX_Stat_To_BXD
    {

        public string Text = "Save_BXMX_Stat_To_BXD";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
        public SqlParameter PARM_AttNumber = new SqlParameter("@AttNumber", SqlDbType.Int);
    }
}
