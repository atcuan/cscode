using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session_session版本自增aspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["value"] = 0;//直接进入的时候才给Session里的value设置初值
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Session["value"]);
        i++;
        TextBox1.Text = i.ToString();
        Session["value"] = i;
    }
}
