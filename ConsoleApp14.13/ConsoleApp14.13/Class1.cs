using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._13
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            this.array = array;
        }

        public int[] FindMaxInEachColumn()
        {
            int[] maxElements = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                int max = array[0, j];

                for (int i = 1; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

                maxElements[j] = max;
            }

            return maxElements;
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
