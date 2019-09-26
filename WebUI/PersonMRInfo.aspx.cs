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

public partial class PersonMRInfo : System.Web.UI.Page
{
    protected PMS.BLL.MedicarePerson bll_mPerson = new PMS.BLL.MedicarePerson();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ltlDateTime.Text = System.DateTime.Now.ToLongDateString();
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        if (tbMedicareId.Text != string.Empty)
        {
            PersonInfo1.ShowInfo(tbMedicareId.Text);
        }
    }
}
