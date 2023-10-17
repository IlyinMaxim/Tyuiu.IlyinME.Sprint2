using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IlyinME.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {   
            string monthName;
            switch (n % 12 + 1)
            {
                case 1:
                    monthName = "январь";
                    break;
                case 2:
                    monthName = "февраль";
                    break;
                case 3:
                    monthName = "март";
                    break;
                case 4:
                    monthName = "апрель";
                    break;
                case 5:
                    monthName = "май";
                    break;
                case 6:
                    monthName = "июнь";
                    break;
                case 7:
                    monthName = "июль";
                    break;
                case 8:
                    monthName = "август";
                    break;
                case 9:
                    monthName = "сентябрь";
                    break;
                case 10:
                    monthName = "октябрь";
                    break;
                case 11:
                    monthName = "ноябрь";
                    break;
                case 12:
                    monthName = "декабрь";
                    break;
                default:
                    throw new ArgumentException($"Проверте число месяцев ({n})");
                       
            }
            return monthName;
            
        }
    }
}

