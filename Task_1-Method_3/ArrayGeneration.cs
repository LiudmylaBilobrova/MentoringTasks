using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Method_3
{
    class ArrayGeneration
    {
        private static void GenerateArray(out int arrayLenth, out int[] arrayOfRandomNumbers)
        {
            // Request for entering a number
            Console.WriteLine("Enter array lenth");
            arrayLenth = int.Parse(Console.ReadLine());
            arrayOfRandomNumbers = new int[arrayLenth];
            Random rand = new Random();

            // Filling array with random values
            Console.WriteLine("Array with random values from 0 to 9999:");
            for (int i = 0; i < arrayLenth; i++)
            {
                arrayOfRandomNumbers[i] = rand.Next(0, 9999);
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
