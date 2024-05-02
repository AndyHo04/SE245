using System;

//write a program that checks whether a given string is a palindrome or not using a method that takes a string as input
namespace W6Demo
{
    class Program
    {
            static bool IsPalindrome(string str)
            {
                if (str.Length == 0)
                {
                    return true;
                }
                str = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

                for (int i = 0; i <= (str.Length - 1) / 2; i++)
                {
                    Console.WriteLine(str[i]);
                    Console.WriteLine(str[str.Length - 1 - i]);
                    if (char.ToLower(str[i]) != char.ToLower(str[str.Length - 1 - i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            static void Main(string[] args)
            {
                Console.WriteLine(IsPalindrome("hello"));
                Console.WriteLine(IsPalindrome("Racecar"));

            }
        }
    
}

