using System;

namespace BubbleSort
{
    class MySort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            Console.WriteLine("The array before sorting is: ");
            foreach (int p in arr)
                Console.Write(p + " ");
            


            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The array after sorting is:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}