using System;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 17, 11, 9, 3, 4, 11, 6, 11, 8, 7 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }
        static void printRepeating(int[] arr, int size)
        {
            int i, j;

            Console.WriteLine("Repeated Elements are :");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[i] + " ");
                    Console.ReadLine();
                }
            }
        }
    }
}
