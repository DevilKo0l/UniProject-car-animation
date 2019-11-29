using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var carInformationInput = CarInformationArray();
                var make = Convert.ToString(carInformationInput[0]);
                var model = Convert.ToString(carInformationInput[1]);
                var displacement = Convert.ToDouble(carInformationInput[2]);
                var amountOfFuel = Convert.ToDouble(carInformationInput[3]);
                var distance = Convert.ToDouble(carInformationInput[4]);

                Console.Clear();
                var newCar = new Car(make, model, displacement, amountOfFuel, distance);
                try
                {                    
                    newCar.Go(distance);                    
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("You go too farrrrrr!! neva see ya again\n");
                }
                catch (IndexOutOfRangeException)
                {                    
                    do
                    {
                        Console.Write("\nEnter amount of fuel:");
                        double fuel = Convert.ToDouble(carInformationInput[4]);
                        newCar.Refuel(fuel);

                    } while (askUserForRepeat("\nDo you want to continue thride(1.Yes / 2.No):"));

                }
                
            } while (askUserForRepeat("\nDo you want to start again(1.Yes / 2.No): ")== true);

        }

        private enum MenuAction : int
        {
            Yes = 1,
            No = 0
        }
        static private Object[] CarInformationArray()
        {
            Object[] carInformationInputArr = new Object[5] ;
            double input = 0;
            Console.Write("What is your car made of: ");
            carInformationInputArr[0] = Console.ReadLine();
            Console.Write("What is your car model: ");
            carInformationInputArr[1] = Console.ReadLine();            
            carInformationInputArr[2] = checkValidInput("Please enter the capacity of your engine: ",input);            
            carInformationInputArr[3] = checkValidInput("Please enter amount of fuel: ", input);
            carInformationInputArr[4] = checkValidInput("Please enter your distance: ",input);

            return carInformationInputArr;
        }
        static private bool askUserForRepeat(string text)
        {            
            Console.Write(text);
            
            double userInput;
            if (tryGetInput(out userInput))
            {
                if (userInput == (double)MenuAction.Yes)
                {
                    Console.Clear();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        
        static private bool tryGetInput(out double input)
        {
            return double.TryParse(Console.ReadLine(), out input);
        }

        static private double checkValidInput(string messenge, double input)
        {
            do
            {
                Console.Write(messenge);

                if (tryGetInput(out input))
                {
                    break;
                }
                else
                {                    
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write("Wrong input!!!");
                }

            } while (true);

            return input;
        }
        
        
    }
}
