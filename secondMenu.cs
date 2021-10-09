using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public partial class Program
    {
        public partial class menu
        {
            static void storeNum()
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
                
                Console.WriteLine("Store Number " + Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("This was not a number, please enter a store NUMBER");
                            
            }          
            }
        }
    }
}

//Console.WriteLine($"1) Get Total Sales");   
  //          Console.WriteLine($"2) Enter Total Monthly Sales");   
    //        Console.WriteLine($"3) Get Holiday Sales");   
      //      Console.WriteLine($"4) Return To Main");