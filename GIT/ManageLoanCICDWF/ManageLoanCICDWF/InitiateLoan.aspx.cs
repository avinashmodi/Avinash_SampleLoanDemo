using ManageLoanCICDWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageLoanCICDWF
{
    public partial class InitiateLoan : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string loanNo = Request.QueryString["loanNo"];
            if (!string.IsNullOrEmpty(loanNo))
            {
                var loanDetails = XMLReader.LoanXMLReader().LoanList.Where(item => item.loanNo == loanNo).SingleOrDefault();

                txtClientNo.Text = loanDetails.ClientNo;
                txtClientName.Text = loanDetails.ClientName;
                txtAccNo.Text = loanDetails.loanAccount;
                txtInterestRate.Text = loanDetails.InterestRate;
                txtLoanID.Text = loanDetails.loanNo;
                txtLoanAmt.Text = loanDetails.loanAmount;
                ddlLoanType.SelectedItem.Value = loanDetails.LoanType;

            }
        }

        protected void btnCheckClient_Click(object sender, EventArgs e)
        {
            string clientNo = txtClientNo.Text.ToString();

            var client = XMLReader.ClientXMLReader().ClientList.Where(item => item.ClientNo == clientNo).SingleOrDefault();

            if (client != null)
            {
                txtClientName.Text = client.ClientName;
                txtAccNo.Text = client.AccountNumber;
            }
        }

        protected void btnGetLoanDetails_Click(object sender, EventArgs e)
        {
            var loanType = ddlLoanType.SelectedItem;
            Random generator = new Random();
            String number = generator.Next(0, 999999).ToString("D6");


            txtLoanID.Text = number;
            txtInterestRate.Text = "6%";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var loanColl = XMLReader.LoanXMLReader();

            LoanDetails newLoan = new LoanDetails();
            newLoan.ClientNo = txtClientNo.Text;
            newLoan.ClientName = txtClientName.Text;
            newLoan.loanAccount = txtAccNo.Text;
            newLoan.loanNo = txtLoanID.Text;
            newLoan.LoanType = ddlLoanType.SelectedItem.Value.ToString();
            newLoan.InterestRate = txtInterestRate.Text;
            newLoan.loanAmount = txtLoanAmt.Text;
            newLoan.PendingWith = "Admin";
            newLoan.loanStatus = "Pending";

            Session["LoanDetails"] = newLoan;
            Response.Redirect("~/LoanConfirmation.aspx");
        }
    }
}