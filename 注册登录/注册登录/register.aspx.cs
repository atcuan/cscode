using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 注册登录.DAL.DataSetT_UsersTableAdapters;
using System.Text.RegularExpressions;

namespace 注册登录
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            T_UsersTableAdapter adapter = new T_UsersTableAdapter();
            if (adapter.GetDataByUserName(txtUsername.Text).Count >= 1)
            {
                forUsername.Text = "用户名已存在";
                forUsername.Visible = true;
                return;
            }
            else
            {
                forUsername.Visible = false;
            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            // 检查用户名是否已经存在
            T_UsersTableAdapter adapter = new T_UsersTableAdapter();
            if (adapter.GetDataByUserName(txtUsername.Text).Count >= 1)
            {
                forUsername.Text = "用户名已存在";
                forUsername.Visible = true;
                return;
            }
            else
            {
                forUsername.Visible = false;
            }

            // 检查两次密码是否一致
            if (txtPassword.Text != txtPwConfirm.Text)
            {
                Label5.Text = "两次输入的密码不一致";
                Label5.Visible = true;
                return;
            }

            //邮箱合法性验证
            Regex reMail = new Regex(@".+@.+");
            if (reMail.IsMatch(txtEmail.Text) == false)
            {
                Label6.Text = "邮箱名不合法";
                Label6.Visible = true;
                return;
            }
            else
            {
                Label6.Visible = false;
            }

            //通过校验，写入数据
            int done = adapter.Insert(txtUsername.Text, txtPassword.Text, txtEmail.Text, DateTime.Now);
            if (done == 0)
            {
                Label6.Text = "注册失败，请稍候再试";
            }
            //跳转
            Response.Redirect("showMessage.aspx?Msg=注册成功，跳转中...&RedirectURL=Default.aspx");
            
        }
    }
}
