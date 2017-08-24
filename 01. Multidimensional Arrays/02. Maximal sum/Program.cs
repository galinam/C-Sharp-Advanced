using System;

class Program
{
    static void Main()
    {
        // Input 
        string strMatrixSize = Console.ReadLine();
        string[] matrixSize = strMatrixSize.Split(' ');
        int N = int.Parse(matrixSize[0]);
        int M = int.Parse(matrixSize[1]);

        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            string strRow = Console.ReadLine();
            string[] rowElements = strRow.Split(' ');
            for (int column = 0; column < M; column++)
            {
                matrix[row, column] = int.Parse(rowElements[column]);
            }
        }

        // Solution
        int maxSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;

        for (int col = 0; col < M - 2; col++)
        {
            int sum = 0;
            for (int row = 0; row < N - 2; row++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }

        // Printing
        Console.WriteLine(maxSum);
        //for (int rows = startRow; rows <= startRow + 2; rows++)
        //{
        //    for (int cols = startCol; cols <= startCol + 2; cols++)
        //    {
        //        if (matrix[rows, cols] < 10)
        //        {
        //            Console.Write("  ");
        //        }
        //        if (matrix[rows, cols] >= 10 && matrix[rows, cols] < 100)
        //        {
        //            Console.Write(" ");
        //        }
        //        Console.Write("{0} ", matrix[rows, cols]);
        //    }
        //    Console.WriteLine();
        //}
    }
}