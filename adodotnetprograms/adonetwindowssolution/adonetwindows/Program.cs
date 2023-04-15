using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ado.NET Demo");
            //   readStudent();
            // string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            createDataBase();
            Console.ReadKey();
        }

        static void readStudent()
        {
            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }

        static void createDataBase()
        {
            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);

            string query = "Create Database ComputerShop";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
               // Console.ReadKey();
            }
        }
    }
}
