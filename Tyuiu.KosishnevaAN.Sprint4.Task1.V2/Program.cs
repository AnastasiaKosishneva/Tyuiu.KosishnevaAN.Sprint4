using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint4.Task1.V2.Lib;
namespace Tyuiu.KosishnevaAN.Sprint4.Task1.V2
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
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму        *");
            Console.WriteLine("*  1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2                             *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len]; 
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение" + " элемент массива ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i ++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
