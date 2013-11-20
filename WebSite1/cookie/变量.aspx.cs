using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cookie_变量 : System.Web.UI.Page
{
    //每次请求完了都会new一个新实现了的IHttpHandler接口类的“变量”的实例进程处理，用完了就GC掉，所以不会保持上次的值
    private static int i = 0;//private static int i = 0;可以实现自增
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["mySessionId"] == null)
        {
            string sessionId = Guid.NewGuid().ToString();
            Response.SetCookie(new HttpCookie("mySessionId", sessionId));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        i++;
        Label1.Text = i.ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string sessionId = Request.Cookies["mySessionId"].Value;
        //为什么这里不对了诶？？？
        IDictionary<string, object> session = sessionMgr.GetSession(sessionId);
        session["服务端数据"] = DateTime.Now.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string sessionId = Request.Cookies["mySessionId"].Value;
        //为什么这里不对了诶？？？
        IDictionary<string, object> session = sessionMgr.GetSession(sessionId);
        Label2.Text = Convert.ToString(session["服务端数据"]);
    }
}
