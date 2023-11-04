using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint4.Task3.V20.Lib;

namespace Tyuiu.KosishnevaAN.Sprint4.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] {  { 8, 7, 7, 8, 5 },
                                           { 4, 3, 5, 3, 6 },
                                           { 5, 3, 8, 6, 3 },
                                           { 6, 3, 8, 5, 4 },
                                           { 3, 6, 8, 3, 4 }, };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;
            Console.Title = "Спринт #4 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                              *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Вариант #27                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный       *");
            Console.WriteLine("* случайными в диапазоне от 2 до 7 подсчитать сумму четных              *");
            Console.WriteLine("* элементов массива.                                                    *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите количество элементов массива:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("минимальный элемент = " + res);
            
            Console.ReadKey();
        }
    }
}
