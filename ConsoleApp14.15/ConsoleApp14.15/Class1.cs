using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._15
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != array.GetLength(1))
            {
                throw new ArgumentException("Array must be square.");
            }

            this.array = array;
        }

        public int SumOfLastColumn()
        {
            int sum = 0;
            int lastColumnIndex = array.GetLength(1) - 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, lastColumnIndex];
            }

            return sum;
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
