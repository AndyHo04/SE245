using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Demo{
    class Program{

        static string reverseString(string str){
            string reversed = "";
            Console.WriteLine($"INPUT:" + str + "\n");
            Console.Write("OUTPUT:");
            for(int i = str.Length - 1; i >= 0; i--){
               reversed += str[i].ToString();
            }   
            /*
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
            */
            return reversed;
        }
        static void Main(string[] args){
            
            /*
            for (int i = 1; i <= 20; i++){
               
               for (int j = 1; j <= 20; j++){
                    Console.Write($"{i * j}\t");
               }

               Console.WriteLine();
        
            */
            Console.WriteLine(reverseString("hello"));

            

        }
    }
}

