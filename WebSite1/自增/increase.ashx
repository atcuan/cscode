<%@ WebHandler Language="C#" Class="increase" %>

using System;
using System.Web;

public class increase : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        
        string ispostback = context.Request["ispostback"];
        string val= context.Request["val"];//通过表单得到的值都是string类型的
        if (ispostback == "true")//点击【自增】按钮进来的，需要把当前数值自增
        {
            int i = Convert.ToInt32(val);
            i++;
            val = i.ToString();
        }
        else//第一次进入，值为0
        {
            val = "0";
        }
        string fullPath = context.Server.MapPath("increase.htm");
        string content = System.IO.File.ReadAllText(fullPath);
        content = content.Replace("@value",val);
        context.Response.Write(content);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}