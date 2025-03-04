using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._7
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 5, 3, 2, 4 },
            { 1, 7, 6, 8 },
            { 9, 0, 11, 10 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("обычная матрица:");
            processor.PrintMatrix();

            processor.SwapMinElementsInFirstAndThirdRows();
            Console.WriteLine("\nматрица после смен мест числами:");
            processor.PrintMatrix();
        }
    }
}
