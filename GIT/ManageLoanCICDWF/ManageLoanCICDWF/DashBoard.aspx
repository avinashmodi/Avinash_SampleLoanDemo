<%@ Page Title="DashBoard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="ManageLoanCICDWF.DashBoard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
        <h3>Dashboard</h3>
        <hr />
        <asp:GridView ID="GridView1" CssClass="myGridClass" AlternatingRowStyle-CssClass="myAltRowClass" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="loanNo" HeaderText="Loan ID" />
                <asp:BoundField DataField="loanAccount" HeaderText="Loan Account" />
                <asp:BoundField DataField="ClientNo" HeaderText="Client No" />
                <asp:BoundField DataField="ClientName" HeaderText="Client Name" />
                <asp:BoundField DataField="InterestRate" HeaderText="Interest Rate" />
                <asp:BoundField DataField="loanAmount" HeaderText="Loan Amount" />
                <asp:BoundField DataField="InitiatedBy" HeaderText="Initiated By" />
                <asp:BoundField DataField="loanStatus" HeaderText="Loan Status" />
                <asp:TemplateField HeaderText="View">
                    <ItemTemplate>
                        <asp:HyperLink ID="hlView" Text="view" runat="server" NavigateUrl='<%#String.Format("~/LoanConfirmation.aspx?loanNo={0}&view=true", DataBinder.Eval(GetDataItem(), "loanNo") )%>'></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
