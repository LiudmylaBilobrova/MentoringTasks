using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Розробити додаток, котрий:
 - Запитує користувача довжину масиву
 - Заповнює новий масив випадковими числами від 0 до 9999
 - Вивести вміст масиву у консоль
 - Пізніше потрібно виконати сортування масиву методом бульбашки
 - Вивести відсортований масив у консоль
 - Вивести мінімальне, максимальне та середнє значення у масиві
 */

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос на введення будь-якого числа
            Console.WriteLine("Введіть довжину масива");
            int arrayLenth = int.Parse(Console.ReadLine());

            int[] arrayOfRandomNumbers = new int[arrayLenth];
            Random rand = new Random();

            // Заповнення масиву рандомними значеннями
            Console.WriteLine("Вміст масива рандомних значень від 0 до 9999:");
            for (int i = 0; i < arrayLenth; i++)
            {
                arrayOfRandomNumbers[i] = rand.Next(0, 9999);
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

            // Сортування масиву методом бульбашки
            for (int i = 0; i < arrayLenth-1; i++)
            {
                for (int j = i +1; j < arrayLenth; j++)
                {
                    if (i > j)
                    {
                        int m = i;
                        i = j;
                        j = m;
                    }
                }
            }
            // Виведення відсортованого масиву
            Console.WriteLine("Відсортований масив:");
            for (int i = 0; i < arrayLenth; i++)
            {
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

        }
    }
}
