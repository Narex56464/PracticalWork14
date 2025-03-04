using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._8
{
    internal class Program
    {
        static void Main()
        {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 0.5, 4.6, 1.7 },
            { 2.3, 1.8, 5.6 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("обчная матрица:");
            processor.PrintMatrix();

            double product = processor.ProductOfMinElementsInColumns();
            Console.WriteLine($"\nпроизведение: {product}");
        }
    }
}
