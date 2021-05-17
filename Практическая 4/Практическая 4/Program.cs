using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_4
{
    class Program
    {
        static void Main(string[] args)
        {
             // задание 1
            Console.WriteLine("введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("одного из чисел 1 2 3 4 ( которые соответствуют +, -, *, /) ");
            double z = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (z)
            {
                case 1:
                    {
                        c = x + y;
                        break;
                    }
                case 2:
                    {
                        c = x - y;
                        break;
                    }
                case 3:
                    {
                        c = x * y;
                        break;
                    }
                case 4:
                    {
                        c = x / y;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка выбора оператора ");
                        break;
                    }
            }
            Console.WriteLine("Ответ:" + c);
            Console.ReadKey();

        }
    }
}
