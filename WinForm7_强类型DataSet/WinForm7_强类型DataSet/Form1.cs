using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForm7_强类型DataSet.DataSet1TableAdapters;

namespace WinForm7_强类型DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_PersonsTableAdapter adapter = new T_PersonsTableAdapter();
            WinForm7_强类型DataSet.DataSet1.T_PersonsDataTable Persons = adapter.GetData();
            for (int i = 0; i < Persons.Count; i++)
            {
                WinForm7_强类型DataSet.DataSet1.T_PersonsRow Person = Persons[i];
                string msg = string.Format("姓名{0},年龄{1}", Person.FName, Person.FAge);
                MessageBox.Show(msg);
            }
        }
    }
}
