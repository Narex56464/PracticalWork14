using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._8
{
    class MatrixProcessor
    {
        private double[,] matrix;
        private int size;

        public MatrixProcessor(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) > 10)
            {
                throw new ArgumentException("Matrix must be square and of size NxN where N <= 10.");
            }

            this.matrix = matrix;
            this.size = matrix.GetLength(0);
        }

        public double ProductOfMinElementsInColumns()
        {
            double product = 1.0;

            for (int j = 0; j < size; j++)
            {
                double minElement = matrix[0, j];

                for (int i = 1; i < size; i++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }

                product *= minElement;
            }

            return product;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
