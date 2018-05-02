using ManageLoanCICDWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageLoanCICDWF
{
    public partial class LoanConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoanDetails newLoan = null;
            if (Session["LoanDetails"] != null)
            {
                newLoan = Session["LoanDetails"] as LoanDetails;
            }
            else if (Request.QueryString["loanNo"] != null)
            {
                newLoan = XMLReader.LoanXMLReader().LoanList.Where(item => item.loanNo == Request.QueryString["loanNo"]).SingleOrDefault();
            }



            lblClientNo.Text = newLoan.ClientNo;
            lblClientName.Text = newLoan.ClientName;
            lblAccNo.Text = newLoan.loanAccount;
            lblLoanType.Text = newLoan.LoanType;
            lblLoanID.Text = newLoan.loanNo;
            lblInterestRate.Text = newLoan.InterestRate;
            lblLoanAmt.Text = newLoan.loanAmount;

            Employee emp = Session["EmpDetails"] as Employee;
            if (emp.Role.ToUpper() == "ADMIN")
            {
                btnSubmit.Visible = false;
                if (newLoan.loanStatus != "Approved")
                    btnApprove.Visible = true;
                else
                    btnGoBack.Visible = true;
            }
            else
            {
                btnApprove.Visible = false;
                if (Request.QueryString["loanNo"] == null)
                    btnSubmit.Visible = true;
                else
                {
                    btnGoBack.Visible = true;
                    btnSubmit.Visible = false;
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LoanDetails newLoan = Session["LoanDetails"] as LoanDetails;
            Employee emp = Session["EmpDetails"] as Employee;
            newLoan.InitiatedBy = emp.EmpID;
            var loanColl = XMLReader.LoanXMLReader();
            if (!loanColl.LoanList.Any(item => item.loanNo == newLoan.loanNo))
            {
                loanColl.LoanList.Add(newLoan);
                XMLWriter.LoanXMLWriter(loanColl);
            }


            Response.Redirect("~/Dashboard.aspx");
        }
        protected void btnApprove_Click(object sender, EventArgs e)
        {
            var loanColl = XMLReader.LoanXMLReader();
            LoanDetails newLoan = null;
            Employee emp = Session["EmpDetails"] as Employee;
            if (emp.Role.ToUpper() != "ADMIN")
                newLoan = loanColl.LoanList.Where(item => item.loanNo == Request.QueryString["loanNo"]).SingleOrDefault();
            else
                newLoan = Session["LoanDetails"] as LoanDetails;

            loanColl.LoanList.Remove(newLoan);

            newLoan.PendingWith = string.Empty;
            newLoan.loanStatus = "Approved";
            loanColl.LoanList.Add(newLoan);
            XMLWriter.LoanXMLWriter(loanColl);

            Response.Redirect("~/Dashboard.aspx");
        }
    }
}