<%@ WebHandler Language="C#" Class="访问者信息" %>

using System;
using System.Web;

public class 访问者信息 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "image/JPEG";
       
        string fullPath = HttpContext.Current.Server.MapPath("2150071hlyr1y51rycb77h[1].jpg");
        using (System.Drawing.Bitmap bitMap = new System.Drawing.Bitmap(fullPath))
        {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitMap))
            {
               g.DrawString("\n您的当前IP:"+context.Request.UserHostAddress, new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0, 0);
               g.DrawString("\n操作系统:" + context.Request.Browser.Platform, new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0, 50);
               g.DrawString("\n浏览器版本:" + context.Request.Browser.Type, new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0,100);
            }
            bitMap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            
        }
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}