using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._9
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 1, 2, 3, 4, 5, 6 },
            { 7, 8, 9, 10, 11, 12 },
            { 13, 14, 15, 16, 17, 18 },
            { 19, 20, 21, 22, 23, 24 },
            { 25, 26, 27, 28, 29, 30 }
        };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("оычная матрицы:");
            processor.PrintArray();

            double[] columnAverages = processor.CalculateColumnAverages();
            Console.WriteLine("\nColumn averages:");
            for (int j = 0; j < columnAverages.Length; j++)
            {
                Console.WriteLine($"Column {j + 1}: {columnAverages[j]:F2}");
            }

            var minMaxInRows = processor.FindMinMaxInRows();
            Console.WriteLine("\nMin and max in each row:");
            for (int i = 0; i < minMaxInRows.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}: Min = {minMaxInRows[i].Min}, Max = {minMaxInRows[i].Max}");
            }
        }
    }
}
