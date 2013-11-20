<%@ WebHandler Language="C#" Class="YZM" %>

using System;
using System.Web;

public class YZM : IHttpHandler,System.Web.SessionState.IRequiresSessionState {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "image/JPEG";
        using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(100, 30)) 
        {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap))
            {/*
                g.DrawString("不是机器人",new System.Drawing.Font("宋体",10),System.Drawing.Brushes.RosyBrown,new System.Drawing.Point(0,0));
                bitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                */

                Random rad = new Random();
                int code = rad.Next(100000,900000);
                string strCode = Convert.ToString(code);
                //启用session需要开启IRequiresSessionState
                HttpContext.Current.Session["code"] = strCode;
                g.DrawString(strCode, new System.Drawing.Font("宋体", 12), System.Drawing.Brushes.Gold, new System.Drawing.PointF(0, 0));
                bitmap.Save(context.Response.OutputStream,System.Drawing.Imaging.ImageFormat.Jpeg);
            }

           
            
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}