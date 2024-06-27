using System;
using System.Text;
using System.Threading;
using System.Linq;

namespace electricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the units used : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 50)
            {
                n = n * 5;
            }
            else if (n <= 150 && n >= 51)
            {
                n = 250 + ((n-50) * 10);
            }
            else
            {
                n = 1250 + ((n - 150) * 15);
            }
            Console.WriteLine("Electricity Bill : " + n);
            Console.ReadKey();
        }
    }
}