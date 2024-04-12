//Name-Andy Ho
//Lab 3
//Date-4/11/24
/*
Program Prompt: 
Create a program that:
Option #1 - For each student, enter a name and 5 lab grades.  Display each student with each average grade for their 5 labs, and their letter grade.  Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3LAB
{
    class Program
    {   
        //create a method for pause
        static void Pause(){
            Console.WriteLine("\n\n\tPress any key to continue... ");
            Console.ReadKey();
        }
        //create a method to get input from the user about how many students they want to enter
        static int GetStudentCount(){
            string strCount;
            int intCounter;
            bool success = false;
            do{
                Console.WriteLine ("\tHow many students do you want to enter?");
                strCount = Console.ReadLine ();
                success = Int32.TryParse(strCount, out intCounter);
                if(!success){
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 4.");
                }
            }while(!success);
            return intCounter;
        }
        //create a method to get input from the user about student name
        static void GetStudentName(ref List<string> student){
            string strName;
            Console.WriteLine ("\tPlease enter the student's name: ");
            strName = Console.ReadLine();
            student.Add(strName);
           
        }
        //Create a method to get input from the user about student name and lab grades
        static void GetGradeLab(string lab, List<double> labGrades){
            string strGrade;
            double dblGrade;
            bool Valid = false;
            do{
                Console.WriteLine($"\tPlease enter the student's grade for {lab}: ");
                strGrade = Console.ReadLine();
                Valid = Double.TryParse(strGrade, out dblGrade);
                if(!Valid){
                    Console.WriteLine("\n\tSorry, but you did not enter a valid real number in digits: Ex 4.");
                }
            }while(!Valid);
            labGrades.Add(dblGrade);
        }
        //Create a method to calculate the average of the lab grades
        static double CalculateAverage(List<double> labGrades){
            return Math.Round(labGrades.Sum() / labGrades.Count, 2);
        }
        //Create a method to calculate the letter grade
        static string CalculateLetterGrade(double average){
            if (average >= 90){
                return "A";
            }else if (average >= 80 && average < 90){
                return "B";
            }else if (average >= 70 && average < 80){
                return "C";
            }else if (average >= 60 && average < 70){
                return "D";
            }else{
                return "F";
            }
        }
        //Create a method to print out the student information
        static void PrintStudentInfo(List<string> students, List<double> lab1grades, List<double> lab2grades, List<double> lab3grades, List<double> lab4grades, List<double> lab5grades){
            double stuAverage;
            string strLetter;
            foreach(string student in students){
                int index = students.IndexOf(student);
                stuAverage = (lab1grades[index] + lab2grades[index] + lab3grades[index] + lab4grades[index] + lab5grades[index]) / 5;
                strLetter = CalculateLetterGrade(stuAverage);
                Console.WriteLine ($"\n\n\tName:" + student + "\n\n\tLab 1:" + lab1grades[index] + "\n\n\tLab 2:" + lab2grades[index] + "\n\n\tLab 3:" + lab3grades[index] + "\n\n\tLab 4:" + lab4grades[index] + "\n\n\tLab 5:" + lab5grades[index] + "\n\n\tAverage:" + stuAverage + "\n\n\tLetter Grade:" + strLetter);
            }
        }
        static void Main(string[] args)
        {
            //Declare Variables
            Int32  intCounter = 0; 
            bool success = false; 
            bool lab1 = false; 
            bool lab2 = false; 
            bool lab3 = false;
            bool lab4 = false;
            bool lab5 = false;

            //Ask user for number of students
            intCounter = GetStudentCount();

            //Create a list of students
            List<string> students = new List<string>();
            List<double> lab1grades = new List<double>();
            List<double> lab2grades = new List<double>();
            List<double> lab3grades = new List<double>();
            List<double> lab4grades = new List<double>();
            List<double> lab5grades = new List<double>();

            //ask for all student information
            for (int intCount = 0; intCount < intCounter; intCount++){
                GetStudentName(ref students);

                //Ask for lab grades
                GetGradeLab("lab 1", lab1grades);
                GetGradeLab("lab 2", lab2grades);
                GetGradeLab("lab 3", lab3grades);
                GetGradeLab("lab 4", lab4grades);
                GetGradeLab("lab 5", lab5grades);
            }
            //Calculate the average for each lab
            double lab1Average = CalculateAverage(lab1grades);
            double lab2Average = CalculateAverage(lab2grades);
            double lab3Average = CalculateAverage(lab3grades);
            double lab4Average = CalculateAverage(lab4grades);
            double lab5Average = CalculateAverage(lab5grades);
    
            //Print out each students information
            PrintStudentInfo(students, lab1grades, lab2grades, lab3grades, lab4grades, lab5grades);
            // Print out the average for each lab
            Console.WriteLine ($"\n\n\tThe Averages For Each Lab\n\n\tLab 1 Average:" + lab1Average + "\n\n\tLab 2 Average:" + lab2Average + "\n\n\tLab 3 Average:" + lab3Average + "\n\n\tLab 4 Average:" + lab4Average + "\n\n\tLab 5 Average:" + lab5Average);
            Console.WriteLine ($"\n\n\tPress any key to continue... ");
            Console.ReadKey ();
        }   
    }

   
}

    


