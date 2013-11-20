<%@ WebHandler Language="C#" Class="addCalc" %>

using System;
using System.Web;

public class addCalc : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string ispostback = context.Request["ispostback"];
        string result = "";
        string num1 = "";
        string num2 = "";

        if (ispostback == "true")
        {
            num1 = context.Request["num1"];
            num2 = context.Request["num2"];
            result = (Convert.ToInt32(num1) + Convert.ToInt32(num2)).ToString();
        }

        string fullPath = context.Server.MapPath("addCalc.htm");
        string content = System.IO.File.ReadAllText(fullPath);
        content = content.Replace("@num1", num1);
        content = content.Replace("@num2", num2);
        content = content.Replace("@result", result);
        context.Response.Write(content);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}