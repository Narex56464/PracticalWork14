using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._23
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            double average = processor.CalculateAverage();
            Console.WriteLine($"\nAverage value of matrix elements: {average:F2}");

            int count = processor.CountElementsAboveAverage(average);
            Console.WriteLine($"Number of elements above the average: {count}");
        }
    }
}
