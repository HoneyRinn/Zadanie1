using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Num numbers = new Num();
            Sum(numbers);
            Compare(numbers);
            Console.ReadKey();
        }
        static void Sum(Num numbers)
        {
            Console.WriteLine("Введите первую цифру");
            numbers.Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            numbers.Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numbers.Num1} + {numbers.Num2} = { numbers.Num1 + numbers.Num2} ");
        }
        static void Compare(Num numbers)
        {

            if (numbers.Num1 > numbers.Num2)
            {
                Console.WriteLine("Первая цифра больше");
            }
            else if (numbers.Num1 < numbers.Num2)
            {
                Console.WriteLine("Вторая цифра больше");
            }
            else
            {
                Console.WriteLine("Первая и вторая цифры равны");
            }
        }
    }
}
