using ManageLoanCICDWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageLoanCICDWF
{
    public partial class _Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //XMLWriter.TestXMLWriter();
        }

        

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            EmployeeCollection EmpColl = XMLReader.EmpXMLReader();

            var employee = EmpColl.EmployeeList.Where(item => item.EmpID.ToLower() == txtUserName.Text.ToLower() && item.Password.ToLower() == txtPassword.Text.ToLower()).SingleOrDefault();

            if (employee != null)
            {
                Session["EmpDetails"] = employee;
                Response.Redirect("~/Dashboard.aspx");
            }
            else
            {

            }
        }
    }
}