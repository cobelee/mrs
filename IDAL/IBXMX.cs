using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IBXMX
    {
        /// <summary>
        /// ���ݱ�����Id����ȡ������ϸ�б���
        /// </summary>
        /// <param name="BXDId"></param>
        /// <returns></returns>
        IList<MRS.Model.BXMX> GetBXMX_By_BXDId(int BXDId);

        /// <summary>
        /// ���ݱ�����ϸId����ȡ������ϸ��¼��
        /// </summary>
        /// <param name="bxmxId">������ϸ��¼�š�</param>
        /// <returns></returns>
        MRS.Model.BXMX GetBxmx_By_BxmxId(int bxmxId);

        void InsertBXMX(MRS.Model.BXMX bxmx);

        void UpdateBXMX(MRS.Model.BXMX bxmx);

        void DeleteBXMX(int BXMXId);
    }
}