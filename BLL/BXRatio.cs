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
        /// ��ȡ��ǰ����������
        /// </summary>
        /// <param name="mPeriodId">ҽ����ȡ�</param>
        /// <param name="YBH">ҽ���š�</param>
        /// <param name="hspType">���﷽ʽ��</param>
        /// <returns></returns>
        public decimal GetRatio(int mPeriodId, string YBH, string hspType)
        {
            return dal.GetRatio(mPeriodId, YBH, hspType);
        }
    }
}