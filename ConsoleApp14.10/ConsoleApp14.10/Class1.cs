using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._10
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 7 || array.GetLength(1) != 8)
            {
                throw new ArgumentException("Array must be of size 7x8.");
            }

            this.array = array;
        }

        public int[] CountOddElementsInColumns()
        {
            int[] oddCounts = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                int count = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }

                oddCounts[j] = count;
            }

            return oddCounts;
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
