using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static double MathCoordinates(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * а) Написать программу, которая подсчитывает расстояние между точками с координатами 
             * x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
             * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
             * б) Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
             */

            int x1, x2, y1, y2;
            Console.Write("Пожалуйста, введите x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите y2: ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ответ: {0:F2}", MathCoordinates(x1, x2, y1, y2));
        }
    }
}
