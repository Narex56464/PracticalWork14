using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._12
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = 
            {
            { 1, 7, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 7, 11, 12 }
            };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("Original array:");
            processor.PrintArray();

            int count = processor.CountOccurrencesOfSeven();
            Console.WriteLine($"\nNumber of occurrences of 7: {count}");
        }
    
    }
}
