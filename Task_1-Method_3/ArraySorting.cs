using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Method_3
{
    class ArraySorting
    {
        private static void SortingArray(int arrayLenth, int[] arrayOfRandomNumbers)
        {
            // Sorting array by bubble method
            for (int i = 0; i < arrayOfRandomNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfRandomNumbers.Length; j++)
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
        }
    }
}
