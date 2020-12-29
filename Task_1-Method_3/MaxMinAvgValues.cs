using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Method_3
{
    class MaxMinAvgValues
    {
        private static void AvgValue(int[] arrayOfRandomNumbers)
        {
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

        private static void MinValue(int[] arrayOfRandomNumbers)
        {
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
        }

        private static void MaxValue(int[] arrayOfRandomNumbers)
        {
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
        }
    }
}
