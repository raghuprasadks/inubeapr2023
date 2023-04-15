using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class DataSetDemo
    {

        internal static void PopulateDataSet()
        {
            String ConString = "data source=inubedb.cdtqd6jgia7i.ap-south-1.rds.amazonaws.com;initial catalog=TestDB;uid=admin;pwd=kaushalyaat2017;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConString);

          //  string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True";
            string querystring = "Select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Products");
            Console.WriteLine(ds.GetXml());
           // Console.WriteLine(ds.Tables);

            Console.ReadKey();
        }
    }
}
