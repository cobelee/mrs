using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Select_BXMX_By_BXDId .
    /// </summary>
    public class Select_BXMX_By_BXDId
    {

        public string Text = "Select_BXMX_By_BXDId";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
    }
}
