using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Select_BXMX_By_BxmxId .
    /// </summary>
    public class Select_BXMX_By_BxmxId
    {

        public string Text = "Select_BXMX_By_BxmxId";

        public SqlParameter PARM_BxmxId = new SqlParameter("@BxmxId", SqlDbType.Int);
    }
}
