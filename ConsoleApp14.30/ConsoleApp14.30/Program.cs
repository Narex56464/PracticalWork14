,
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._30
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, -2, 3 },
            { 4, 5, -6 },
            { -7, 8, 9 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            int nonNegativeCount = processor.CountNonNegativeElementsInSecondColumn();
            Console.WriteLine($"\nNumber of non-negative elements in the second column: {nonNegativeCount}");
        }
    }
}
