using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IBXMX
    {
        /// <summary>
        /// 根据报销单Id，获取报销明细列表。
        /// </summary>
        /// <param name="BXDId"></param>
        /// <returns></returns>
        IList<MRS.Model.BXMX> GetBXMX_By_BXDId(int BXDId);

        /// <summary>
        /// 根据报销明细Id，获取报销明细记录。
        /// </summary>
        /// <param name="bxmxId">报销明细记录号。</param>
        /// <returns></returns>
        MRS.Model.BXMX GetBxmx_By_BxmxId(int bxmxId);

        void InsertBXMX(MRS.Model.BXMX bxmx);

        void UpdateBXMX(MRS.Model.BXMX bxmx);

        void DeleteBXMX(int BXMXId);
    }
}
