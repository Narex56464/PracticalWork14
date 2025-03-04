using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._25
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 4 || matrix.GetLength(1) != 4)
            {
                throw new ArgumentException("Matrix must be of size 4x4.");
            }

            this.matrix = matrix;
        }

        public int CountNegativeElementsInSecondColumn()
        {
            int count = 0;
            int secondColumnIndex = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, secondColumnIndex] < 0)
                {
                    count++;
                }
            }

            return count;
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

