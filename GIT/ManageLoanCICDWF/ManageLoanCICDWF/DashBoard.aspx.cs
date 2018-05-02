using ManageLoanCICDWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageLoanCICDWF
{
    public partial class DashBoard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee emp = Session["EmpDetails"] as Employee;
            if (emp == null)            
                Response.Redirect("~/Login.aspx");            
            else
            {
                //(this.Master as SiteMaster).UserName = emp.EmpName;
                var loanCollection = XMLReader.LoanXMLReader();
                IEnumerable<LoanDetails> filteredLoans;
                if (emp.EmpID.ToUpper() != "ADMIN")
                    filteredLoans = loanCollection.LoanList.Where(item => item.InitiatedBy == emp.EmpID);
                else
                    filteredLoans = loanCollection.LoanList;

                GridView1.DataSource = filteredLoans;
                GridView1.DataBind();
            }
        }
    }
}