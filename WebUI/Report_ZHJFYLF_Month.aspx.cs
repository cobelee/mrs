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

public partial class Report_ZHJFYLF_Month : System.Web.UI.Page
{
    MRS.BLL.AccountBook bll_accountBook = new MRS.BLL.AccountBook();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Init_data();
        }
    }

    private void Init_data()
    {
        for (int i = 0; i < 24; i++)
        {
            DateTime month = System.DateTime.Now.AddMonths(-i);
            ListItem item = new ListItem(month.ToString("yyyy年MM月"), month.Date.ToString());
            ddlBeginDate.Items.Add(item);
        }
        ddlBeginDate.Items.Insert(0, new ListItem("== 选择到期月份 =="));
        ddlBeginDate.SelectedIndex = 0;


        for (int i = 0; i < 24; i++)
        {
            DateTime month = System.DateTime.Now.AddMonths(-i);
            ListItem item = new ListItem(month.ToString("yyyy年MM月"), month.Date.ToString());
            ddlEndDate.Items.Add(item);
        }
        ddlEndDate.Items.Insert(0, new ListItem("== 选择到期月份 =="));
        ddlEndDate.SelectedIndex = 0;
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        DateTime beginDate = new DateTime();
        DateTime.TryParse(ddlBeginDate.SelectedValue, out beginDate);
        beginDate = new DateTime(beginDate.Year, beginDate.Month, 1);

        DateTime endDate = new DateTime();
        DateTime.TryParse(ddlEndDate.SelectedValue, out endDate);
        endDate = new DateTime(endDate.Year, endDate.Month, 1);
        endDate = endDate.AddMonths(1);
        Literal1.Text = beginDate.ToString() + " 到 " + endDate.ToString();

        decimal z = 0;
        decimal.TryParse(tbYLF.Text, out z);

        gvZHJFYLF.DataSource = bll_accountBook.Create_Report_ZHJFYLF_Stat_ByMonth(beginDate, endDate, z);
        gvZHJFYLF.DataBind();
    }
}
