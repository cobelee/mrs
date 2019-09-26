<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="PersonMRInfo.aspx.cs" Inherits="PersonMRInfo" Title="个人医保信息" %>

<%@ Register TagPrefix="User" TagName="PeronInfo" Src="~/UserControls/PersonInfo.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="post">
        <h2 class="title">
            个人医保信息</h2>
        <p class="meta">
            <asp:Literal ID="ltlDateTime" runat="server"></asp:Literal>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnQuery">
                    医保号：<asp:TextBox ID="tbMedicareId" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
                        runat="server" Text="查询" AccessKey="Q" OnClick="btnQuery_Click" /><br />
                    <br />
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <User:PeronInfo ID="PersonInfo1" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
