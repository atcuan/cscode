using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm6_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int ErrorTimes = 0;
        private void login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPd.Text;
            
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "chinou")
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                /*int i = 4;
                MessageBox.Show("用户名或者密码错误你还有" + i + "次机会");
                i=i-1;
                if (i < 0)
                {
                    MessageBox.Show("错误次数过多，程序即将退出！");
                    Application.Exit();
                    MessageBox.Show("用户名或者密码错误你还有" + i + "次机会");
                }*/

                ErrorTimes++;   //局部变量每次用完便销毁，下次使用从新初始化，而类字段，只要
                                //对象不销毁，就会一直保持对象的字段值
                MessageBox.Show("用户名或者密码错误你还有" + (4-ErrorTimes) + "次机会");
                if (ErrorTimes > 3)
                {
                    MessageBox.Show("错误次数过多，程序即将退出！");
                    Application.Exit();
                }
            }
            
        }
    }
}
