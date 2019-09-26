using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBTable
{
    public class BXRatio
    {
        public string Text = "BXRatio";
        public Column Id = new Column("Id");
        public Column OrderNumber = new Column("OrderNumber");
        public Column MinKBJE = new Column("MinKBJE");
        public Column MaxKBJE = new Column("MaxKBJE");
        public Column HspType = new Column("HspType");
        public Column Ratio = new Column("Ratio");
    }
}
