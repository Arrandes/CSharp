using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * Написать программу «Анкета».
             * Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
             * В результате вся информация выводится в одну строчку.
             * а) используя склеивание;
             * б) используя форматированный вывод;
             * в) используя вывод со знаком $.
             */

            string firstName, lastName, age, height, weight;
            Console.Write("Пожалуйста, введите ваше имя: ");
            firstName = Console.ReadLine();
            Console.Write("Пожалуйста, введите вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Пожалуйста, введите ваш возраст: ");
            age = Console.ReadLine();
            Console.Write("Пожалуйста, введите ваш рост: ");
            height = Console.ReadLine();
            Console.Write("Пожалуйста, введите ваш вес: ");
            weight = Console.ReadLine();

            //Используя склеивание
            Console.WriteLine("Полученные данные: " + firstName + " " + lastName + " " + age + " " + height + " " + weight + " ");
            //Используя форматированный вывод;
            Console.WriteLine("Полученные данные: {0} {1} {2} {3} {4}",
                                firstName,
                                lastName,
                                age,
                                height,
                                weight);
            //Используя вывод со знаком $
            Console.WriteLine($"Полученные данные {firstName} {lastName} {age} {height} {weight}");
        }
    }
}
