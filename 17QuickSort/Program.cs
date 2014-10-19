using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17QuickSort
{
    class Program
    {
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void QuickSort(int[] arr, int left, int right)
        {
            //For Recursion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5,0, 2, 1, 9, 6, 4 };
            int len = numbers.Length;

            Console.WriteLine("QuickSort by Recursive Method");
            QuickSort(numbers, 0, len - 1);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
