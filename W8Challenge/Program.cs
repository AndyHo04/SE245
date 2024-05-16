//create a program that returns the length of the last word in the string

namespace W8Challenge
{
    class Program
    {
        static int LengthOfLastWord(string str)
        {
            //ignore space at the end of the string
            str = str.Trim();
            string[] words = str.Split(' ');
            return words[words.Length - 1].Length;
        }

        public static int FindLengthOfLastWord(string str)
        {
            int length = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    if (length > 0)
                    {
                        //return length;
                        break;
                    }
                }
                else
                {
                    length++;
                }
            }
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("hello world"));
            Console.WriteLine(LengthOfLastWord("hello"));
            Console.WriteLine(LengthOfLastWord("hello world this is a test"));
            Console.WriteLine(LengthOfLastWord("Amazing world of   dragon   "));
            Console.WriteLine(FindLengthOfLastWord("Philospher stone of wisdom"));
        }
    }
}
