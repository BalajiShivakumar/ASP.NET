using System;
using System.Text;
using System.Threading;
using System.Linq;

namespace factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            i = 1;
            Console.WriteLine("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            while (i < n)
            {
                if (n % i == 0)
                {
                    Console.Write(i+" ,");
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}