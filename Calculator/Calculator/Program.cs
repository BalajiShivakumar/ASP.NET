using System;
using System.Threading;
using System.Text;
using System.Collections;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            int var1, var2, choice;
            Console.WriteLine("Enter 2 numbers: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Option 1-4 : ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum is " + (var1 + var2));
                    break;
                case 2:
                    Console.WriteLine("Difference is " + (var1 - var2));
                    break;
                case 3:
                    Console.WriteLine("Sum is " + (var1 / var2));
                    break;
                case 4:
                    Console.WriteLine("Product is " + (var1 * var2));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.WriteLine("Execution Completed");
            Console.WriteLine("Execution Completed");
            Console.WriteLine("Execution Completed");
        }
    }

}