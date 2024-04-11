using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {
        static void Main (string[] args) {

            //Declare vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false; 
            bool success = false;

            do{
                Console.WriteLine ("Averager Program: How many weeks do you want to enter:?");
                strCntr = Console.ReadLine ();
                success = Int32.TryParse(strCntr, out intCntr);
                if(!success){
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 4.");
                }
            }while(!success);
            
           
            Double[] dblEarnings = new Double[intCntr];// making a array of the earnings

            Console.WriteLine ("Averager Program: Enter weekly earnings.\n\n");

            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            for (int intCounter = 0; intCounter < intCntr; intCounter++) {
                //*********************************************************************************************************************************
                do {
                    Console.Write ("Please enter payroll #" + (intCounter + 1) + ": ");
                    strNum = Console.ReadLine ();

                    blnResult = Double.TryParse (strNum, out dblNum);


                    if (blnResult == false ) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    }
                } while (blnResult == false);
                //*********************************************************************************************************************************
                //dblTotal += dblnum;
                dblEarnings[intCounter] = dblNum;

            }
            foreach (double earning in dblEarnings){
                dblTotal += earning;

            }
            //********************************************************************************************************************************************

            //*************************************************************************************************************************************
            //*************************************************************************************************************************************

            dblResult = dblTotal / intCntr;
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult);

            //*************************************************************************************************************************************
            //*************************************************************************************************************************************
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();

        }
    }
}