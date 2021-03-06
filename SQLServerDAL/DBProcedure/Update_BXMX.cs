using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Update_BXMX .
    /// </summary>
    public class Update_BXMX
    {

        public string Text = "Update_BXMX";

        public SqlParameter PARM_BXMXId = new SqlParameter("@BXMXId", SqlDbType.Int);
        public SqlParameter PARM_FpDate = new SqlParameter("@FpDate", SqlDbType.DateTime, 8
);
        public SqlParameter PARM_YYF = new SqlParameter("@YYF", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFei = new SqlParameter("@GRZFei", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFu = new SqlParameter("@GRZFu", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFuHide = new SqlParameter("@GRZFuHide", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRZFBao = new SqlParameter("@GRZFBao", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_GRCDBao = new SqlParameter("@GRCDBao", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_LNZHBao = new SqlParameter("@LNZHBao", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_TCJJ = new SqlParameter("@TCJJ", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_JZFS = new SqlParameter("@JZFS", SqlDbType.NChar, 20
);
        public SqlParameter PARM_ReimbursementRatio = new SqlParameter("@ReimbursementRatio", SqlDbType.Decimal, 9
);
    }
}
