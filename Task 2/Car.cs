using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_2
{
    class Car
    {
        private string make; //Nissan, Honda, subasu
        private string model;//Mustang, Corvette, Prius, Explorer, and Beetle
        private Engine engine;
        public Car(string newMake, string newModel, double newDisplacement,
                   double newAmountOfFuel, double newFuelTankCapacity) :
            this(newMake, newModel, new Engine(newDisplacement, newAmountOfFuel, newFuelTankCapacity))
        { }
        public Car(string newMake, string newModel, double newDisplacement, double newAmountOfFuel) :
            this(newMake, newModel, new Engine(newDisplacement, newAmountOfFuel))
        { }

        public Car(string newMake, string newModel, Engine newEngine)
        {
            this.make = newMake;
            this.model = newModel;
            this.engine = newEngine;
        }
        public void Go(double howManyKm)
        {
            Console.WriteLine("I'm riding on {0} {1}\n",this.make, this.model);
            bool riding = true;
            while (riding)
            {                
                this.engine.Work();               
                Console.CursorVisible = false;
                Console.SetCursorPosition(1, 1);
                for (int i = 0; i <howManyKm; i++)
                {   
                    
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.Write(" ");
                    Console.WriteLine("/|_||_\'.__");
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.Write(" ");
                    Console.WriteLine("(   _    _ _\'=* ");
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.Write("-");
                    Console.WriteLine("=`-(_)--(_)-'");
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.Write(" ");
                    Console.WriteLine("    fuel: {0}\n",this.engine.Work());
                    Console.SetCursorPosition(1, 1);                    
                    Thread.Sleep(100);
                    howManyKm--;

                }
                
                riding = false;                
            }
            //Console.WriteLine(@"   

            //                    ");
            Console.WriteLine();
            Console.WriteLine("\nHere I am");
        }

        public void Refuel(double fuelAmount)
        {
            this.engine.Refuel(fuelAmount);
        }


    }

}
