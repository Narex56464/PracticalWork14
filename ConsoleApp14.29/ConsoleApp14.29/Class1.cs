using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._29
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int FindColumnWithMinSum()
        {
            int minSum = int.MaxValue;
            int minColumnIndex = -1;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int columnSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    columnSum += matrix[i, j];
                }

                if (columnSum < minSum)
                {
                    minSum = columnSum;
                    minColumnIndex = j;
                }
            }

            return minColumnIndex;
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
