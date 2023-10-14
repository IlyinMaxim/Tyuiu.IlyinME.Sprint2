using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IlyinME.Sprint2.Task5.V7.Lib;

namespace Tyuiu.IlyinME.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ильин М. Е. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Ильин Максим Евгеньевич | АСОиУБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество прошедших месяцев:");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;
            if (n < 0)
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindMonthName(1990, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
