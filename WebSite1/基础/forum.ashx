<%@ WebHandler Language="C#" Class="forum" %>

using System;
using System.Web;

public class forum : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";

        string usrName = context.Request["username"];
        string msg ="";
        string ispostback = context.Request["ispostback"];
        if (ispostback == "true")
        {
            context.Response.Write("提交进入");
            msg = usrName + "你好！";
        }
        else
        {
            context.Response.Write("直接进入");
            usrName = "";
            msg = "";
        }

        string fullPath = context.Server.MapPath("forum.htm");//获取文件路径
        string content = System.IO.File.ReadAllText(fullPath);//读取文件内容
        content = content.Replace("@value",usrName);//提交数据
        content = content.Replace("@msg", msg);
        context.Response.Write(content);//输出提交后的文件内容
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}