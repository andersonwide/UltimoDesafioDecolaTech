using System;

namespace arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
                Console.WriteLine("Array Before Sorting:\n");
                foreach (int value in arr)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine("\n");
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine("Array After Sorting:\n");
                foreach (int value in arr)
                {
                    Console.Write(value + " ");
                }
            }
        }
    }
}
