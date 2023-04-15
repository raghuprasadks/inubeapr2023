using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class StoredProcedures
    {
        internal static void createStoredProcedure()
        {
            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(ConString);
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
              @"
                CREATE PROCEDURE Insert_Record_Procedure
                (
                @Name VARCHAR(50),
                @Price VARCHAR(50),
                @Date DATETIME
                )
              AS
                INSERT INTO Products(Name,Price,Date) Values(@Name,@Price,@Date)
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Store Procedure Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
