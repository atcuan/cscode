using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConApp19_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug") || dataDir.EndsWith(@"\bin\Release"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory",dataDir);
            }

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDBFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            Console.WriteLine("打开数据库连接成功！");
        }
    }
}
