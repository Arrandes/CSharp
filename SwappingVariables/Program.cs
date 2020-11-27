using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * Написать программу обмена значениями двух переменных.
             * а) с использованием третьей переменной;
             * б) без использования третьей переменной.
             */

            int a, b, c;
            Console.Write("Введите значение для переменной a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для переменной b: ");
            b = int.Parse(Console.ReadLine());

            //С использованием третьей переменной;
            //c = a;
            //a = b;
            //b = c;

            //Без использования третьей переменной
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Значение переменной a: " + a);
            Console.WriteLine("Значение переменной b: " + b);
        }
    }
}
