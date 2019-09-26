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

public partial class Report_ZJJDSYQK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ltlDateTime.Text = System.DateTime.Now.ToLongDateString();
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        ObjectDataSource1.SelectParameters["mPeriodId"].DefaultValue = ddlMPeriod.SelectedValue;
        ReportViewer1.LocalReport.Refresh();
        //ReportViewer1.DataBind();
    }
}
