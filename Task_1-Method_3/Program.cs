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
            int arrayLenth;
            int[] arrayOfRandomNumbers;
            GenerateArray(out arrayLenth, out arrayOfRandomNumbers);

            SortingArray(arrayLenth, arrayOfRandomNumbers);

            MaxValue(arrayOfRandomNumbers);

            MinValue(arrayOfRandomNumbers);

            AvgValue(arrayOfRandomNumbers);
        }






    }
}
