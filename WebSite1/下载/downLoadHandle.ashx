<%@ WebHandler Language="C#" Class="downLoadHandle" %>

using System;
using System.Web;

public class downLoadHandle : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "image/JPG";
        string filename = HttpUtility.UrlEncode("下载的图片.jpg");
        context.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
        context.Response.Write("e5f7fe34d1ac544b91ef3906.jpg");
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}