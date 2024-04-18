//Andy Ho
//Date: 2024-04-18
//Lab 4
/*Program Prompt - 
Part 1 – Within the code for our project, we want to create a “Person” Structure that contains the
following String values: First Name, Middle Name, Last Name, Street1, Street 2, City, State, Zip,
Phone, Email. Give user output to confirm that data was stored within a class object. (You can use the
“Public” precursor here, but it is not necessary till Part 2.)

Part 2 – Convert the structure to a class, making all the properties/variables public (if not already). Test
to see if this code works fine. Once the program works fine with the class, go into the “Main” method
code and make it so that the First Name has the word “Poopy” concatenated with it. (This is to show
you the weakness of developing public properties/variables within classes.

Part 3 – Using the program from #2, make all the properties of the class “private”. Can you
access/change those values within the class anymore? Why? Generate the Gets/Sets
(Accessors/Mutator methods) that allow us to gather private data from the class as well as allow us to
modify class data if the order entry data is valid.
*/
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace W4Lab{
    class Program{
        //Create the person class
        class ValidationLibrary{
            //check to see if the strings are filled
            public static bool IsFilled(string strValue){
                bool blnResult;
                if (strValue.Length > 0){
                    blnResult = true;
                }
                else{
                    blnResult = false;
                }
                return blnResult;
            }
            //will check for semi-valid email format
           public static bool IsValidEmail(string strEmail){
                bool blnResult = true;
                //check for @ symbol index
                int atLocation = strEmail.IndexOf("@");
                int atNextLocation = strEmail.IndexOf("@", atLocation + 1);
                //check for period index
                int periodLocation = strEmail.LastIndexOf(".");

                //check for min email length
                if (strEmail.Length < 8){
                    blnResult = false;
                   
                }
                else if (atLocation < 2){
                    blnResult = false;
                   
                }   
                else if (periodLocation + 2 > (strEmail.Length)){
                    blnResult = false;
                   
                }
                else if (atNextLocation > -1){
                    blnResult = false;
                    
                }
                return blnResult;
            }
            //check for valid phone number
            public static bool IsValidPhone(string strPhone){
                bool blnResult;
                int index = strPhone.IndexOf("-");
                //check for min phone length
                if ((strPhone.Length < 12) && (index == 3) && (strPhone[3] == '-') && (strPhone[7] == '-')){
                    blnResult = true;
                }
                else{
                    blnResult = false;
                }
                return blnResult;
            }
            //check for valid zip code
            public static bool IsValidZip(string strZip){
                bool blnResult;
                //check for min zip length
                if (strZip.Length < 5 && strZip.Length > 5){
                    blnResult = true;
                }
                else{
                    blnResult = false;
                }
                return blnResult;
            }
        }
        public class  Person{
            private string _firstName;
            private string _middleName;
            private string _lastName;
            private string _street1;
            private string _street2;
            private string _city;
            private string _state;
            private string _zip;
            private string _phone;
            private string _email;

            public string FirstName{
                get{
                    return _firstName;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _firstName = value;
                    }
                    else{
                        _firstName = "INVALID";
                    
                    }
                }
            }
            public string MiddleName{
                get{
                    return _middleName;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _middleName = value;
                    }
                    else{
                        _middleName = "INVALID";
                    }
                }
            }
            public string LastName{
                get{
                    return _lastName;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _lastName = value;
                    }
                    else{
                        _lastName = "INVALID";
                    }
                }
            }
            public string Street1{
                get{
                    return _street1;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _street1 = value;
                    }
                    else{
                        _street1 = "INVALID";
                    }
                }
            }
            public string Street2{
                get{
                    return _street2;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _street2 = value;
                    }
                    else{
                        _street2 = "INVALID";
                    }
                }
            }
            public string City{
                get{
                    return _city;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _city = value;
                    }
                    else{
                        _city = "INVALID";
                    }
                }
            }
            public string State{
                get{
                    return _state;
                }
                set{
                    if (ValidationLibrary.IsFilled(value)){
                        _state = value;
                    }
                    else{
                        _state = "INVALID";
                    }
                }
            }
            public string Zip{
                get{
                    return _zip;
                }
                set{
                    if (ValidationLibrary.IsValidZip(value)){
                        _zip = value;
                    }
                    else{
                        _zip = "INVALID";
                    }
                }
            }
            public string Phone{
                get{
                    return _phone;
                }
                set{
                    if (ValidationLibrary.IsValidPhone(value)){
                        _phone = value;
                    }
                    else{
                        _phone = "INVALID";
                    }
                }
            }
            public string Email{
                get{
                    return _email;
                }
                set{
                    if (ValidationLibrary.IsValidEmail(value)){
                        _email = value;
                    }
                    else{
                        _email = "INVALID";
                    }

                }
            }
          
        }
        static void Main(string[] args){
            Person p = new Person();//Create a new person object

            //Prompt the user to enter the information
            Console.Write("\nPlease enter the first name: ");
            p.FirstName = Console.ReadLine();

            Console.Write("\nPlease enter the middle name: ");
            p.MiddleName = Console.ReadLine();

            Console.Write("\nPlease enter the last name: ");
            p.LastName = Console.ReadLine();

            Console.Write("\nPlease enter the street 1: ");
            p.Street1 = Console.ReadLine();

            Console.Write("\nPlease enter the street 2: ");
            p.Street2 = Console.ReadLine();

            Console.Write("\nPlease enter the city: ");
            p.City = Console.ReadLine();

            Console.Write("\nPlease enter the state: ");
            p.State = Console.ReadLine();

            Console.Write("\nPlease enter the zip: ");
            p.Zip = Console.ReadLine();

            Console.Write("\nPlease enter the phone: ");
            p.Phone = Console.ReadLine();

            Console.Write("\nPlease enter the email: ");
            p.Email = Console.ReadLine();

            
            
            //Output the information
            Console.WriteLine($"\nFirst Name: {p.FirstName}" );
            Console.WriteLine($"Middle Name: {p.MiddleName}" );
            Console.WriteLine($"Last Name: {p.LastName}" );
            Console.WriteLine($"Street 1: {p.Street1}" );
            Console.WriteLine($"Street 2: {p.Street2}" );
            Console.WriteLine($"City: {p.City}" );
            Console.WriteLine($"State: {p.State}" );
            Console.WriteLine($"Zip: {p.Zip}" );
            Console.WriteLine($"Phone: {p.Phone}" );
            Console.WriteLine($"Email: {p.Email}" );
        }
    }
}
