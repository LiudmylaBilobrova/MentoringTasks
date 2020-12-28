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
            // Request for entering a number
            Console.WriteLine("Enter array lenth");
            int arrayLenth = int.Parse(Console.ReadLine());

            int[] arrayOfRandomNumbers = new int[arrayLenth];

            Random rand = new Random();

            // Filling array with random values
            Console.WriteLine("Array with random values from 0 to 9999:");
            for (int i = 0; i < arrayLenth; i++)
            {
                arrayOfRandomNumbers[i] = rand.Next(0, 9999);
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

            // Sorting array by bubble method
            for (int i = 0; i < arrayOfRandomNumbers.Length - 1; i++)
            {
                for (int j = i +1; j < arrayOfRandomNumbers.Length; j++)
                {
                    if (arrayOfRandomNumbers[i] > arrayOfRandomNumbers[j])
                    {
                        int m = arrayOfRandomNumbers[i];
                        arrayOfRandomNumbers[i] = arrayOfRandomNumbers[j];
                        arrayOfRandomNumbers[j] = m;
                    }
                }
            }
            // Printing sorted array
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arrayLenth; i++)
            {
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

            // Finding max value
            int maxValue = arrayOfRandomNumbers[0];
            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                if (arrayOfRandomNumbers[i] > maxValue)
                {
                    maxValue = arrayOfRandomNumbers[i];
                }
            }
            Console.WriteLine("Max value of array is {0}", maxValue);
            Console.ReadLine();

            // Finding min value
            int minValue = arrayOfRandomNumbers[0];
            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                if (arrayOfRandomNumbers[i] < minValue)
                {
                    minValue = arrayOfRandomNumbers[i];
                }
            }
            Console.WriteLine("Min value of array is {0}", minValue);
            Console.ReadLine();

            // Finding average value
            int sum = 0;
            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                sum += arrayOfRandomNumbers[i];
            }
            int averageValue = sum / arrayOfRandomNumbers.Length;
            Console.WriteLine("Average value of array is {0}", averageValue);
            Console.ReadLine();
        }
    }
}
