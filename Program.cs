using System;

namespace BinarySearchSortedListAlgorithm
{
    class Program
    {
        static int Binarysearch(int[] arr, int n, int value)
        {
            int Left = 0;
            int Right = n - 1;
            int Mid;

            while (Left <= Right)
            {
                Mid = (Left + Right) / 2; 
                if (arr[Mid] == value)
                {
                    return Mid;
                }
                if (arr[Mid] < value)
                {
                    Left = Mid + 1;
                }
                else
                {
                    Right = Mid - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 5;
            int result = Binarysearch(arr, arr.Length, n);

            if (result != -1)
            {
                Console.WriteLine("The position of value: " + result);
            }
            else
            {
                Console.WriteLine("Value not found in the array.");
            }
        }
    }
}
