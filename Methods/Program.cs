using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20, 30);
            Console.WriteLine(result);
            var result2 = Add3(20);
            Console.WriteLine(result2);
            Console.WriteLine(Add4(7, 8, 6, 5));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2 = 30)//Default Parametreli Metot(Default değer sonda verilmeli)
        {
            var result2 = number1 + number2;
            return result2;
        }
        //Ref, Out Keyword / Method Overloading

        static int Add4(params int[] numbers)//params ile methoda aynı tipte istediğin kadar parametre gönderebilirsin.
        {
            return numbers.Sum();
        }
    }
}
