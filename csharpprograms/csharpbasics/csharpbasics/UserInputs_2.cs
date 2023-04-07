using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class UserInputs_2
    {
        internal static void simpleInterest()
        {
            Console.WriteLine("Simple Interest Calculator");
            Console.WriteLine("Enter principal amount");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate Of Interest");
            double roi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in years");
            int time = Convert.ToInt32(Console.ReadLine());
            double si = (principal * roi * time) / 100;
            Console.WriteLine("Simple Interest is " + si);
        }
    }
}
