using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Update_BXD .
    /// </summary>
    public class Update_BXD
    {

        public string Text = "Update_BXD";

        public SqlParameter PARM_BXDId = new SqlParameter("@BXDId", SqlDbType.Int);
        public SqlParameter PARM_AttNumber = new SqlParameter("@AttNumber", SqlDbType.Int);
        public SqlParameter PARM_YYF = new SqlParameter("@YYF", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_BXJE = new SqlParameter("@BXJE", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_ZLF = new SqlParameter("@ZLF", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_TCJJ = new SqlParameter("@TCJJ", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFei = new SqlParameter("@GRZFei", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFu = new SqlParameter("@GRZFu", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFuHide = new SqlParameter("@GRZFuHide", SqlDbType.Decimal, 9
);
    }
}
