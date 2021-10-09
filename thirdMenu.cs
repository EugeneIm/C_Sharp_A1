using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public partial class Program
    {
        public partial class menu
        {
            static void storeChoices()
            {
                Console.WriteLine($"1) Get Total Sales");   
                Console.WriteLine($"2) Enter Total Monthly Sales");   
                Console.WriteLine($"3) Get Holiday Sales");   
                Console.WriteLine($"4) Return To Main");


                string[]csvData = File.ReadAllLines(@"/Users/eugene/Desktop/CSA1Git/C_Sharp_A1/Walmart_Store_Data.csv");

                //Create Lists with CSV Data. 
                var storeID = new List<int>();

                //Individual Monthly Sales of a store has to be 
                    //In essence, if the storeID matches in the list, it sums up all the sales corresponding with that ID
                    //Total Sales is sum of the whole List. 
                    //Holiday sales is, "if value of holiday is > 0, add it to the list being summed up. 

                    

                try
                {
                int user_choice = int.Parse(Console.ReadLine());
                Console.Clear();
                
                for(int i = 0; i < csvData.Length; i++)
                {
                    string[] rowData = csvData[i].Split(',');
                    
                    int sales = Convert.ToInt32(rowData[2]);
                    storeID.Add(sales);
                }

                for(int i = 1; i < storeID.Count; i++)
                {
                    Console.WriteLine(storeID[i]);
                    
                }

                //if (storeID = user_choice)
                //{
                //    Console.WriteLine(storeID.sum);
                    
                //}

                }
                catch (System.Exception e)
                {
                     Console.WriteLine(e.Message);
                     
                }
            }
        }
    }
}
