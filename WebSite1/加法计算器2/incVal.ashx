<%@ WebHandler Language="C#" Class="incVal" %>

using System;
using System.Web;

public class incVal : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string ispostback = context.Request["ispostback"];
        string msg = "0";
        if (ispostback == "true")
        { 
           msg = context.Request["num"];
           int i = Convert.ToInt32(msg);
           i++;
           msg = i.ToString();
        }

        string fullPath = context.Server.MapPath("incVal.htm");
        string content = System.IO.File.ReadAllText(fullPath);
        content = content.Replace("@msg",msg);
        context.Response.Write(content);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}