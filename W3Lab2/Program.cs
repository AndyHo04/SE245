// Name - Andy
//Lab 2
//Date - 4/12/24
/*Prgram Prompt:
Create a program that:
Option #2 - Calculate payroll with Name, hour, hourly rate, along with taxes deducted based on tax bracket and store each in a series of lists.  Loop through the lists, calculate the pay, and display it with the person’s name.  Calculate and display the average income and display it.
*/

using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace W3Lab2{
    class program{

        static void Pause(){
            Console.WriteLine("\tPress any Key to end program");
            Console.ReadKey();

        }
        static int GetEmployeeCount(){
            string strPeople;
            int Count;
            bool success;
             do{
                Console.WriteLine("\tPlease enter the amount of people you want to enter:");
                strPeople = Console.ReadLine();
                success = Int32.TryParse(strPeople, out Count);
                if(!success){
                    Console.WriteLine("\n\tYou did not enter a valid number. ex:4");
                }
            }while(!success);
            return Count;
        }

        static void GetEmployeeName(ref List<string> Names){
            string strName;
            Console.WriteLine("\tPlease enter the employees name:");
            strName = Console.ReadLine(); 
            Names.Add(strName);
        }
        static void GetEmployeeInformation(ref List<double> HoursWorked, ref List<double> HourlyRate){
            string strHours, strRate;
            double dblHours, dblRate;
            bool hours = false;
            bool rates = false;
            do{
                Console.WriteLine("\tPlease the hours worked:");
                strHours = Console.ReadLine();
                hours = Double.TryParse(strHours, out dblHours);
                if(!hours){
                     Console.WriteLine("you did not enter a valid number. ex:4.5");
                }

            }while(!hours);
            HoursWorked.Add(dblHours);
            do{
                Console.WriteLine("\tPlease enter the hourly_rate: ");
                strRate = Console.ReadLine();
                rates = Double.TryParse(strRate, out dblRate);
                if(!rates){
                    Console.WriteLine("You did not enter a valud number. ex:4.5");
                }
            }while(!rates);
            HourlyRate.Add(dblRate);
        }

        static double GetTax(ref double GrossPay){
            double Tax = 0;
            if (GrossPay >= 1000){
                Tax = Math.Round(GrossPay * 0.50, 2);
            }else if (GrossPay>= 500 && GrossPay < 1000){
                Tax = Math.Round(GrossPay * 0.30, 2);
            }else if (GrossPay >= 300 && GrossPay < 500){
                Tax = Math.Round(GrossPay * 0.10, 2);
            }else if (GrossPay < 300){
                Tax = 0;
            } 
            return Tax;
        }
        
        static void DisplayEmployeeInformation(List<string> Names, List<double> HoursWorked, List<double> HourlyRate,  List<double> Net){
            double GrossPay, NetPay, Tax;
            foreach(string name in Names){
                int index = Names.IndexOf(name);
                GrossPay = Math.Round(HoursWorked[index] * HourlyRate[index], 2);
                Tax = GetTax(ref GrossPay);
                NetPay = GrossPay - Tax;
                Net.Add(NetPay);

                Console.WriteLine($"\n\tName: " + name + "\n\tHours Worked: " + HoursWorked[index] + "\n\tHourly Rate:$ " + HourlyRate[index] + "\n\tGross Pay:$ " + GrossPay + "\n\tTax:$ " + Tax + "\n\tNet:$ " + Net[index]);
            }
        }

        static void Average(ref List<double> Net, ref List<string> Names){
            double dblAverage;
            dblAverage = Math.Round(Net.Sum()/Names.Count, 2);
            Console.WriteLine($"\n\tThe Average Pay for all employees is$ " + dblAverage);
        }
        
        static void Main(string[] args){
            double dblAverage;
            Int32 IntCount;
            
            
            Console.WriteLine("\tWelcome to the Gross Pay Calculator");
        
            
            List<string> Names = new List<string>();
            List<double> HoursWorked = new List<double>();
            List<double> HourlyRate = new List<double>();
            List<double> Net = new List<double>();
            //List<double> Gross = new List<double>();
            IntCount = GetEmployeeCount();
            
            for(int IntCounter = 0; IntCounter < IntCount; IntCounter++){
                GetEmployeeName(ref Names);

                GetEmployeeInformation(ref HoursWorked, ref HourlyRate);
            }
            
            DisplayEmployeeInformation(Names, HoursWorked, HourlyRate, Net);
            Average(ref Net, ref Names);
            Pause();
        }


    }
}