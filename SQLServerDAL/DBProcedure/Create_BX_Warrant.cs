using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Create_BX_Warrant .
    /// </summary>
    public class Create_BX_Warrant
    {

        public string Text = "Create_BX_Warrant";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
    }
}
