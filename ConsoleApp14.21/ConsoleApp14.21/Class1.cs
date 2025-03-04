using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._21
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 4 || matrix.GetLength(1) != 6)
            {
                throw new ArgumentException("Matrix must be of size 4x6.");
            }

            this.matrix = matrix;
        }

        public int[] SumOfEachColumn()
        {
            int[] columnSums = new int[matrix.GetLength(1)];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }

                columnSums[j] = sum;
            }

            return columnSums;
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
