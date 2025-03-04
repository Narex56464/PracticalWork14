using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._19
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 7 || array.GetLength(1) != 7)
            {
                throw new ArgumentException("Array must be of size 7x7.");
            }

            this.array = array;
        }

        public int FindRowWithMaxSum()
        {
            int maxSum = int.MinValue;
            int maxRowIndex = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowSum += array[i, j];
                }

                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxRowIndex = i;
                }
            }

            return maxRowIndex;
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
