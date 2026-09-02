using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendar
{
    public partial class LeaveForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //check whether  the Employee name
                if (Request.Cookies["EmployeeName"] != null)
                {
                    lblLeaveDate.Text = Request.Cookies["EmployeeName"].Value;
                }

                //to get selected leave date from  the session
                if (Session["LeaveDate"] != null)
                {
                    DateTime sldt = (DateTime)Session["LeaveDate"];
                    lblLeaveDate.Text = sldt.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblLeaveDate.Text = "No leave date selected. Please select a date from the calendar.";
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           string employeeName = TextBox1.Text;
            string leavetp = DropDownList1.SelectedValue;
            string leaveDate = lblLeaveDate.Text;
            string reason = TextBox2.Text;

            //store name in session
            Session["EmployeeName"] = employeeName;
            //store leave information in session
            Session["LeaveType"] = leavetp;
            Session["reason"] = reason;

            if (CheckBox1.Checked)
            {
                Response.Cookies["EmployeeName"].Value = employeeName;
                Response.Cookies["EmployeeName"].Expires = DateTime.Now.AddDays(7);
            }
            lblmssg.Text = "<b>Leave application submitted By:</b><br/> " +
                "Employee: " 
                + employeeName + "<br/> on " + leaveDate + "Reason:" + reason;
        }
    }
}