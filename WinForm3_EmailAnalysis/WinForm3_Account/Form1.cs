using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm3_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            int i, j;
            if (!int.TryParse(s1, out i))
            {
                MessageBox.Show("数字1格式错误");
                return;
            }
            if (!int.TryParse(s2, out j))
            {
                MessageBox.Show("数字2格式错误");
                return;
            }
            if (i >= j)
            {
                MessageBox.Show("数字1大于或者等于数字2");
                return;
            }

            int sum = 0;
            for (int k = i; k <= j; k++)
            {
                sum = sum + k;
            }
            textBox3.Text = Convert.ToString(sum);
        }
    }
}
