using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    class InheritanceDemo_7
    {
        internal static void TestInheritance()
        {
            Console.WriteLine("Parent class");
            Vehicle myvehicle = new Vehicle("Yamaha", "RX 500", "Ranga", "Black",300000);
            myvehicle.Start();
            myvehicle.Move();
            myvehicle.Move();
            myvehicle.Info();
            myvehicle.Stop();
            Console.WriteLine("Child class");

            Bike mybike = new Bike("Yamaha", "RX 1500", "Ranga", "Red", 350000);
            mybike.Start();
            mybike.Move();
            mybike.Move();
            mybike.Info();
            mybike.Stop();


            Vehicle mybike1 = new Bike("Hero", "HE 1500", "Ranga", "Red", 350000);
            mybike1.Start();
            mybike1.Move();
            mybike1.Move();
            mybike1.Info();
            mybike1.Stop();




        }

    }

    class Vehicle
    {

        internal string make;
        internal string model;
        internal string owner;
        internal string color;
        internal int price;
        internal int speed;
        
        /**
         * Parent class
         * */

        internal Vehicle(string make, string model, string owner, string color, int price)
        {
            this.make = make;
            this.model = model;
            this.owner = owner;
            this.color = color;
            this.price = price;
            this.speed = 0;
        }

        internal void Start()
        {
            this.speed = 0;
            Console.WriteLine("Vehicle : start:Kick start");
        }

        /**
         * use virtual to override a method in parent class
         * */
        internal virtual void Move()
        {
            this.speed = this.speed +10;
            Console.WriteLine("Vehicle : move:speed "+this.speed);
        }

        internal void Stop()
        {
            this.speed = 0;
            Console.WriteLine("Vehicle : stopped:");
        }

        internal void Info()
        {
            Console.WriteLine("Vehicle : Make :"+this.make +" owner  "+this.owner);
        }
    }

    internal class Bike : Vehicle
    {

        internal Bike(string make, string model, string owner, string color, int price):base(make,model,owner,color,price)
        {
        }

        /**
         * use override keyword to override a method in child class
         * */
        internal override void Move()
        {
            this.speed = this.speed + 30;
            Console.WriteLine("Bike : move:speed " + this.speed);
        }



    }
    }
