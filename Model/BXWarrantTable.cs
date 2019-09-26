using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    public class BXWarrantTable : DataTable
    {
        private int mBXDId;

        public BXWarrantTable()
        {
            InitBXWarrantTable();
        }

        private void InitBXWarrantTable()
        {
            this.Columns.Add("OrderIndex");
            this.Columns.Add("JZFS");
            this.Columns.Add("YYF");
            this.Columns.Add("BXJE");
            this.Columns.Add("ZLF");
            this.Columns.Add("TCJJ");
            this.Columns.Add("GRZFei");
            this.Columns.Add("GRZFu");
        }

        public int BXDId
        {
            get { return mBXDId; }
            set { mBXDId = value; }
        }
    }
}
