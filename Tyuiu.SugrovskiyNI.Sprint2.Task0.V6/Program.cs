using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint2.Task0.V6.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                               * ");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* Вычисляет математическое выражение по исходным значениям данных         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
 

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}
