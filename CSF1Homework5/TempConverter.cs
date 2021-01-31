using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework5
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temp Converter");
            Console.Title = "Temperature Converter";




            string enterTemp = ("Please enter your temperature in ");
            string fahString = ("Fahrenheit: ");
            string celString = ("Celsius: ");

            Console.Clear();
            bool repeat = true;
            Console.WriteLine("Welcome to temperature converter 3000! Press Enter!");
            Console.ReadLine();
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Would you like to convert from:\n" +
               "Press F) Fahrenheit\n" +
               "Press C) Celsius");
                ConsoleKey userSelect = Console.ReadKey().Key;
                Console.Clear();

                switch (userSelect)
                {
                    case ConsoleKey.F:
                        Console.WriteLine($"{enterTemp}{fahString}");
                        double cel = double.Parse(Console.ReadLine().Trim());
                        double fah = (cel * 1.8) + 32;
                        Console.ReadLine();
                        Console.WriteLine($"Great, here is your conversion from Celsius to Fahrenheit! F:{fah}");
                        Console.ReadLine();
                        Console.WriteLine("Would you like to start from beginning? Y/N");
                        ConsoleKey restart = Console.ReadKey().Key;
                        switch (restart)
                        {
                            case ConsoleKey.Y:
                                repeat = false;
                                break;

                            case ConsoleKey.N:
                                repeat = true;

                                break;
                                

                        }
                        break;


                    case ConsoleKey.C:
                        Console.WriteLine($"{enterTemp}{celString}");
                        double fah2 = double.Parse(Console.ReadLine());
                        double cel2 = (fah2 - 32) / 1.8;
                        Console.WriteLine($"Great, here is your conversion from Fahrenheit to Celsius! C:{cel2}");
                        Console.ReadLine();
                        Console.WriteLine("Would you like to start from beginning? Y/N");
                        ConsoleKey restart2 = Console.ReadKey().Key;
                        switch (restart2)
                        {
                            case ConsoleKey.Y:
                                repeat = false; ;
                                break;

                            case ConsoleKey.N:
                                repeat = true;
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("that wasn't an option.");
                        break;
                }        

            } while (repeat == false);
            Console.Clear();
            Console.WriteLine("Okay then peace out!");
            
           



































        }//End Main()
    }//End class
}//End Namespace
