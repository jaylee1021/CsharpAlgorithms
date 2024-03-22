using System;
using System.Linq;
namespace Algorithms
{
    class Program
    {

        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(IsUppercase("hello"));
            // Console.WriteLine(IsUppercase("HELLO"));

            // Console.WriteLine(IsLowercase("hello"));
            // Console.WriteLine(IsLowercase("HELLO"));

            Console.WriteLine(IsPasswordComplex("Hell0"));
            Console.WriteLine(IsPasswordComplex("Hello"));
            Console.WriteLine(IsPasswordComplex("HellO"));
            Console.WriteLine(IsPasswordComplex("HeLlo"));
            Console.WriteLine(IsPasswordComplex("hello"));
            Console.WriteLine(IsPasswordComplex(" "));
        }

    }
}