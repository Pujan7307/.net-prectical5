using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace practical5
{
    public partial class calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = "Selected Date:" + Calendar1.SelectedDate.ToString();
            Session["LeaveDate"] = Calendar1.SelectedDate;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveForm.aspx");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}