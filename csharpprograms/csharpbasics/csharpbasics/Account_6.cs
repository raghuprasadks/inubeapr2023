using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    internal class Account_6
    {
        int actnum;
        string name;
        string email;
        int balance;
        long aadhar;
        /**
         * Constructor
         * */
        internal Account_6(int actnum, string name, string email, int balance)
        {
            this.actnum = actnum;
            this.name = name;
            this.email = email;
            this.balance = balance;
        }

        internal Account_6(int actnum, string name, string email, int balance,long aadhar)
        {
            this.actnum = actnum;
            this.name = name;
            this.email = email;
            this.balance = balance;
            this.aadhar = aadhar;
        }

        internal int Deposit(int actnum, int amttodeposit)
        {
            this.actnum = actnum;
            this.balance = this.balance + amttodeposit;
            return this.balance;
        }

        internal int Withdraw(int actnum, int amttowithdraw)
        {
            this.actnum = actnum;
            this.balance = this.balance - amttowithdraw;
            return this.balance;
        }

        internal int CheckBalance(int actnum)
        {
            this.actnum = actnum;
            return this.balance;
        }

        internal string ActInfo()
        {
            return " Act Number : " + this.actnum + "Act Name " + this.name + " Balance " + this.balance;

        }
    }

    internal class AccountTest
    {

        internal static void TestAccount()
        {
            int actnum1 = 1;
            Account_6 act1 = new Account_6(actnum1, "ravi", "ravi@gmail.com", 0);
            int bal = act1.Deposit(actnum1, 10000);
            Console.WriteLine("Balance after deposit of 10 K " + bal);

            bal = act1.Withdraw(actnum1, 5000);
            Console.WriteLine("Balance after withdraw of 5 K " + bal);
            string actinfo = act1.ActInfo();
            Console.WriteLine("Account info " + actinfo);

            Random rnd = new Random();
            int actnum2 = rnd.Next();

            Console.WriteLine("Constructor with aadhar ");

            Account_6 act2 = new Account_6(actnum2, "rajani", "rajani@gmail.com", 0,9999999999);
            bal = act2.Deposit(actnum2, 20000);
            Console.WriteLine("Balance after deposit of 20 K " + bal);

            bal = act2.Withdraw(actnum2, 5000);
            Console.WriteLine("Balance after withdraw of 5 K " + bal);
            actinfo = act2.ActInfo();
            Console.WriteLine("Account info " + actinfo);


        }

    }
}
