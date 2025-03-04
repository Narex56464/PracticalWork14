using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._21
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4, 5, 6 },
            { 7, 8, 9, 10, 11, 12 },
            { 13, 14, 15, 16, 17, 18 },
            { 19, 20, 21, 22, 23, 24 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            int[] columnSums = processor.SumOfEachColumn();
            Console.WriteLine("\nSum of each column:");
            for (int j = 0; j < columnSums.Length; j++)
            {
                Console.WriteLine($"Column {j + 1}: {columnSums[j]}");
            }
        }
    }
}

