using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

public partial class UserControls_PersonInfo : System.Web.UI.UserControl
{
    protected PMS.BLL.MedicarePerson bll_MedicarePerson = new PMS.BLL.MedicarePerson();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void ShowInfo(string medicareId)
    {
        PMS.Model.MedicarePerson mp = new PMS.Model.MedicarePerson();
        mp = bll_MedicarePerson.GetMedicarePerson(medicareId);

        if (mp.Name == "")
        {
            tablePersonInfo.Visible = false;
            message.Visible = true;
            ltlBXPersonName.Text = "数据库中无此人";
            ltlMedicareId.Text = string.Empty;
            ltlJobNumber.Text = string.Empty;
            ltlIdentityCard.Text = string.Empty;
            ltlBirthday.Text = string.Empty;
            ltlOrganization.Text = string.Empty;
            ltlSex.Text = string.Empty;
            ltlPsnType.Text = string.Empty;
            ltlBankAccount.Text = string.Empty;
        }
        else
        {
            tablePersonInfo.Visible = true;
            message.Visible = false;
            ltlBXPersonName.Text = mp.Name;
            ltlMedicareId.Text = mp.MedicareId;
            ltlJobNumber.Text = mp.JobNumber;
            ltlIdentityCard.Text = mp.IdentityCard;
            ltlBirthday.Text = mp.Birthday.ToShortDateString();
            ltlOrganization.Text = mp.Organization;
            ltlSex.Text = mp.Sex;
            ltlPsnType.Text = mp.PsnType;

            string strBA = mp.BankAccount;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < strBA.Length; i++)
            {
                if (i % 4 == 0)
                    sb.Append(" ");
                sb.Append(strBA[i]);
            }
            ltlBankAccount.Text = sb.ToString();
        }
    }
}
