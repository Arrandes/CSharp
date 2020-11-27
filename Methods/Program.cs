using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            /*
             * Выполнил: Скворцов Александр
             * 6. Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
             */
            Print("Hello!");
            Pause();
        }
    }
}
