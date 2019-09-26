using System;
using System.Collections.Generic;
using System.Text;
using MRS.Model;

namespace MRS.IDAL
{
    public interface IMPeriod
    {
        /// <summary>
        /// 获取所有医保年度列表。
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.MPeriod> GetMPeriod();

        void InsertMPeriod(string Name, DateTime BeginDate, DateTime EndDate);

        void UpdateMPeriod(int Id, string Name, DateTime BeginDate, DateTime EndDate);

        void DeleteMPeriod(int Id);
    }
}
