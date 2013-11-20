using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm4_Img
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            //校验是否为合法的ID card
            if (s=="")
            {
                return;
            }
            //pictureBox1.Visible = true;
            string strYear = s.Substring(6, 4);
            int year = Convert.ToInt32(strYear);
            if (DateTime.Now.Year - year > 18)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
                return;
            }
        }
    }
}
