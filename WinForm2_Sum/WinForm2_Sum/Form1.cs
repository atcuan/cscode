using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm2_Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int i, j;
            if (!int.TryParse(str1, out i))
            {
                MessageBox.Show("第一个数不是合法的整数");
                return;     //Don't forget return!!
            }
            if(int.TryParse(str2, out j) == false)
            {
                MessageBox.Show("第二个数不是合法的整数");
                return;       //Don't forget return!!
            }

            int k = i + j;
            textBox3.Text = Convert.ToString(k);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
