using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._11
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("Original array:");
            processor.PrintArray();

            var counts = processor.CountEvenAndOddElements();
            Console.WriteLine($"\nNumber of even elements: {counts.EvenCount}");
            Console.WriteLine($"Number of odd elements: {counts.OddCount}");
        }
    }
}
