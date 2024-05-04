using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
            double result = 0;
            Console.WriteLine("введите 1 слагаемое: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите 2 слагаемое: ");
            second = Convert.ToDouble(Console.ReadLine());
            int operation;
            Console.WriteLine("введите оперцию: ");
            Console.WriteLine("1 = + \n2 = - \n3 = * \n4 = /");
            operation =Convert.ToInt32(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    result = first + second;
                    break;
                    case 2:
                        result = first - second;
                    break;
                    case 3:
                        result = second * first;
                    break;
                    case 4:
                        result = second / second;
                    break;

                    default: Console.WriteLine("нет такой операции");
                    break;
            }
            Console.WriteLine("ответ = " + result);
            Console.ReadKey();

        }
    }
}
