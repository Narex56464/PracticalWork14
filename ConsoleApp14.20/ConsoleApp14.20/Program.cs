﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._20
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4, 5, 6, 7, 8 },
            { -1, 2, -3, 4, -5, 6, -7, 8 },
            { 9, 10, 11, 12, 13, 14, 15, 16 },
            { -9, 10, -11, 12, -13, 14, -15, 16 },
            { 17, 18, 19, 20, 21, 22, 23, 24 },
            { -17, 18, -19, 20, -21, 22, -23, 24 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("Original matrix:");
            processor.PrintMatrix();

            long product = processor.ProductOfPositiveElementsInFirstColumn();
            Console.WriteLine($"\nProduct of positive elements in the first column: {product}");
        }
    }
}
