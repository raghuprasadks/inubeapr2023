using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    public delegate void MyDelegate(string msg); //declaring a delegate
    class DelegateDemo_11
    {
        internal static void DemoDelegate()
        {
            Console.WriteLine("Without Delegate");
            A.MethodA("Without delegate");
            B.MethodB("Without delegate");
            MyDelegate demoDelegate = A.MethodA;
            demoDelegate("With delegate ::");

            demoDelegate = B.MethodB;
            demoDelegate("With delegate ::");
            Console.WriteLine("Lambda");
            demoDelegate = (string msg) => Console.WriteLine("Lambda " + msg);

            demoDelegate("hi from lambda");

            C cObj = new C();

            demoDelegate = cObj.MethodC;
            demoDelegate("With delegate ::");


        }
    }

    class A
    {
        internal static void MethodA(string msg)
        {
            Console.WriteLine("Class A:Method A :: "+msg);
        }
    }

    class B
    {
        internal static void MethodB(string msg)
        {
            Console.WriteLine("Class B:Method B :: " + msg);
        }
    }

    class C
    {
        internal void MethodC(string msg)
        {
            Console.WriteLine("Class C:Method C :: " + msg);
        }
    }
}
