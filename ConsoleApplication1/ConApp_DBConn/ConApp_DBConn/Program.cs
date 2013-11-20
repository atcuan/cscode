using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConApp_DBConn
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"bin\Debug\") || dataDir.EndsWith(@"bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }

            Console.WriteLine("请输入用户名：");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();

            using(SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDBFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=true"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into T_Usr(username,password) values('"+username+"','"+password+"')";
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
