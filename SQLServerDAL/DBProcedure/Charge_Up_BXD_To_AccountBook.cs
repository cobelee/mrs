using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Charge_Up_BXD_To_AccountBook .
    /// </summary>
    public class Charge_Up_BXD_To_AccountBook
    {

        public string Text = "Charge_Up_BXD_To_AccountBook";

        public SqlParameter PARM_Cashier = new SqlParameter("@Cashier", SqlDbType.NChar, 20
);
    }
}
