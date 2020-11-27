using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * Ввести вес и рост человека.
             * Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); 
             * где m — масса тела в килограммах, h — рост в метрах
            */

            Console.Write("Пожалуйста, введите ваш рост в сантиметрах: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите ваш вес: ");
            int weight = int.Parse(Console.ReadLine());

            double h = height / 100;
            Console.WriteLine($"Индекс массы тела: { Math.Round((weight / (h * h)), 0)}");
        }
    }
}
