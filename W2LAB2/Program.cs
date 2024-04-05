// Name - Andy
//Date - 4/5/24
/*Prgram Prompt:
Create a program that:

1. Calculates and displays employee pay for a 40 hour work week.

2. Asks users to enter a number of employees, or handle the number of employees dynamically.

3. Input: name, hours worked, hourly rate, along with taxes deducted based on tax bracket and store each in a series of lists. 

4. For each employee loop through the lists, calculate the pay, and display it with the person’s name. 

5. Calculate and display the average income and display it.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2LAB2{
    class program{
        static void Main(string[] args){
            string strName, strHours, strRate, strPeople;
            double dblHours, dblRate, GrossPay, Tax = 0, NetPay, dblAverage;
            Int32 IntCount;
            bool success = false;
            bool hours = false;
            bool rates = false;
            
            Console.WriteLine("\tWelcome to the Gross Pay Calculator");
            do{
                Console.WriteLine("\tPlease enter the amount of people you want to enter:");
                strPeople = Console.ReadLine();
                success = Int32.TryParse(strPeople, out IntCount);
                if(!success){
                    Console.WriteLine("\n\tYou did not enter a valid number. ex:4");
                }
            }while(!success);
            
            List<string> Names = new List<string>();
            List<double> HoursWorked = new List<double>();
            List<double> HourlyRate = new List<double>();
            List<double> Net = new List<double>();
            //List<double> Gross = new List<double>();

            for(int IntCounter = 0; IntCounter < IntCount; IntCounter++){
                Console.WriteLine("\tPlease enter the employees name:");
                strName = Console.ReadLine(); 
                Names.Add(strName);

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
            foreach(string name in Names){
                int index = Names.IndexOf(name);
                GrossPay = Math.Round(HoursWorked[index] * HourlyRate[index], 2);
                /*Gross.Add(GrossPay);
                if (Gross[index] >= 1000){
                    Tax = Math.Round(Gross[index] * 0.50, 2);
                }else if (Gross[index]>= 500 && Gross[index] < 1000){
                    Tax = Math.Round(Gross[index] * 0.30, 2);
                }else if (Gross[index] >= 300 && Gross[index] < 500){
                    Tax = Math.Round(Gross[index]* 0.10, 2);
                 }else if (Gross[index] < 300){
                    Tax = 0;
                 } 
                */
                if (GrossPay >= 1000){
                    Tax = Math.Round(GrossPay * 0.50, 2);
                }else if (GrossPay>= 500 && GrossPay < 1000){
                    Tax = Math.Round(GrossPay * 0.30, 2);
                }else if (GrossPay >= 300 && GrossPay < 500){
                    Tax = Math.Round(GrossPay * 0.10, 2);
                 }else if (GrossPay < 300){
                    Tax = 0;
                 } 
                NetPay = GrossPay - Tax;
                Net.Add(NetPay);

                Console.WriteLine($"\n\tName: " + name + "\n\tHours Worked: " + HoursWorked[index] + "\n\tHourly Rate:$ " + HourlyRate[index] + "\n\tGross Pay:$ " + GrossPay + "\n\tTax:$ " + Tax + "\n\tNet:$ " + Net[index]);
            }
            dblAverage = Math.Round(Net.Sum()/Names.Count, 2);
            Console.WriteLine($"\n\tThe Average Pay for all employees is$ " + dblAverage);
            Console.WriteLine("\tPress any Key to end program");
            Console.ReadKey();

        }


    }
}