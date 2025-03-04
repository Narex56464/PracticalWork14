using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._29
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            int minColumnIndex = processor.FindColumnWithMinSum();
            Console.WriteLine($"\nColumn with the smallest sum of elements: {minColumnIndex + 1}");
        }
    }
}
