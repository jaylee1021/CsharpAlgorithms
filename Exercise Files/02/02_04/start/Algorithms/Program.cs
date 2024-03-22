using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }
            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                // swap index[i] with index(input.Length -i -1)
                // int temp = input[i];
                // input[i] = input[input.Length - i - 1];
                // input[input.Length - i - 1] = temp;
                (input[i], input[input.Length - i - 1]) = (input[input.Length - i - 1], input[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            // Array.ForEach(Reverse(arr), Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.Write);
        }
    }
}