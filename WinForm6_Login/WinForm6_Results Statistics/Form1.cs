using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm6_Results_Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {
            //string cj = txtcj.Text;
            string[] lines = txtcj.Lines;
            string maxName = "";
            int maxScore = -1;
            foreach (string line in lines)
            {
                string[] strs = line.Split('=');
                string name = strs[0];
                string strScore = strs[1];
                int score = Convert.ToInt32(strScore);
                if (score > maxScore)
                {
                    maxName = name;
                    maxScore = score;
                }
            }
            MessageBox.Show(string.Format("{0}成绩第一为{1}",maxName,maxScore));
        }
    }
}
