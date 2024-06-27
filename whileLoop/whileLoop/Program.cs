using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 1;
            Console.WriteLine("Printing all Numbers from 1 to 20");
            while (n <= 20)
            {   
                Console.WriteLine(+n);
                n++;
            }
            Console.ReadKey();

        }
    }
}