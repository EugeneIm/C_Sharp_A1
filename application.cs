using System;
using System.IO;
using System.Collections.Generic; 

namespace ConsoleApp5
{
    public partial class Program
    {
        public partial class menu
        {
            public static void userInput()
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("**** WALMART SALES MANAGEMENT *****");
                Console.WriteLine("***********************************");

                Console.WriteLine("1. Individual Store Statistics");
                Console.WriteLine("2. All Stores Combined Statistics");
                Console.WriteLine("3. Quit.");
                Console.Write("Please Enter a Selection: ");
            
                try
                {
                int option = int.Parse(Console.ReadLine());
                
                Console.Clear();

                switch (option)
                {
                    case 1: Console.WriteLine("");

                        break;
                    case 2: Console.WriteLine("");
                        break;
                    case 3: Console.Clear();
                        break;
                }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wrong data type, please enter the correct type, num.");
                }

            static void individualMenu()
            {
            //Console.WriteLine("Enter Store Number Please: ");
            Console.Write("Please enter a store Number: ");
            Console.ReadLine();
                    
                //Console.WriteLine("Wrong format, please enter a number");
                        
            Console.WriteLine("1. Individual Store Sales");
            Console.WriteLine("2. Total Store Sales");
            Console.WriteLine("3. Holiday Sales");
                        
            Console.Clear();
            
            
            try
            {
                
                Console.WriteLine("Store Number " + Convert.ToInt32(Console.ReadLine()));
            }
            catch(FormatException)
            {
                Console.WriteLine("This was not a number, please enter a store NUMBER");
                            
            }          
            }


            }

            static void storeChoices()
            {
                Console.WriteLine($"1) Get Total Sales");   
                Console.WriteLine($"2) Enter Total Monthly Sales");   
                Console.WriteLine($"3) Get Holiday Sales");   
                Console.WriteLine($"4) Return To Main");


            }

            static void Main(string[] args)
            {
                
            }
        }
    }
}