using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint4.Task0.V27.Lib;

namespace Tyuiu.KosishnevaAN.Sprint4.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                              *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #27                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение *");
            Console.WriteLine("* нечетных элементов массива. {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}.           *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine("исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Результат произведения:");
            int numArray = ds.GetMultOddArrEl(numsArray);
            Console.WriteLine(numArray);

            Console.ReadKey();
        }
    }
}
