using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Delete_BXMX .
    /// </summary>
    public class Delete_BXMX
    {

        public string Text = "Delete_BXMX";

        public SqlParameter PARM_BXMXId = new SqlParameter("@BXMXId", SqlDbType.Int);
    }
}
