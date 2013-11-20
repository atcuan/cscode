using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm6_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string old = txtPdOld.Text;
            string newp = txtPdNew.Text;
            string con = txtConfirmPd.Text;
            if (old == "" || newp == "" || con == "")
            {
                MessageBox.Show("输入不能为空！");
                return;
            }
            if(old != "chinou")
            {
                MessageBox.Show("旧密码输入错误！");
                return;
            }
            if (newp != con)
            {
                MessageBox.Show("两次输入的新密码不一致！");
                return;
            }
            else if (newp == old)
            {
                MessageBox.Show("新密码不能和旧密码一样！");
                return;
            }
            else
            {
                MessageBox.Show("修改成功！");
                Application.Exit();
            }
        }
    }
}
