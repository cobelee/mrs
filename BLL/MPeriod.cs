using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using System.ComponentModel;

namespace MRS.BLL
{
    public class MPeriod
    {
        private IMPeriod dalMPeriod = MRS.DALFactory.DataAccess.CreateMPeriod();

        public BindingList<MRS.Model.MPeriod> GetMPeriodAll()
        {
            BindingList<MRS.Model.MPeriod> bindMPeriod = new BindingList<MRS.Model.MPeriod>();
            IList<MRS.Model.MPeriod> listMPeriod = dalMPeriod.GetMPeriod();
            foreach (MRS.Model.MPeriod m in listMPeriod)
            {
                bindMPeriod.Add(m);
            }
            return bindMPeriod;
            //return dalMPeriod.GetMPeriod();
        }

        public void AddMPeriod(string Name, DateTime BeginDate, DateTime EndDate)
        {
            dalMPeriod.InsertMPeriod(Name, BeginDate, EndDate);
        }

        public void UpdateMPeriod(int Id, string Name, DateTime BeginDate, DateTime EndDate)
        {
            dalMPeriod.UpdateMPeriod(Id, Name, BeginDate, EndDate);
        }

        public void DeleteMPeriod(int Id)
        {
            dalMPeriod.DeleteMPeriod(Id);
        }
    }
}
