// Name: Andy Ho
// W1 Lab
// Date: 3/28/24
// Description: Calculate payroll with Name, hour, hourly rate, along with taxes deducted based on tax bracket.

//calling the library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

//namespace
namespace w1_lab{
    class program{
        static void Main (string[] args){
            String strName, strHours, strRate;//declare string variables
            Double dblHours, dblRate, dblGross, dblNet, dblTax = 0;//declare double variables

            Console.WriteLine ("Welcome to the Gross Pay Calculator");//print out the message

            /*
            The code below is used to read the user's input, asking the user for their name, the hours worked, and the hourly rateand storing them into the variables strName, strHours, and strRate.
             */
            Console.Write ("Please enter your name: ");
            strName = Console.ReadLine ();

            Console.Write ("Please enter the hours worked: ");
            strHours = Console.ReadLine ();

            Console.Write ("Please enter the hourly rate: ");
            strRate = Console.ReadLine ();

            /*
            convert the numbers to floats(Double)
            */
            dblHours = Convert.ToDouble (strHours);
            dblRate = Convert.ToDouble (strRate);
            

            /*
            The code below is used to calculate the gross pay, and the net pay based on the user's input and store the result in the variable dblGross, and dblNet.
            */
            dblGross = dblHours * dblRate;
            
            if (dblGross >= 1000){
                dblTax = dblGross * 0.50;
            }else if (dblGross >= 500 && dblGross < 1000){
                dblTax = dblGross * 0.30;
            }else if (dblGross >= 300 && dblGross < 500){
                dblTax = dblGross * 0.10;
            }else if (dblGross < 300){
                dblTax = 0;
            }
            dblNet = dblGross - dblTax;
    
            /*
            The code below is used to display the result of the gross pay, and the net pay based on the user's input.
            */
            Console.WriteLine ($"\n\nHello " + strName + "! Your gross pay is: " + dblGross + " and your net pay is: " + dblNet + " after taxes.");
            Console.WriteLine ($"\n\nPress any key to continue... ");
            Console.ReadKey ();
        }
    }
}
