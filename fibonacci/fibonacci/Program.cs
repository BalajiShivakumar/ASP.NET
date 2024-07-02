using System;
using System.Threading;
using System.Text;
using System.Linq;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, a = 0, b = 1, c, n;
            Console.WriteLine("Enter till which number the fibonacci series should be generated : ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                Console.Write(a+",");
                c = a + b;
                a = b;
                b = c;
                i++;
            }
            Console.ReadKey();
        }
    }
}