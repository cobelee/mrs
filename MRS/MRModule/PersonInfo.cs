using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{
    public partial class PersonInfo : Form
    {
        protected PMS.BLL.MedicarePerson bll_MedicarePerson = new PMS.BLL.MedicarePerson();

        public PersonInfo()
        {
            InitializeComponent();
        }

        public void SetYbh(string ybh)
        {
            tbYBH.Text = ybh;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            PMS.Model.MedicarePerson mp = new PMS.Model.MedicarePerson();
            mp = bll_MedicarePerson.GetMedicarePerson(tbYBH.Text);

            if (mp.Name == "")
            {
                lbBXPersonName.Text = "数据库中无此人";
                lbMedicareId.Text = string.Empty;
                lbJobNumber.Text = string.Empty;
                lbIdentityCard.Text = string.Empty;
                lbBirthday.Text = string.Empty;
                lbOrganization.Text = string.Empty;
                lbSex.Text = string.Empty;
                lbPsnType.Text = string.Empty;
                lbBankAccount.Text = string.Empty;
            }
            else
            {
                this.Text = "医保号:" + tbYBH.Text + "  姓名:" + mp.Name;
                lbBXPersonName.Text = mp.Name;
                lbMedicareId.Text = mp.MedicareId;
                lbJobNumber.Text = mp.JobNumber;
                lbIdentityCard.Text = mp.IdentityCard;
                lbBirthday.Text = mp.Birthday.ToShortDateString();
                lbOrganization.Text = mp.Organization;
                lbSex.Text = mp.Sex;
                lbPsnType.Text = mp.PsnType;

                string strBA = mp.BankAccount;
                System.Text.StringBuilder sb = new StringBuilder();
                for (int i = 0; i < strBA.Length; i++)
                {
                    if (i % 4 == 0)
                        sb.Append(" ");
                    sb.Append(strBA[i]);
                }
                lbBankAccount.Text = sb.ToString();
            }
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            lbBXPersonName.Text = "[姓名]";
            lbMedicareId.Text = string.Empty;
            lbJobNumber.Text = string.Empty;
            lbIdentityCard.Text = string.Empty;
            lbBirthday.Text = string.Empty;
            lbOrganization.Text = string.Empty;
            lbSex.Text = string.Empty;
            lbPsnType.Text = string.Empty;
            lbBankAccount.Text = string.Empty;

            if (!string.IsNullOrEmpty(tbYBH.Text))
            {
                btnQuery.PerformClick();
            }
        }
    }
}