using System;
using System.Text;
using System.Threading;
using System.Linq;

namespace whileLoopReverse
{
    class Program
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the value of n: ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Printing all number from " + n + " to 0");
            while (n >= 0)
            {
                Console.WriteLine(+n);
                n--;
            }
            Console.ReadKey();
        }
    }
}