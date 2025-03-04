using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._22
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 10)
            {
                throw new ArgumentException("Matrix must be of size 5x10.");
            }

            this.matrix = matrix;
        }

        public int FindMinRowSum()
        {
            int minSum = int.MaxValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                }
            }

            return minSum;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
