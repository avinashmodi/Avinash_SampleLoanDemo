using ManageLoanCICDWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageLoanCICDWF
{
    public partial class SiteMaster : MasterPage
    {
        public string UserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee emp = Session["EmpDetails"] as Employee;
            if (emp != null)
                UserName = emp.EmpName;
            if (this.Request.Url.ToString().ToUpper().Contains("LOGIN"))
            {
                divMenu.Visible = false;
                divLogout.Visible = false;
            }
        }
    }
}