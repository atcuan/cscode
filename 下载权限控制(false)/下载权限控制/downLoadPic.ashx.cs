using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;
using 下载权限控制.DAL.DataSetPicTableAdapters;

namespace 下载权限控制
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class downLoadPic : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["isLogin"] != null)
            {
                //输出格式
                context.Response.ContentType = "image/JPEG";

                //添加报文头
                string fileName = context.Request["FileName"];
                string encodeFilename = HttpUtility.UrlEncode(fileName);
                context.Response.AddHeader("Content-Disposition", "attachment;filename=" + encodeFilename);
                
                //核对下载权限
                int usrId = (int)context.Session["loginUsrId"];
                T_UserTableAdapter adapter = new T_UserTableAdapter();
                var data = adapter.GetDataById(usrId);
                var usr = data.Single();
                if (usr.FLevel == 0)//普通用户
                {

                }
                else //收费用户
                {
                    context.Response.WriteFile("images/" + fileName); 
                }
                
            }
            else
            {
                context.Response.Redirect("login.aspx");
                //提示未登录
            }
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
