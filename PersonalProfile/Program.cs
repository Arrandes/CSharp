using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProfile
{
    class Program
    {
        static void Position(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
             * б) Сделать задание, только вывод организуйте в центре экрана
             * в) Сделать задание б с использованием собственных методов 
             * (например, Print(string ms, int x,int y)
             */

            Position(42, 12);
            Console.WriteLine("Скворцов Александр, Санкт-Петербург");
        }
    }
}
