using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConAppl20_dbtest
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

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\\SQLEXPRESS;AttachDBFilename=|DataDirectory|\Databasemdf;Integrated Security=True;User Instance=true"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into T_Usr(username) values('choclf')";
                    cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine("ok！");
            Console.ReadKey();
        }

    }
}
