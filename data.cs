using System;
using System.IO;
using System.Collections.Generic; 

namespace ConsoleApp5
{
    public partial class Program
    {
        public partial class menu
        {
            static void getData()
            {

                string rowCSV = File.ReadAllText(@"/Users/eugene/Desktop/CA1/Walmart_Store_Data.csv");
                Console.WriteLine(rowCSV[0]);
                Console.ReadLine();
                Console.WriteLine("Here is some dummy text to replace the data menu");
                Console.WriteLine($"If the entered ID matches the ID take all the values and sum them all up");
                
            }
            
        }
    }
}