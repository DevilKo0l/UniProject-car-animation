using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Engine
    {
        private const double Mile = 1.609344;         // per km
        private const double Gallon = 3.785411784;    // per ltr
        private readonly double Displacement;
        private const double DefaultFuelTankCapacity = 50;
        //private readonly double defaultFuelTankCapacity = 50;
        private readonly double FuelTankCapacity;
        public double amountOfFuel;
        public Engine(double newDisplacement, double newAmountOfFuel)
        {
            this.Displacement = newDisplacement;
            this.amountOfFuel = newAmountOfFuel;
            this.FuelTankCapacity = DefaultFuelTankCapacity;
        }
        public Engine(double newDisplacement, double newAmountOfFuel,
            double newFuelTankCapacity) : this(newDisplacement, newAmountOfFuel)
        {
            this.FuelTankCapacity = newFuelTankCapacity;
        }
        public static double MPG2Lp100Km(double MPG)
        {
            return (100 * Gallon) / (Mile * MPG);
        }
        public static double Lp100Km2MPG(double Lp100Km)
        {
            return (100 * Gallon) / (Mile * Lp100Km);
        }
        public double Work()
        {
            this.amountOfFuel -= (4 * this.Displacement) / 100;            
            if (this.amountOfFuel <= 0)
                throw new IndexOutOfRangeException("I am drying");
            return this.amountOfFuel;
        }

        public void Refuel(double fuelAmount)
        {
            if (this.amountOfFuel + fuelAmount > this.FuelTankCapacity)
            {
                throw new ArgumentException("Fuel on shoes");

            }
            this.amountOfFuel += fuelAmount;
        }


    }
}
