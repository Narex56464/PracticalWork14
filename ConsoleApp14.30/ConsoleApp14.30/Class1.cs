using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._30
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int CountNonNegativeElementsInSecondColumn()
        {
            int count = 0;
            int secondColumnIndex = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, secondColumnIndex] >= 0)
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
