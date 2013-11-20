using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 图片下载权限控制2.DAL.DataSetPicTableAdapters;

namespace 图片下载权限控制2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            T_PicUsrTableAdapter adapter = new T_PicUsrTableAdapter();
            var date = adapter.GetDataByUserName(txtUsrName.Text);
            if (date.Count <= 0)
            {
                loginMsg.Text = "用户名不存在";
                loginMsg.Visible = true;
            }
            else 
            {
                var user = date.Single();

                if (!user.IsErrorTimesNull() && !user.IsLastErrorTimeNull())
                {
                    //比较当前时间与上次登陆错误错误时间差
                    double span = (DateTime.Now - user.LastErrorTime).TotalMinutes;
                    if (user.ErrorTimes > 4 && span <= 30)
                    {
                        loginMsg.Text = "错误次数过多，30分钟后重试";
                        loginMsg.Visible = true;
                        return;
                    }
                }

                if (user.Password == txtPassword.Text)
                {
                    //登录成功，登陆用户信息存到session中
                    Session["isLogin"] = true;
                    Session["loginUsrId"] = user.Id;
                    //重置错误次数
                    adapter.ResetErrorTimesById(user.Id);
                    //将用户重定向到下载页面
                    Response.Redirect("downLoadList.htm");
                }
                else 
                {
                    adapter.IncErrorTimesById(user.Id);//错误次数加一并记录当前登陆失败时间,IsNull(ErrorTimes,0)
                    loginMsg.Text = "密码错误";
                    loginMsg.Visible = true;
                }
            }
            
        }
    }
}
