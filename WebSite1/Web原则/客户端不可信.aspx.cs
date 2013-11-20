using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web原则_客户端不可信 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //服务端需要校验金额是否合格
        if (Convert.ToInt32(TextBox1.Text) > 100)
        {
            Response.Write("金额不能大于100元");
            return;
        }

        Label1.Text = "取款成功，金额"+TextBox1.Text;

       
    }
}
