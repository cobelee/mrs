using System;
using System.Collections.Generic;
using System.Text;
using MRS.Model;

namespace MRS.IDAL
{
    public interface IPsnType
    {
        /// <summary>
        /// ��ȡ��Ա���.
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.PsnType> GetPsnType();

        void InsertPsnType(string Name);

        void UpdatePsnType(int Id, string Name);

        void DeletePsnType(int Id);
    }
}