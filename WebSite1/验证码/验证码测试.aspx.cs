using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 验证码_验证码测试 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string trueCode = Convert.ToString(Session["code"]);
        if (trueCode == TextBox1.Text)
        {
            Response.Write("正确");
        }
        else
        {
            Response.Write("错误");
        }
    }
}
