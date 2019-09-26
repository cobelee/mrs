using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using MRS.Model;

namespace MRS.BLL
{
    public class BXMX
    {
        private MRS.IDAL.IBXMX dalBXMX = MRS.DALFactory.DataAccess.CreateBXMX();

        #region IBXMX 成员

        public IList<MRS.Model.BXMX> GetBXMX_By_BXDId(int BXDId)
        {
            return dalBXMX.GetBXMX_By_BXDId(BXDId);
        }

        /// <summary>
        /// 根据报销明细Id，获取报销明细记录。
        /// </summary>
        /// <param name="bxmxId">报销明细记录号。</param>
        /// <returns></returns>
        public MRS.Model.BXMX GetBxmx_By_BxmxId(int bxmxId)
        {
            return dalBXMX.GetBxmx_By_BxmxId(bxmxId);
        }

        public void AddBXMX(MRS.Model.BXMX bxmx)
        {
            dalBXMX.InsertBXMX(bxmx);
        }

        public void UpdateBXMX(MRS.Model.BXMX bxmx)
        {
            dalBXMX.UpdateBXMX(bxmx);
        }

        public void DeleteBXMX(int BXMXId)
        {
            dalBXMX.DeleteBXMX(BXMXId);
        }

        #endregion
    }
}
