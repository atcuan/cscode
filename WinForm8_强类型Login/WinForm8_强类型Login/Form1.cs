using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForm8_强类型Login.DataSetUsersTableAdapters;

namespace WinForm8_强类型Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            T_UsersTableAdapter adapter = new T_UsersTableAdapter();
            WinForm8_强类型Login.DataSetUsers.T_UsersDataTable users =  adapter.GetDataByFUserName(txtUserName.Text);
            if (users.Count <= 0)
            {
                MessageBox.Show("用户名错误");
            }
            else 
            {
                WinForm8_强类型Login.DataSetUsers.T_UsersRow user = users[0];
                if (user.FErrorTimes > 3)
                {
                    MessageBox.Show("错误次数过多");
                    return;
                }
                if (user.FPassWord == txtPassWord.Text)
                {
                    MessageBox.Show("登陆成功");
                    adapter.ResetErrorTimes(user.id);
                }
                else
                {
                    adapter.IncErrorTimesById(user.id);
                    MessageBox.Show("密码错误");
                }
                
            }
        }

    }
}
