<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Report_ZJLNSYQK.aspx.cs" Inherits="Report_ZJLNSYQK" Title="资金历年使用情况报告" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="post">
        <h2 class="title">
            资金历年使用情况</h2>
        <p class="meta">
            <asp:Literal ID="ltlDateTime" runat="server"></asp:Literal>
        </p>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Font-Names="Verdana"
            Font-Size="8pt" Height="700px" ShowToolBar="False">
            <LocalReport DisplayName="寿" ReportPath="资金历年使用情况报告.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet_Report_ZJLNSYQK" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetReportZJLNSYQK"
            TypeName="MRS.BLL.Report"></asp:ObjectDataSource>
    </div>
</asp:Content>
