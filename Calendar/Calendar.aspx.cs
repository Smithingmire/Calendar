using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendar
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //select date
            DateTime sldt = Calendar1.SelectedDate;
            lblselectedDt.Text = "Selected Date "+ sldt.ToString("dd-MM-yyyy");

            //store selected date in session
            Session["LeaveDate"] = sldt;

        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveForm.aspx");
        }
    }
}