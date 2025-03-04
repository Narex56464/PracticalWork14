using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._14
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 2, 4 },
            { 1, 7, 6, 8 },
            { 9, 0, 11, 10 }
        };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("Original array:");
            processor.PrintArray();

            var indices = processor.FindFirstMinElementIndices();
            Console.WriteLine($"\nIndices of the first smallest element: Row = {indices.Row}, Column = {indices.Column}");
        }
    }
}
