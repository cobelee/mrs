<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Report_ZHJFYLF.aspx.cs" Inherits="Report_ZHJFYLF" Title="综合减负医疗费查询" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="post">
        <h2 class="title">
            综合减负医疗费查询</h2>
        <p class="meta">
            <asp:Literal ID="ltlDateTime" runat="server"></asp:Literal>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnQuery">
                    医保年度：<asp:DropDownList ID="ddlMPeriod" runat="server" DataSourceID="odsMPeriod" DataTextField="Name"
                        DataValueField="Id">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsMPeriod" runat="server" SelectMethod="GetMPeriodAll"
                        TypeName="MRS.BLL.MPeriod"></asp:ObjectDataSource>
                    综合减负医疗费大于：<asp:TextBox ID="tbYLF" runat="server" Text="3000"></asp:TextBox>
                    <asp:Button ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click" />
                </asp:Panel>
                <br />
                <asp:GridView ID="gvZHJFYLF" runat="server" DataSourceID="odsZHJFYLF" CellPadding="4"
                    ForeColor="#333333" GridLines="None" Width="100%" AllowSorting="True" AutoGenerateColumns="False">
                    <RowStyle BackColor="#EFF3FB" HorizontalAlign="Right" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="YBH" HeaderText="医保号" SortExpression="YBH" />
                        <asp:BoundField DataField="JobNumber" HeaderText="工号" SortExpression="JobNumber" />
                        <asp:BoundField DataField="Name" HeaderText="姓名" SortExpression="Name" />
                        <asp:BoundField DataField="PsnType" HeaderText="人员类别" SortExpression="PsnType" />
                        <asp:BoundField DataField="ZHJFYLF" HeaderText="综合减负医疗费" SortExpression="ZHJFYLF" />
                        <asp:BoundField DataField="GRZFuTotal" HeaderText="个人自付" SortExpression="GRZFuTotal" />
                        <asp:BoundField DataField="ZLFTotal" HeaderText="自理费" SortExpression="ZLFTotal" />
                        <asp:BoundField DataField="BZJS" HeaderText="补助基数" SortExpression="BZJS" />
                        <asp:BoundField DataField="GRZFeiTotal" HeaderText="个人自费" SortExpression="GRZFeiTotal" />
                        <asp:BoundField DataField="BXJETotal" HeaderText="报销金额合计" SortExpression="BXJETotal" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="odsZHJFYLF" runat="server" SelectMethod="Create_Report_ZHJFYLF_Stat"
                    TypeName="MRS.BLL.AccountBook">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlMPeriod" Name="mPeriodId" PropertyName="SelectedValue"
                            Type="Int32" />
                        <asp:ControlParameter ControlID="tbYLF" DefaultValue="3000" Name="zhjfylf_greater_than"
                            PropertyName="Text" Type="Decimal" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br /><br />
                <p>
                    说明：补助基数 = 个人自付 + 自理费<br />
                    综合减负医疗费 = ∑本年度（个人自负+个人承担+历年帐户-隐性个人自付）
                    <br />
                    综合减负医疗费 是宁波市医保补助的基数， 补助基数是公司根据（镇石化工贸〔2008〕22号）文件精神，进行补充医保补助的基数。<br />
                </p>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
