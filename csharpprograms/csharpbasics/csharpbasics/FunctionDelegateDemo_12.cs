using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class FunctionDelegateDemo_12
    {

        //Func<int,int,int>

        internal static void FunctionDelegateDemo()
        {
            Func<int, int, int> operate;
            operate = Calculator.Add;
            int result = operate(10, 20);
            Console.WriteLine("Result of addition " + result);

            operate = Calculator.Multiply;
            result = operate(2, 20);
            Console.WriteLine("Result of multiplication " + result);


            operate = Calculator.RandomNumGen;
            result = operate(10, 20);
            Console.WriteLine("Result of Randomnum gen " + result);


            Func<int, int, int> division = (x, y) => x / y;

            Console.WriteLine("Result of division with lambda " +division(100,20));



            Console.WriteLine("Random number generation using Func delegate and lambda");

            //Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Func<int, int, int> randomgen = (n1, n2) =>
              {
                  return new Random().Next(n1, n2);
              };
            Console.WriteLine("Random number generation using Func delegate and lambda -1::"+ randomgen(1,100));
            Func<int, int, int> randomgenalternative = (n1, n2) =>new Random().Next(n1, n2);
            Console.WriteLine("Random number generation using Func delegate and lambda -2::" + randomgenalternative(1,100));
       }
    }

    class Calculator
    {
        internal static int Add(int n1,int n2)
        {
            return n1 + n2;
        }

        internal static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        internal static int RandomNumGen (int start,int end)
        {
            Random rnd = new Random();
            int radnumber = rnd.Next(start, end);
            return radnumber;
        }
    }


}
