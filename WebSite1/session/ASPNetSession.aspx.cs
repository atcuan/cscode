using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session_ASPNetSession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["第一个值"] = DateTime.Now;
        Session["第二个值"] = 3000;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button2.Text = Convert.ToString(Session["第一个值"]) + Session["第二个值"];
    }
}
