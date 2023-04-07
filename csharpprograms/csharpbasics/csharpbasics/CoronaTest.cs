using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class CoronaTest
    {
        internal static void TestCorona()
        {
            List<Corona> coronaList = new List<Corona>();
            Corona state1 = new Corona(1, "Karnataka", 1000, 8000, 1000, 10000);
            Corona state2 = new Corona(2, "Kelara", 2000, 8000, 2000, 12000);
            coronaList.Add(state1);
            coronaList.Add(state2);

            Console.WriteLine("Items in corona list");

            int sumtotal = 0;
            double avgcases = 0;

            double deathrate;

            foreach(var corona in coronaList)
            {
                corona.Info();
                sumtotal = sumtotal + corona.TotalCases;
                deathrate = (Convert.ToDouble(corona.DeathCases) / Convert.ToDouble(corona.TotalCases)) * 100;
                Console.WriteLine("Death Rate "+ deathrate);
            }

            Console.WriteLine("Sum of total cases "+ sumtotal);
            avgcases = sumtotal / coronaList.Count;
            Console.WriteLine("Average cases " + avgcases);




        }
    }

    class Corona
    {
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public int ActiveCases { get; set; }
        public int RecoveredCases { get; set; }
        public int DeathCases { get; set; }
        public int TotalCases { get; set; }

        internal Corona(int code,string name,int active,int recoved,int death,int total)
        {
            this.StateCode = code;
            this.StateName = name;
            this.ActiveCases = active;
            this.RecoveredCases = recoved;
            this.DeathCases = death;
            this.TotalCases = total;
        }

        internal void Info()
        {
            Console.WriteLine("State Code " + this.StateCode + " State Name " + this.StateName + " Active Cases " + this.ActiveCases + " Recovered Cases " + this.RecoveredCases + "Death Cases" + this.DeathCases + " Total cases " + this.TotalCases);
        }
    }
}
