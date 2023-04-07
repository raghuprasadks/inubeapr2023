using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class InterfaceDemo_8
    {
        internal static void TestInterface()
        {
            IBank myBank = new SBIBank();
            myBank.CalculateSimpleInterest(10000, 1);

            myBank = new KarnatakaBank();
            myBank.CalculateSimpleInterest(10000, 1);

        }
    }

    internal interface IBank
    {
        void CalculateSimpleInterest(int p, int t);
    }

    internal class SBIBank : IBank
    {
        double roi;
        public void CalculateSimpleInterest(int p, int t)
        {
            roi = 6;
            double si = (p * roi * t) / 100;
            Console.WriteLine("SBIBank : Simple Interest "+si);
        }
    }

    internal class KarnatakaBank : IBank
    {
        double roi;
        public void CalculateSimpleInterest(int p, int t)
        {
            roi = 7;
            double si = (p * roi * t) / 100;
            Console.WriteLine("KarnatakaBank : Simple Interest " + si);
        }
    }
}
