using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 下载权限控制.DAL.DataSetPicTableAdapters;

namespace 下载权限控制
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            T_UserTableAdapter adapter = new T_UserTableAdapter();
            var data = adapter.GetDataByUserName(usrName.Text);
            if (data.Count <= 0)
            {
                ErrorMsg.Text = "用户名不存在";
                ErrorMsg.Visible = true;
            }
            else
            {
                var user = data.Single();//返回唯一一天数据，否则抛出异常
                if (user.FPassword == password.Text)
                {
                    ErrorMsg.Text = "登陆成功";
                    //登陆用户信息存到session中
                    Session["isLogin"] = true;
                    Session["loginUsrId"] = user.Id;
                    //将用户重定向到下载页面
                    Response.Redirect("downLoadList.htm");
                    
                }
                else
                {
                    ErrorMsg.Text = "密码错误";
                    ErrorMsg.Visible = true;
                }
            }
        }
    }
}
