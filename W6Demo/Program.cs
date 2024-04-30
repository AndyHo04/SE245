using System;

//write a program that checks whether a given string is a palindrome or not using a method that takes a string as input
namespace W6Demo
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i].ToString();
            }
            if (str == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("hello"));
            Console.WriteLine(IsPalindrome("racecar"));
        }
    }
    
}

