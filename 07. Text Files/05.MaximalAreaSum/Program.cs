using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static int[,] matrix;
    static int matrixSize;

    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"..\..\matrix.txt");
        writer.Write(@"4 
2 3 3 4 
0 2 3 4 
3 7 1 2 
4 3 3 2	");
        writer.Close();

        using (var reader = new StreamReader(@"..\..\matrix.txt"))
        {
            matrixSize = int.Parse(reader.ReadLine());
            matrix = new int[matrixSize, matrixSize];
            string row;

            for (int r = 0; (r < matrixSize) && ((row = reader.ReadLine()) != null); r++)
            {
                string[] rowNum = row.Split(' ');
                for (int c = 0; c < matrixSize; c++)
                {
                    matrix[r, c] = int.Parse(rowNum[c]);
                }
            }
        }
        using (var writerResult = new StreamWriter(@"..\..\result.txt"))
        {
            writerResult.Write(FindMaximalAreaSum(matrix));
        }
    }

    private static int FindMaximalAreaSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;

        for (int col = 0; col < matrixSize - 1; col++)
        {
            int sum = 0;
            for (int row = 0; row < matrixSize - 1; row++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }
        return maxSum;
    }

    private static void PrintMatrix(int[,] board)
    {
        for (int r = 0; r < 4; r++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("{0,4}", board[r, c]);
            }
            Console.WriteLine();
        }
    }
}