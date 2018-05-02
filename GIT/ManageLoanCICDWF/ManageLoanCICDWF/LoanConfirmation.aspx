<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LoanConfirmation.aspx.cs" Inherits="ManageLoanCICDWF.LoanConfirmation" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">
    <div class="row">
        <div class="col-md-8">
           
                <div class="form-horizontal" style="background-color: ActiveBorder">
                    <h4>Confirmation / View</h4>
                    <hr />
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Client Number  :</asp:Label>
                        <asp:Label runat="server" ID="lblClientNo" CssClass="customLabel" Font-Bold="true" />                                            
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Client Name  :</asp:Label>
                        <asp:Label runat="server" ID="lblClientName" CssClass="customLabel" Font-Bold="true"/>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Account No  :</asp:Label>
                        <asp:Label runat="server" ID="lblAccNo" CssClass="customLabel" Font-Bold="true"/>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Loan Type  :</asp:Label>
                        <asp:Label runat="server" ID="lblLoanType" CssClass="customLabel" Font-Bold="true"/>                          
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Loan ID  :</asp:Label>
                        <asp:Label runat="server" ID="lblLoanID" CssClass="customLabel" Font-Bold="true"/>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Loan Amount  :</asp:Label>
                        <asp:Label runat="server" ID="lblLoanAmt" CssClass="customLabel" Font-Bold="true"/>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Interest Rate  :</asp:Label>
                        <asp:Label runat="server" ID="lblInterestRate" CssClass="customLabel"  Font-Bold="true"/>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Interest Rate  :</asp:Label>
                        <asp:Label runat="server" ID="TextBox1" CssClass="customLabel" Font-Bold="true"/>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Submit" Visible="true" CssClass="btn btn-default" />
                            <asp:Button runat="server" ID="btnApprove" OnClick="btnApprove_Click" Text="Approve" Visible="false" CssClass="btn btn-default" />
                            <a runat="server" id="btnGoBack" Visible="false" href="DashBoard.aspx"  CssClass="btn btn-default" ><< Go Back</a>                            
                        </div>
                    </div> 
                </div>         
        </div>
    </div>

</asp:content>
