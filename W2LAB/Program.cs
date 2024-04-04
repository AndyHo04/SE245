//Name-Andy Ho
//Date-4/4/24
/*
Program Prompt: 
Create a program that:

1. Asks users to enter a number of students, or handle the number of students dynamically.

2. For each student, enter a name and 5 lab grades. 

3. Display each student with each average grade for their 5 labs, and their letter grade. 

4. Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            String strName, str1, str2, str3, str4, str5, strLetter, strCount;
            Double dblGrade1, dblGrade2, dblGrade3, dblGrade4, dblGrade5, stuAverage, allStuAvg, dblTotal = 0;
            Int32  intCounter = 0; 
            bool success = false; 
            bool lab1 = false; 
            bool lab2 = false; 
            bool lab3 = false;
            bool lab4 = false;
            bool lab5 = false;

            //Ask user for number of students
            do{
                Console.WriteLine ("\tHow many students do you want to enter?");
                strCount = Console.ReadLine ();
                success = Int32.TryParse(strCount, out intCounter);
                if(!success){
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 4.");
                }
            }while(!success);

            //Create a list of students
            List<string> students = new List<string>();
            List<double> lab1grades = new List<double>();
            List<double> lab2grades = new List<double>();
            List<double> lab3grades = new List<double>();
            List<double> lab4grades = new List<double>();
            List<double> lab5grades = new List<double>();

            //ask for all student information
            for (int intCount = 0; intCount < intCounter; intCount++){
                Console.WriteLine ("\tPlease enter the student's name: ");
                strName = Console.ReadLine ();
                students.Add(strName);

                //Ask for lab grades
                do{
                    Console.WriteLine ("\tPlease enter the student's grade for lab 1: ");
                    str1 = Console.ReadLine ();
                    lab1 = Double.TryParse(str1, out dblGrade1);
                    if(!lab1){
                        Console.WriteLine ("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                    }
                }while(!lab1);
                lab1grades.Add(dblGrade1);

                do{
                    Console.WriteLine ("\tPlease enter the student's grade for lab 2: ");
                    str2 = Console.ReadLine ();
                    lab2 = Double.TryParse(str2, out dblGrade2);
                    if(!lab2){
                        Console.WriteLine ("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                    }
                }while(!lab2);
                lab2grades.Add(dblGrade2);

                do{
                    Console.WriteLine ("\tPlease enter the student's grade for lab 3: ");
                    str3 = Console.ReadLine ();
                    lab3 = Double.TryParse(str3, out dblGrade3);
                    if(!lab3){
                        Console.WriteLine ("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                    }
                }while(!lab3);
                lab3grades.Add(dblGrade3);

                do{
                    Console.WriteLine ("\tPlease enter the student's grade for lab 4: ");
                    str4 = Console.ReadLine ();
                    lab4 = Double.TryParse(str4, out dblGrade4);
                    if(!lab4){
                        Console.WriteLine ("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                    }
                }while(!lab4);
                lab4grades.Add(dblGrade4);

                do{
                    Console.WriteLine ("\tPlease enter the student's grade for lab 5: ");
                    str5 = Console.ReadLine ();
                    lab5 = Double.TryParse(str5, out dblGrade5);
                    if(!lab5){
                        Console.WriteLine ("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                    }
                }while(!lab5);
                lab5grades.Add(dblGrade5);
            }
            //Calculate the average for each lab
            double lab1Average = Math.Round(lab1grades.Sum() / lab1grades.Count, 2);
            double lab2Average = Math.Round(lab2grades.Sum() / lab2grades.Count, 2);
            double lab3Average = Math.Round(lab3grades.Sum() / lab3grades.Count, 2);
            double lab4Average = Math.Round(lab4grades.Sum() / lab4grades.Count, 2);
            double lab5Average = Math.Round(lab5grades.Sum() / lab5grades.Count, 2);



            //Print out each students information
            foreach(string student in students){
                int index = students.IndexOf(student);
                stuAverage = (lab1grades[index] + lab2grades[index] + lab3grades[index] + lab4grades[index] + lab5grades[index]) / 5;
                dblTotal += stuAverage;
                if (stuAverage >= 90){
                    strLetter = "A";
                }else if (stuAverage >= 80 && stuAverage < 90){
                    strLetter = "B";
                }else if (stuAverage >= 70 && stuAverage < 80){
                    strLetter = "C";
                }else if (stuAverage >= 60 && stuAverage < 70){
                    strLetter = "D";
                }else{
                    strLetter = "F";
                }
                Console.WriteLine ($"\n\n\tName:" + student + "\n\n\tLab 1:" + lab1grades[index] + "\n\n\tLab 2:" + lab2grades[index] + "\n\n\tLab 3:" + lab3grades[index] + "\n\n\tLab 4:" + lab4grades[index] + "\n\n\tLab 5:" + lab5grades[index] + "\n\n\tAverage:" + stuAverage + "\n\n\tLetter Grade:" + strLetter);
            }
            // Print out the average for each lab
            Console.WriteLine ($"\n\n\tThe Averages For Each Lab\n\n\tLab 1 Average:" + lab1Average + "\n\n\tLab 2 Average:" + lab2Average + "\n\n\tLab 3 Average:" + lab3Average + "\n\n\tLab 4 Average:" + lab4Average + "\n\n\tLab 5 Average:" + lab5Average);
            Console.WriteLine ($"\n\n\tPress any key to continue... ");
            Console.ReadKey ();
         }   
    }
}

    

