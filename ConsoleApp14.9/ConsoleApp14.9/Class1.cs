using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._9
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 5 || array.GetLength(1) != 6)
            {
                throw new ArgumentException("Array must be of size 5x6.");
            }

            this.array = array;
        }

        public double[] CalculateColumnAverages()
        {
            double[] averages = new double[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                double sum = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i, j];
                }

                averages[j] = sum / array.GetLength(0);
            }

            return averages;
        }

        public (int Min, int Max)[] FindMinMaxInRows()
        {
            var minMax = new (int Min, int Max)[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = array[i, 0];
                int max = array[i, 0];

                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }

                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

                minMax[i] = (min, max);
            }

            return minMax;
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
