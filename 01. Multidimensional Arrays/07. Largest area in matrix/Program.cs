/*
 * https://www.youtube.com/watch?v=QRq6p9s8NVg - Breadth First Search Algorithm
 * https://www.youtube.com/watch?v=iaBEKo5sM7w - Depth First Search Algorithm
 */
using System;
using System.Collections.Generic;


class LargestAreaInMatrix
{
    static int result = 0;
    static int[,] matrix;

    static void Main()
    {
        matrix = GenerateMatrix();
        LargestArea();
        Console.WriteLine(result);
    }

    static void LargestArea()
    {

        Queue<int> rowIndex = new Queue<int>();
        Queue<int> colIndex = new Queue<int>();
        int counter = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != int.MinValue)
                {
                    rowIndex.Enqueue(i);
                    colIndex.Enqueue(j);
                    GoRecursive(rowIndex, colIndex, counter, matrix[i, j]);
                }
            }
        }


    }

    static void GoRecursive(Queue<int> rowIndex, Queue<int> colIndex,
        int counter, int root)
    {

        int currentCount = rowIndex.Count;
        for (int i = 0; i < currentCount; i++)
        {

            //[-1,0]
            if (rowIndex.Peek() - 1 >= 0 &&
                matrix[rowIndex.Peek() - 1, colIndex.Peek()] == root)
            {
                counter++;
                rowIndex.Enqueue(rowIndex.Peek() - 1);
                colIndex.Enqueue(colIndex.Peek());
                matrix[rowIndex.Peek() - 1, colIndex.Peek()] = int.MinValue;
            }


            //[0,+1]
            if (colIndex.Peek() + 1 < matrix.GetLength(1) &&
                matrix[rowIndex.Peek(), colIndex.Peek() + 1] == root)
            {
                counter++;
                rowIndex.Enqueue(rowIndex.Peek());
                colIndex.Enqueue(colIndex.Peek() + 1);
                matrix[rowIndex.Peek(), colIndex.Peek() + 1] = int.MinValue;
            }

            //[+1,0]
            if (rowIndex.Peek() + 1 < matrix.GetLength(0) &&
                matrix[rowIndex.Peek() + 1, colIndex.Peek()] == root)
            {
                counter++;
                rowIndex.Enqueue(rowIndex.Peek() + 1);
                colIndex.Enqueue(colIndex.Peek());
                matrix[rowIndex.Peek() + 1, colIndex.Peek()] = int.MinValue;
            }

            //[0,-1]
            if (colIndex.Peek() - 1 >= 0 &&
                matrix[rowIndex.Peek(), colIndex.Peek() - 1] == root)
            {
                counter++;
                rowIndex.Enqueue(rowIndex.Peek());
                colIndex.Enqueue(colIndex.Peek() - 1);
                matrix[rowIndex.Peek(), colIndex.Peek() - 1] = int.MinValue;
            }
            rowIndex.Dequeue();
            colIndex.Dequeue();

        }

        if (rowIndex.Count != 0)
        {
            GoRecursive(rowIndex, colIndex, counter, root);

        }
        else
        {
            if (counter > result)
            {
                result = counter;
            }
            counter = 0;
        }


    }

    static int[,] GenerateMatrix()
    {
        string[] matrixSize = Console.ReadLine().Split(' ');
        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);
        int[,] matrix = new int[rows, cols];
        string[] input = new string[cols];
        for (int i = 0; i < rows; i++)
        {
            input = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        return matrix;
    }
}