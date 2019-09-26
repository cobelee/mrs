<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PersonInfo.ascx.cs" Inherits="UserControls_PersonInfo" %>
<table id="tablePersonInfo" runat="server" style="border-right: gainsboro 1px solid;
    border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid;
    table-layout: auto; border-collapse: collapse;" width="100%" cellpadding="5"
    visible="false">
    <tr style="height: 30px; border: gainsboro 1px solid;">
        <td style="width: 80px;">
            姓名：</td>
        <td colspan="3">
            <asp:Literal ID="ltlBXPersonName" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr style="height: 30px; border: gainsboro 1px solid;">
        <td>
            医保号：</td>
        <td>
            <asp:Literal ID="ltlMedicareId" runat="server"></asp:Literal></td>
        <td style="width: 60px;">
            工号：</td>
        <td>
            <asp:Literal ID="ltlJobNumber" runat="server"></asp:Literal></td>
    </tr>
    <tr style="height: 30px; border: gainsboro 1px solid;">
        <td>
            性别：</td>
        <td>
            <asp:Literal ID="ltlSex" runat="server"></asp:Literal></td>
        <td>
            出生年月：</td>
        <td>
            <asp:Literal ID="ltlBirthday" runat="server"></asp:Literal></td>
    </tr>
    <tr style="height: 30px; border: gainsboro 1px solid;">
        <td>
            身份证号码：</td>
        <td>
            <asp:Literal ID="ltlIdentityCard" runat="server"></asp:Literal></td>
        <td>
            部门：</td>
        <td>
            <asp:Literal ID="ltlOrganization" runat="server"></asp:Literal></td>
    </tr>
    <tr style="height: 30px; border: gainsboro 1px solid;">
        <td>
            银行帐户：</td>
        <td>
            <asp:Literal ID="ltlBankAccount" runat="server"></asp:Literal></td>
        <td>
            人员类别：</td>
        <td>
            <asp:Literal ID="ltlPsnType" runat="server"></asp:Literal></td>
    </tr>
</table>
<div id="message" runat="server" visible="false">
    没有对应的参保人员。
</div>
