using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._13
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

            int[] maxElements = processor.FindMaxInEachColumn();
            Console.WriteLine("\nMaximum elements in each column:");
            for (int j = 0; j < maxElements.Length; j++)
            {
                Console.WriteLine($"Column {j + 1}: {maxElements[j]}");
            }
        }
    }
}
