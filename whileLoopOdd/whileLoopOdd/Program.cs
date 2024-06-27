using System;
using System.Text;
using System.Threading;
using System.Linq;
namespace whileLoopOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine("Printing all odd numbers from 1 to 20");
            while (n <= 20)
            {
                Console.WriteLine(+n);
                n=n+2;
            }
            Console.ReadKey();
        }
        
    }
}
