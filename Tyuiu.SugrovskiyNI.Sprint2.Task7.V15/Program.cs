using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint2.Task7.V15.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                         *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #15                                                               *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу которая запрашивает исходные данные                    *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y в заштрихованной области *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите значение переменной X  ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y  ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }

            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
