using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ��������� �������, ������:
 - ������ ����������� ������� ������
 - �������� ����� ����� ����������� ������� �� 0 �� 9999
 - ������� ���� ������ � �������
 - ϳ���� ������� �������� ���������� ������ ������� ���������
 - ������� ������������ ����� � �������
 - ������� ��������, ����������� �� ������ �������� � �����
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

        }
    }
}
