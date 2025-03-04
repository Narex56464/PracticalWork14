using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._17
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 10 || array.GetLength(1) != 10)
            {
                throw new ArgumentException("Array must be of size 10x10.");
            }

            this.array = array;
        }

        public int[] SumOfEachRow()
        {
            int[] rowSums = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }

                rowSums[i] = sum;
            }

            return rowSums;
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
