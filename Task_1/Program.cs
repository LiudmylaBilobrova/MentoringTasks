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
            // ������ �� �������� ����-����� �����
            Console.WriteLine("������ ������� ������");
            int arrayLenth = int.Parse(Console.ReadLine());

            int[] arrayOfRandomNumbers = new int[arrayLenth];
            Random rand = new Random();

            // ���������� ������ ���������� ����������
            Console.WriteLine("���� ������ ��������� ������� �� 0 �� 9999:");
            for (int i = 0; i < arrayLenth; i++)
            {
                arrayOfRandomNumbers[i] = rand.Next(0, 9999);
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

            // ���������� ������ ������� ���������
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
            // ��������� ������������� ������
            Console.WriteLine("³����������� �����:");
            for (int i = 0; i < arrayLenth; i++)
            {
                Console.WriteLine(arrayOfRandomNumbers[i]);
            }
            Console.ReadLine();

        }
    }
}
