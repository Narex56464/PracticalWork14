﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._5
{
    class ArraySorter
    {
        private int[,] array;

        public ArraySorter(int[,] array)
        {
            if (array.GetLength(0) != 5 || array.GetLength(1) != 4)
            {
                throw new ArgumentException("Array must be of size 5x4.");
            }

            this.array = array;
        }

        public int[,] SortByLastColumnDescending()
        {
            var rows = Enumerable.Range(0, array.GetLength(0))
                                .Select(i => Enumerable.Range(0, array.GetLength(1))
                                                        .Select(j => array[i, j]).ToArray())
                                .ToArray();

            var sortedRows = rows.OrderByDescending(row => row.Last()).ToArray();

            int[,] sortedArray = new int[5, 4];
            for (int i = 0; i < sortedRows.Length; i++)
            {
                for (int j = 0; j < sortedRows[i].Length; j++)
                {
                    sortedArray[i, j] = sortedRows[i][j];
                }
            }

            return sortedArray;
        }

        public void PrintArray(int[,] array)
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
