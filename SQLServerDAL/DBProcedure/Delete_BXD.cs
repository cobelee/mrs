using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Delete_BXD .
    /// </summary>
    public class Delete_BXD
    {

        public string Text = "Delete_BXD";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
    }
}
