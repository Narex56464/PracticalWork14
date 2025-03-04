using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._24
{
    class ArrayProcessor
    {
    private int[,] array;

    public ArrayProcessor(int[,] array)
    {
        this.array = array;
    }

    public int SumOfSecondRow()
    {
        int sum = 0;
        int secondRowIndex = 1; // Индексация строк начинается с 0

        if (array.GetLength(0) <= secondRowIndex)
        {
            throw new ArgumentException("Array does not have a second row.");
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[secondRowIndex, j];
        }

        return sum;
    }

    public void PrintArray()
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
