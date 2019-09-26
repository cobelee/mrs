<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="BXRatioQuery.aspx.cs" Inherits="BXRatioQuery" Title="当前报销比例查询" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="post">
        <h2 class="title">
            当前报销比例查询</h2>
        <p class="meta">
            <asp:Literal ID="ltlDateTime" runat="server"></asp:Literal>
        </p>
            报销比例根据就诊方式、个人当前医保年度内已发生的综合减负医疗费数额等因素，划分为不同的档次。<br />
            最大值为零，代表无限大。</p>
        <asp:GridView ID="gvBXRatio" runat="server" AutoGenerateColumns="False" DataSourceID="odsBXRatio"
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="False" />
                <asp:BoundField DataField="OrderNumber" HeaderText="OrderNumber" SortExpression="OrderNumber"
                    Visible="False" />
                <asp:BoundField DataField="HspType" HeaderText="就诊方式" SortExpression="HspType" />
                <asp:BoundField DataField="MinKBJE" HeaderText="最小值(非包含)元" SortExpression="MinKBJE" />
                <asp:BoundField DataField="MaxKBJE" HeaderText="最大值(包含)元" SortExpression="MaxKBJE" />
                <asp:BoundField DataField="Ratio" HeaderText="报销比例" SortExpression="Ratio" />
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Right" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsBXRatio" runat="server" SelectMethod="Select" TypeName="MRS.BLL.BXRatio">
        </asp:ObjectDataSource>
    </div>
</asp:Content>
