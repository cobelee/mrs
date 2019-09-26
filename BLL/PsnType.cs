using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;

namespace MRS.BLL
{
    public class PsnType
    {
        private IPsnType dalPsnType = MRS.DALFactory.DataAccess.CreatePsnType();

        public IList<MRS.Model.PsnType> GetPsnTypeAll()
        {
            return dalPsnType.GetPsnType();
        }

        public void AddPsnType(string Name)
        {
            dalPsnType.InsertPsnType(Name);
        }

        public void UpdatePsnType(int Id, string Name)
        {
            dalPsnType.UpdatePsnType(Id, Name);
        }

        public void DeletePsnType(int Id)
        {
            dalPsnType.DeletePsnType(Id);
        }
    }
}
