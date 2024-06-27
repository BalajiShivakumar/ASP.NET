using System;
using System.Text;
using System.Threading;
using System.Linq;
namespace whileLoopTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 20) 
            {
                Console.WriteLine(+n + " * 5 = " + (n * 5));
                n++;
            }
            Console.ReadKey();
        }
    }
}
