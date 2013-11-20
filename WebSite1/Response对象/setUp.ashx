<%@ WebHandler Language="C#" Class="setUp" %>

using System;
using System.Web;

public class setUp : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";

        for (int i = 0; i < 10; i++)
        {
            System.Threading.Thread.Sleep(500);
            context.Response.Write("第"+(i+1)+"步执行完成！<br />");
            context.Response.Flush();
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}