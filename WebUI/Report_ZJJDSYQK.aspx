<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Report_ZJJDSYQK.aspx.cs" Inherits="Report_ZJJDSYQK" Title="�ʽ���ʹ���������" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="post">
        <h2 class="title">
            �ʽ���ʹ�����</h2>
        <p class="meta">
            <asp:Literal ID="ltlDateTime" runat="server"></asp:Literal>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnQuery">
                    ҽ����ȣ�<asp:DropDownList ID="ddlMPeriod" runat="server" DataSourceID="odsMPeriod" DataTextField="Name" DataValueField="Id">
                    </asp:DropDownList><asp:ObjectDataSource ID="odsMPeriod" runat="server" SelectMethod="GetMPeriodAll"
                        TypeName="MRS.BLL.MPeriod"></asp:ObjectDataSource>
                    <asp:Button ID="btnQuery" runat="server" Text="��ѯ" OnClick="btnQuery_Click" />
                </asp:Panel>
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Font-Names="Verdana"
                    Font-Size="8pt" Height="700px" ShowToolBar="False">
                    <LocalReport DisplayName="��" ReportPath="�ʽ���ʹ���������.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet_Report_ZJJDSYQK" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                &nbsp;
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetReportZJJDSYQK"
                    TypeName="MRS.BLL.Report">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlMPeriod" DefaultValue="0" Name="mPeriodId" PropertyName="SelectedValue"
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>