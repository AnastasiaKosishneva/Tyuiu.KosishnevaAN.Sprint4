﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint4.Task4.V4.Lib;

namespace Tyuiu.KosishnevaAN.Sprint4.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 3 до 9.              *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();


            Console.WriteLine("Введите количество строк массива");

            Console.Write("Введите количество строк в массиве: ");

            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количство столбцов в массиве: ");

            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[rows, columns];

            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговый массив: ");
            int[,] res = ds.Calculate(mas);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
