using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Delete_MPeriod .
    /// </summary>
    public class Delete_MPeriod
    {

        public string Text = "Delete_MPeriod";

        public SqlParameter PARM_Id = new SqlParameter("@Id", SqlDbType.Int);
    }
}
