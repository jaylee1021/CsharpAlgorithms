using System;


namespace Algorithms
{
    class Program
    {
        static int[] RotateArrayLeft(int[] numbers)
        {
            // excercise solution
            // int temp = numbers[0];
            // for (int i = 0; i < numbers.Length - 1; i++)
            // {
            //     numbers[i] = numbers[i + 1];
            // }
            // numbers[numbers.Length - 1] = temp;

            // my solution
            // for (int i = 0; i < numbers.Length - 1; i++)
            // {
            //     (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
            // }
            // newArray = numbers;
            // return numbers;

            //instructor solution
            int[] rotated = new int[numbers.Length];
            for (int i = 1; i < numbers.Length; i++)
            {
                rotated[i - 1] = numbers[i];
            }
            rotated[rotated.Length - 1] = numbers[0];
            return rotated;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            // RotateArrayLeft(arr);
            Array.ForEach(RotateArrayLeft(arr), Console.WriteLine);
        }
    }
}