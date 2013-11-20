<%@ WebHandler Language="C#" Class="getPic" %>

using System;
using System.Web;

public class getPic : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "image/JPEG";

        string fullPath = HttpContext.Current.Server.MapPath("2150071hlyr1y51rycb77h[1].jpg");
        using (System.Drawing.Bitmap bitMap = new System.Drawing.Bitmap(fullPath))
        {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitMap))
            {
                if (context.Request.UrlReferrer == null)
                {
                    g.Clear(System.Drawing.Color.White);
                    g.DrawString("\n禁止直接浏览图片，请在页面中查看！", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0, 0);
                }
                else if (context.Request.UrlReferrer.Host != "localhost")
                {
                    g.Clear(System.Drawing.Color.White);
                    g.DrawString("\n图片仅内部使用，禁止盗链！", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0, 0);
                }
            }

            bitMap.Save(context.Response.OutputStream,System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}