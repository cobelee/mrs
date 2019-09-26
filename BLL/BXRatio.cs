using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.BLL
{
    public class BXRatio
    {
        IDAL.IBXRatio dal = DALFactory.DataAccess.CreateBXRatio();

        public bool Insert(MRS.Model.BXRatio ratio)
        {
            return dal.Insert(ratio);
        }

        public IList<MRS.Model.BXRatio> Select()
        {
            return dal.Select();
        }

        public bool Delete(int ruleId)
        {
            return dal.Delete(ruleId);
        }

        /// <summary>
        /// 获取当前报销比例。
        /// </summary>
        /// <param name="mPeriodId">医保年度。</param>
        /// <param name="YBH">医保号。</param>
        /// <param name="hspType">就诊方式。</param>
        /// <returns></returns>
        public decimal GetRatio(int mPeriodId, string YBH, string hspType)
        {
            return dal.GetRatio(mPeriodId, YBH, hspType);
        }
    }
}
