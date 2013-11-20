using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;
using 图片下载权限控制2.DAL.DataSetPicTableAdapters;
using System.Drawing;

namespace 图片下载权限控制2
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class downLoadPic : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["isLogin"] == null)
            {
                context.Response.Redirect("Default.aspx");
                //提示未登录跳转页面
            }
            else 
            {
                //输出格式
                context.Response.ContentType = "image/JPEG";

                //添加报文头
                string filename = context.Request["FileName"];
                string encodeFileName = HttpUtility.UrlEncode(filename);
                context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=\"{0}\"", encodeFileName));

                //核对下载权限
                int usrId = Convert.ToInt32(context.Session["loginUsrId"]);
                T_PicUsrTableAdapter adapter = new T_PicUsrTableAdapter();
                var data = adapter.GetDataById(usrId);
                var usr = data.Single();
                if (usr.Level == 0)//普通用户
                {
                    using (Bitmap bitmap = new Bitmap(context.Server.MapPath("images/"+filename)))
                    {
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.DrawString("免费用户"+usr.UserName+"试用", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 0, 0);
                        }
                        bitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                else//收费用户
                {
                    context.Response.WriteFile("images/" + filename);//有攻击漏洞,可以直接下载网站源码http://localhost:57753/downLoadPic.ashx?FileName=./Default.aspx.cs
                }
            }

        }

        private void Bitmap()
        {
            throw new NotImplementedException();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
