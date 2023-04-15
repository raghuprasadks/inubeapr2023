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
            //  createDataBase();
            //createTable();
            //insertRecord();
            // insertRecordWithParameter();
            // insertRecordWithUserInput();
            // StoredProcedures.createStoredProcedure();
           // DataSetDemo.PopulateDataSet();
            DataSetDemo.InsertToDataSet();
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

        static void createTable()
        {

            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);

          //  SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
            @"CREATE TABLE dbo.Products
                (
                    ID int IDENTITY(1,1) NOT NULL,
                    Name nvarchar(50) NULL,
                    Price nvarchar(50) NULL,
                    Date datetime NULL,
                    CONSTRAINT pk_id PRIMARY KEY (ID)
                );";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
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

        static void insertRecord()
        {
            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);


            // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query = "INSERT INTO Products (Name,Price,Date) VALUES('LED Screen','$120','27 January 2017')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
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

        static void insertRecordWithParameter()
        {
            //  SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            //Replaced Parameters with Value

            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);

            string query = "INSERT INTO Products (Name, Price, Date) VALUES(@Name, @Price, @Date)";
            SqlCommand cmd = new SqlCommand(query, con);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@Name", "USB Keyboard");
            cmd.Parameters.AddWithValue("@Price", "$20");
            cmd.Parameters.AddWithValue("@Date", "25 May 2017");

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
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

