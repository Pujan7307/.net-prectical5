using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace practical5
{
    public partial class LeaveForm : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    DateTime date = (DateTime)Session["LeaveDate"];
                    Label1.Text = date.ToString("dd/MM/yyyy");
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string date = Label1.Text;
            string type = DropDownList1.SelectedValue;
            string reason = TextBox3.Text;
            string remember = CheckBox1.Checked ? "Yes" : "No";
            Label2.Text =
                    "<b>Leave Application Details</b><br/><br/>" +
                    "Employee Name: " + name + "<br/>" +
                    "Leave Date: " + date + "<br/>" +
                    "Leave Type: " + type + "<br/>" +
                    "Reason: " + reason + "<br/>" +
                    "Remember Name: " + remember;
        }
    }
}