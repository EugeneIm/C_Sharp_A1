using System;
using System.IO;
using System.Collections.Generic; 

namespace ConsoleApp5
{
    public partial class Program
    {
        public partial class menu
        {
            public static void firstMenu()
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
            }
            static void Main(string[] args)
            {
                //firstMenu();
                //storeNum();
                //storeChoices();
                getData();
            }
        }
    }
}