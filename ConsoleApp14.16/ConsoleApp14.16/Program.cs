using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._16
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("Original array:");
            processor.PrintArray();

            long product = processor.ProductOfFirstRow();
            Console.WriteLine($"\nProduct of the first row: {product}");
        }
    }
}
