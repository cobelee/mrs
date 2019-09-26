using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using MRS.Model;

namespace MRS.BLL
{
    public class BXD
    {
        private MRS.IDAL.IBXD dalBXD = MRS.DALFactory.DataAccess.CreateBXD();

        #region IBXD 成员

        public MRS.Model.BXD GetBXD_By_BXDId(int BXDId)
        {
            return dalBXD.GetBXD_By_BXDId(BXDId);
        }

        public IList<MRS.Model.BXD> GetBXD_By_YBH(string YBH, DateTime BeginDate, DateTime EndDate)
        {
            return dalBXD.GetBXD_By_YBH(YBH, BeginDate, EndDate);
        }

        /// <summary>
        /// 从报销单数据表中获取未记账的记录。
        /// </summary>
        /// <returns></returns>
        public IList<MRS.Model.BXD> GetBXD_With_Not_Charge_Up()
        {
            return dalBXD.GetBXD_Not_Charge_Up();
        }

        public int CreateBXD(MRS.Model.BXD bxd)
        {
            return dalBXD.CreateBXD(bxd);
        }

        public void UpdateBXD(MRS.Model.BXD bxd)
        {
            dalBXD.UpdateBXD(bxd);
        }

        public void Save_BXMX_Stat_To_BXD(int BXDId, int AttNumber)
        {
            dalBXD.Save_BXMX_Stat_To_BXD(BXDId,AttNumber);
        }

        public void Save_BXMX_Stat_To_BXD(int bxdId)
        {
            BLL.BXMX bll_bxmx = new BXMX();
            int attCount = 0;
            attCount = bll_bxmx.GetBXMX_By_BXDId(bxdId).Count + 1;

            dalBXD.Save_BXMX_Stat_To_BXD(bxdId, attCount);
        }

        public bool DeleteBXD(int BXDId)
        {
            return dalBXD.DeleteBXD(BXDId);
        }

        public MRS.Model.BXWarrantTable CreateBXWarrantTable(int BXDId)
        {
            return dalBXD.CreateBXWarrantTable(BXDId);
        }

        #endregion
    }
}
