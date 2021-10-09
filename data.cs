using System;
using System.IO;

namespace ConsoleApp5
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            const string FILE = @"C:\Users\immer\Desktop\gitAssignment1\C_Sharp_A1\Walmart_Store_Data.csv";
            StreamReader sr = new StreamReader(FILE);
            while (!sr.EndOfStream) 
            {
                string lineContent = sr.ReadLine();
                Console.WriteLine(lineContent);
            }
            sr.Close(); // It is better to close the reader when finished.
            Console.ReadLine();
        }
    }
}
