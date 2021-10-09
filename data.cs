using System;
using System.IO;
using System.Collections.Generic; 

namespace ConsoleApp5
{
    public partial class Program
    {
        public class StoreData
        {
            public void ReadData()
            {
                int storeID
                int chosenDate
                double weeklySales
                int isHoliday

                public StoreData()
                {
                    storeID = lineContent[0]
                    chosenDate = lineContent[1]
                    weeklySales = lineContent[2]
                    isHoliday = lineContent[3]
                }

                const string FILE = @"C:\Users\immer\Desktop\gitAssignment1\C_Sharp_A1\Walmart_Store_Data.csv";
                StreamReader sr = new StreamReader(FILE);
                while (!sr.EndOfStream) {
                string lineContent = sr.ReadLine();
                Console.WriteLine(lineContent);
                }
                sr.Close(); // It is better to close the reader when finished.
                Console.ReadLine();
                
            }
            
        }
    }
}