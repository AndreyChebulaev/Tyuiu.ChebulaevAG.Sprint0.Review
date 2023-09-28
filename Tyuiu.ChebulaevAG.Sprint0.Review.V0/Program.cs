using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint0.Review.V0.Lib;

namespace Tyuiu.ChebulaevAG.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview #0                                                 *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет следующее        *");
            Console.WriteLine("* Выражение (x+y+z)*5 и возвращает целочисленное значение                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение x:");
            
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение z:");
            int z = int.Parse(Console.ReadLine());

            DataService calculator = new DataService();
            int result = calculator.Calc(x, y, z);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine($"Результат вычисления: {result}");

            Console.ReadKey();
        }
    }
}
