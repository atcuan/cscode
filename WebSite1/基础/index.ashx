<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string usrname = context.Request["username"];
        //context.Response.Write("Hello World");
        context.Response.Write(usrname);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}