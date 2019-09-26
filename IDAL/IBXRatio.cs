using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IBXRatio
    {
        bool Insert(Model.BXRatio ratio);

        IList<Model.BXRatio> Select();

        bool Delete(int ruleId);

        decimal GetRatio(int mPeriodId, string YBH, string hspType);
    }
}
