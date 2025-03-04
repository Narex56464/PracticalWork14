using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._18
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 4 || array.GetLength(1) != 4)
            {
                throw new ArgumentException("Array must be of size 4x4.");
            }

            this.array = array;
        }

        public int FindRowWithMinSum()
        {
            int minSum = int.MaxValue;
            int minRowIndex = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowSum += array[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRowIndex = i;
                }
            }

            return minRowIndex;
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
