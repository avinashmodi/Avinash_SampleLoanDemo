<%@ Page Title="InitiateLoan" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InitiateLoan.aspx.cs" Inherits="ManageLoanCICDWF.InitiateLoan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
        <h3>Initiate Loan</h3>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Client Number</asp:Label>

            <asp:TextBox runat="server" ID="txtClientNo" CssClass="form-control" />
            <asp:Button runat="server" ID="btnCheckClient" Text="Get Details" OnClick="btnCheckClient_Click" CssClass="btn btn-default" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtClientNo" CausesValidation="true" ValidationGroup="clientNo"
                CssClass="text-danger" ErrorMessage="The client number field is required." />
        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Client Name</asp:Label>
            <asp:TextBox runat="server" ID="txtClientName" CssClass="form-control" Enabled="false" />

        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Account No</asp:Label>

            <asp:TextBox runat="server" ID="txtAccNo" CssClass="form-control" Enabled="false" />

        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Loan Type</asp:Label>

            <asp:DropDownList runat="server" ID="ddlLoanType" CssClass="dropdown">
                <asp:ListItem Text="HomeLoan" Value="Home Loan" />
                <asp:ListItem Text="PrivateLoan" Value="Private Loan" />
            </asp:DropDownList>


            <asp:Button runat="server" ID="btnGetLoanDetails" OnClick="btnGetLoanDetails_Click" Text="Get Loan Details" CssClass="btn btn-default" />
        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Loan ID</asp:Label>
            <asp:TextBox runat="server" ID="txtLoanID" CssClass="form-control" Enabled="false" />

        </div>

        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Loan Amount</asp:Label>
            <asp:TextBox runat="server" ID="txtLoanAmt" CssClass="form-control" />

             <asp:RequiredFieldValidator runat="server" ControlToValidate="txtClientNo"
                CssClass="text-danger" ValidationGroup="clientNo"  ErrorMessage="The Loan amount field is required." />

        </div>

        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Interest Rate</asp:Label>
            <asp:TextBox runat="server" ID="txtInterestRate" CssClass="form-control" Enabled="false" />

        </div>

        <div class="form-group" id="divSpclInterest" runat="server">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Interest Discount</asp:Label>
            <asp:TextBox runat="server" ID="txtSpclInterestDiscount" CssClass="form-control" Enabled="false" />
        </div>


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="btnSubmit" CausesValidation="true" ValidationGroup="clientNo" OnClick="btnSubmit_Click" Text="Proceed" CssClass="btn btn-default" />
            </div>
        </div>

        <%--<asp:ValidationSummary ID="vldsummary" DisplayMode="BulletList" runat="server" ShowSummary="true" ValidationGroup="clientNo" />--%>
    </div>


</asp:Content>
