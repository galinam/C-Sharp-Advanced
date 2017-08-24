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

        string[,] matrix = new string[N, M];
        for (int row = 0; row < N; row++)
        {
            string strRow = Console.ReadLine();
            string[] rowElements = strRow.Split(' ');
            for (int column = 0; column < M; column++)
            {
                matrix[row, column] = rowElements[column];
            }
        }
        //string[,] matrix = 
        //{
        //    {"ha", "fifi", "ho", "hi"}, 
        //    {"fo",  "ha",  "hi", "xx"},
        //    {"xxx",  "hi",  "ha", "xx"},
        //    {"hi",  "ho",  "ha", "xx"},
        //};

        // Solution
        int greatCount = 0;
        string targetElement = "";
        int count;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            count = 0;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (String.Equals(matrix[row, col],matrix[row, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[row, col];
                }
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (String.Equals(matrix[row, col],matrix[row + 1, col]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[row, col];
                }
            }
        }


///
        int indexRow;
        int indexCol = 0;
        for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
        {
            indexRow = row;
            count = 0;
            for (int col = matrix.GetLength(1) - 1; (col > 0) && (indexRow < matrix.GetLength(0) - 1); col--, indexRow++)
            {
                if (String.Equals(matrix[indexRow, col], matrix[indexRow + 1, col - 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[indexRow, col];
                }
            }
        }
       
        for (int col = matrix.GetLength(1) - 2; col >= 0; col--)
        {
            indexCol = col;
            count = 0;
            for (int row = 0; (row < matrix.GetLength(0) - 1) && (indexCol >= 1); row++, indexCol--)
            {
                if (String.Equals(matrix[row, indexCol], matrix[row + 1, indexCol - 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[row, indexCol];
                }
            }
        }

        
// /       
        indexCol = 0;
        for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
        {
            indexRow = row;
            count = 0;
            for (int col = 0; (indexRow < matrix.GetLength(0) - 1) && (col < matrix.GetLength(1) -1); col++, indexRow++)
            {
                if (String.Equals(matrix[indexRow, col], matrix[indexRow + 1, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[indexRow, col];
                }
            }
            //indexCol++;
        }

        indexRow = 0;
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            indexCol = col;
            count = 0;
            for (int row = 0; (row < matrix.GetLength(0) - indexRow - 1) && (indexCol < matrix.GetLength(1) - 1); row++, indexCol++)
            {
                if (String.Equals(matrix[row, indexCol], matrix[row + 1, indexCol + 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > greatCount)
                {
                    greatCount = count;
                    targetElement = matrix[row, indexCol];
                }
            }
            //indexRow++;
        }

        // Ptinting
        Console.WriteLine(greatCount + 1);
    }
}