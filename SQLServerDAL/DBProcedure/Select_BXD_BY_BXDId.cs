using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Select_BXD_BY_BXDId .
    /// </summary>
    public class Select_BXD_BY_BXDId
    {

        public string Text = "Select_BXD_BY_BXDId";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
    }
}
