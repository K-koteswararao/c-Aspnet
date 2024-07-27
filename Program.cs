using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-3JSIQMU\\SQLEXPRESS;database=sample;integrated security=SSPI"))
            {
                con.Open();
                new Program().QueryTable(con);
                Console.ReadKey();
            }
        }
        public void QueryTable(SqlConnection con)
        {
            var q = "select COUNT(*) from Demo";
            //var q1 = "insert into Demo(id,name,branch)values('104','sai','ECE')";
            // var q2 = "ALTER TABLE Demo ADD phone varchar(20) NULL";
            //var q4 = "update Demo set phone='8639900655'where id=103";
            var q5 = "DELETE FROM Demo where id=104";


            SqlCommand c = new SqlCommand(q, con);
            //SqlCommand c2 = new SqlCommand(q1, con);
            //SqlCommand c3 = new SqlCommand(q2, con);
            //SqlCommand c4 = new SqlCommand(q4, con);
            SqlCommand c5 = new SqlCommand(q5, con);

            var reader = c.ExecuteScalar();
            //var reader2 = c2.ExecuteScalar();
            // var reader3 = c3.ExecuteScalar();
            //var reader4 = c4.ExecuteScalar();
            var reader5 = c5.ExecuteScalar();

            Console.WriteLine(reader);
            //Console.WriteLine(reader2);
            //Console.WriteLine(reader3);
            //Console.WriteLine(reader4);
            Console.WriteLine(reader5);
            Console.WriteLine("Deleted successfully");
        }
        
        
        
    }
}


