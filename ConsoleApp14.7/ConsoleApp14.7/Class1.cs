using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._7
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 4)
            {
                throw new ArgumentException("Matrix must be of size 3x4.");
            }

            this.matrix = matrix;
        }

        public void SwapMinElementsInFirstAndThirdRows()
        {
            int minFirstRowIndex = FindMinElementIndexInRow(0);
            int minThirdRowIndex = FindMinElementIndexInRow(2);

            int temp = matrix[0, minFirstRowIndex];
            matrix[0, minFirstRowIndex] = matrix[2, minThirdRowIndex];
            matrix[2, minThirdRowIndex] = temp;
        }

        private int FindMinElementIndexInRow(int row)
        {
            int minIndex = 0;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[row, j] < matrix[row, minIndex])
                {
                    minIndex = j;
                }
            }

            return minIndex;
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
