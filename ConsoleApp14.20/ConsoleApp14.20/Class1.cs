using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._20
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 6 || matrix.GetLength(1) != 8)
            {
                throw new ArgumentException("Matrix must be of size 6x8.");
            }

            this.matrix = matrix;
        }

        public long ProductOfPositiveElementsInFirstColumn()
        {
            long product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] > 0)
                {
                    product *= matrix[i, 0];
                }
            }

            return product;
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
