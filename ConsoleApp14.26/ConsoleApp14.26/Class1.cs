using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._26
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 7)
            {
                throw new ArgumentException("Matrix must be of size 3x7.");
            }

            this.matrix = matrix;
        }

        public int[] CountElementsInEachColumn()
        {
            int[] columnCounts = new int[matrix.GetLength(1)];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                columnCounts[j] = matrix.GetLength(0);
            }

            return columnCounts;
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
