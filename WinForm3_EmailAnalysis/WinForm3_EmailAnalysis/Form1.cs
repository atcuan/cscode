using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm3_EmailAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string[] strs = email.Split('@');
            if (strs.Length != 2)
            {
                MessageBox.Show("非法输入！");
                return;
            }
            textBox2.Text = strs[0];
            textBox3.Text = strs[1];
        }
    }
}
