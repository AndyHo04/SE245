// Name: Andy Ho
// W1 Lab
// Date: 3/28/24
// Description: Enter Student name & four grades and calculate average and assign a letter grade (Bonus if they use 20%, 20%, 25%, 35%)

//calling the library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

//namespace
namespace w1_lab2{
    class program{
        static void Main (string[] args){
            String strName, strGrade1, strGrade2, strGrade3, strGrade4, strLetterGrade;//declare string variables
            Double dblGrade1, dblGrade2, dblGrade3, dblGrade4, dblTotal, dblAverage;//declare double variables
            

            Console.WriteLine ("Welcome to the Grade Calculator");//print out the message

            /*
            The code below is used to read the user's input, asking the user for their name, and the four grades and storing them into the variables strName, strGrade1, strGrade2, strGrade3, and strGrade4.
            */
            Console.Write ("Please enter your name: ");
            strName = Console.ReadLine ();

            Console.Write ("Please enter the first grade: ");
            strGrade1 = Console.ReadLine ();

            Console.Write ("Please enter the second grade: ");
            strGrade2 = Console.ReadLine ();

            Console.Write ("Please enter the third grade: ");
            strGrade3 = Console.ReadLine ();

            Console.Write ("Please enter the fourth grade: ");
            strGrade4 = Console.ReadLine ();

            /*
            convert the numbers to floats(Double)
            */
            dblGrade1 = Convert.ToDouble (strGrade1);
            dblGrade2 = Convert.ToDouble (strGrade2);
            dblGrade3 = Convert.ToDouble (strGrade3);
            dblGrade4 = Convert.ToDouble (strGrade4);

            /*
            The code below is used to calculate the average grade based on the user's input and store the result in the variable dblAverage.
            */
            dblTotal = dblGrade1 + dblGrade2  + dblGrade3  + dblGrade4;
            dblAverage = dblTotal / 4;

            /*
            The code below is used to assign a letter grade based on the average grade.
            */
            if (dblAverage >= 90){
                strLetterGrade = "A";
            }else if (dblAverage >= 80 && dblAverage < 90){
                strLetterGrade = "B";
            }else if (dblAverage >= 70 && dblAverage < 80){
                strLetterGrade = "C";
            }else if (dblAverage >= 60 && dblAverage < 70){
                strLetterGrade = "D";
            }else{
                strLetterGrade = "F";
            }

            Console.WriteLine ($"\n\nHello " + strName + "! Your average grade is: " + dblAverage + " and your letter grade is: " + strLetterGrade);
            Console.WriteLine ($"\n\nPress any key to continue... ");
            Console.ReadKey ();
        }
    }
}