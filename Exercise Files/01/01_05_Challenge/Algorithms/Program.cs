using System;
using System.Text;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static String ReverseEachWord(String sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }

            String[] arr = sentence.Split(" ");

            StringBuilder newArr = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                newArr.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    newArr.Append(" ");
                }
            }
            return newArr.ToString();
        }

        static String ReverseEachWord2(String sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }

            string[] words = sentence.Trim().Split(" ");
            string[] reverseWords = words.Select(Reverse).ToArray();
            string reversedSentence = string.Join(" ", reverseWords);
            return reversedSentence;
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }



        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));

            Console.WriteLine(ReverseEachWord2("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord2(null));
            Console.WriteLine(ReverseEachWord2("racer racecar madam"));
            Console.WriteLine(ReverseEachWord2("what can I do today"));
            Console.WriteLine(ReverseEachWord2(" "));
        }
    }
}