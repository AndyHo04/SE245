using System;
using System.Collections.Generic; using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*	..
        **************************************************************************************..
        ***********************************
        This program does not work, Needs to be in a for loop to work properly

        **************************************************************************************..
        ***********************************
        */

        //Declare vars
        String strFirst, strNum, strCntr;
        Double dblNum = 0, dblTotal = 0, dblResult = 0; Int32 intCntr = 0;
        bool blnResult = false;
        /*
        ************************************************************************..
        *************************************************************
        
        ************************************************************************..
        *************************************************************
        */
        
        List<double> dblEarnings = new List<double>();
        
        Console.WriteLine("Averager Program: Enter weekly earnings. (a -1 to end entries)\n\n");
        


        
        
        /*
        ************************************************************************..
        ********************************************************************
        
        ************************************************************************,>
        ********************************************************************
        */
        do
        {
            /*
            
            ********************************************************************?
            *************************************************************
            */
            
            do
            {
                Console.Write("Please enter payroll#"+ (intCntr + 1) +" "); 
                strNum = Console.ReadLine();
                blnResult = Double.TryParse(strNum, out dblNum);

                if (blnResult == false)
                {
                    Console.WriteLine("\n\nSorry, but you did not enter a valid	real number in digits: Ex 1051.00.");
                }
            } while (blnResult == false);
            
            if (dblNum >= 0)
            {
                dblEarnings.Add(dblNum); 
                dblTotal += dblNum; 
                intCntr++;
            }

        } while (dblNum >= 0);/*Can't break out of loop"*/
        
        dblResult = (dblTotal / intCntr); 
        //*********************************************************************
        intCntr = 1;
        foreach (double d in dblEarnings)
        {
            Console.WriteLine($"Weekly entry #{intCntr}: ${d}"); intCntr++;
        }
        //*********************************************************************
        Console.WriteLine("The average of the weekly earnings entered is: $" + dblResult);
       
        // CREATE A DELAY FOR THE USER TO SEE THE OUTPUT BEFORE THE PROGRAM ENDS
       
        Console.WriteLine("\n\nPress Any Key to Continue"); 
        Console.ReadKey();
       
       

        }
    }
}
