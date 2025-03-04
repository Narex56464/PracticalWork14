using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._22
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
            { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            int minRowSum = processor.FindMinRowSum();
            Console.WriteLine($"\nMinimum sum of elements in any row: {minRowSum}");
        }
    }
}
