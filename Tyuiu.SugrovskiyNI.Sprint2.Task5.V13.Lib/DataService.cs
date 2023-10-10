using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SugrovskiyNI.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int month)
        {
            string season;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Зима";
                    break;

                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;

                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;

                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;

                default:
                    throw new ArgumentException($"Неправильно введен номер месяца.Значение {month}");                
            }
            return season;
        }
    }
}