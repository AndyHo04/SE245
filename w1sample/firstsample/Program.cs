using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week1_Samplel {
    class Program {
        static void Main (string[] args) {
            String strFirst, strOperand, strNum1, strNum2;//declare string variables(the first name, the math operation, the first number, and the second number)
            Double  intNum1 = 0, intNum2 = 0, intResult = 0, dblResult;//declare double variable(the result)
           
            Console.WriteLine ("Hello There!");
           
            Console.Write ("Please enter your first name: ");
            
            /*
            The code below is used to read the user's input, asking the user for the first number, the math operation, and the second number and storing them into the variables strFirst, strNum1, strOperand, and strNum2.
            */
           
            strFirst = Console.ReadLine ();
            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");
            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();
            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY,DIVIDE,EXPONENT): ");
            strOperand = Console.ReadLine ().ToUpper();
            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();
            intNum1 = Int32.Parse (strNum1);
            intNum2 = Convert.ToInt32 (strNum2);

            /*
            The code below is used to perform the math operation based on the user's input and store the result in the variable intResult.
            */
          
            switch (strOperand) {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "EXPONENT":
                    intResult = Math.Pow(intNum1, intNum2);
                    break;
            }
           
            dblResult = (Double) intResult;
            
            /*
            The code below is used to display the result of the math operation based on the user's input.

            */
            if (strOperand == "PLUS"){
                Console.WriteLine ($"\n\nThe sum of " + intNum1 +  " and " + intNum2 +  " equals: " + dblResult);
            }else if (strOperand == "MINUS"){
                Console.WriteLine ($"\n\nThe difference of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            else if (strOperand == "MULTIPLY"){
                Console.WriteLine ($"\n\nThe product of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }else if (strOperand == "DIVIDE"){
                Console.WriteLine ($"\n\nThe quotient of" + intNum1 +  " and"  +intNum2+ " equals: " + dblResult);
            }else if (strOperand == "EXPONENT"){
                Console.WriteLine ($"\n\nThe result of " + intNum1 + " raised to the power of " + intNum2 + " equals: " + dblResult);
            }
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}

