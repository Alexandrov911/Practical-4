using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
             //задание 2
            Console.WriteLine("введите число b от 10");
            double b = Convert.ToDouble(Console.ReadLine());
            double a = 1;
            for (int i=10; i<=b; i++)
            {
                a = i * (b*b);

                Console.WriteLine(a);

            }
            Console.ReadKey();

        }
    }
}
