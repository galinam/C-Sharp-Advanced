using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char choose = char.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int number = 1;

        switch (choose)
        {
            case 'a':
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = number;
                            number++;
                        }
                    }
                }
                break;
            case 'b':
                {
                    for (int col = 0; col < matrix.GetLength(1); col += 2)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = number;
                            number++;
                        }
                        number += size;
                    }
                    number = size + 1;
                    for (int col = 1; col < matrix.GetLength(1); col += 2)
                    {
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            matrix[row, col] = number;
                            number++;
                        }
                        number += size;
                    }
                }
                break;
            case 'c':
                {
                    int row, col;
                    int indexCol = 0;
                    int indexRow;
                    for (row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        indexRow = row;
                        for (col = 0; (col <= indexCol) && (col < size); col++, indexRow++)
                        {
                            matrix[indexRow, col] = number;
                            number++;
                        }
                        indexCol++;
                    }

                    indexRow = 0;
                    for (col = 1; col < matrix.GetLength(1); col++)
                    {
                        indexCol = col;
                        for (row = 0; row < size - indexRow - 1; row++, indexCol++)
                        {
                            matrix[row, indexCol] = number;
                            number++;
                        }
                        indexRow++;
                    }
                }
                break;
            case 'd':
                {
                    for (int depth = 0; depth < size / 2 + size % 2; depth++)
                    {
                        for (int row = depth; row < size - depth; row++)
                        {
                            matrix[row, depth] = number;
                            number++;
                        }

                        for (int col = 1 + depth; col < size - depth; col++)
                        {
                            matrix[size - 1 - depth, col] = number;
                            number++;
                        }

                        for (int row = size - 2 - depth; row >= depth; row--)
                        {
                            matrix[row, size - 1 - depth] = number;
                            number++;
                        }

                        for (int col = size - 2 - depth; col > depth; col--)
                        {
                            matrix[depth, col] = number;
                            number++;
                        }
                    }
                }
                break;
            default:
                break;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col == size - 1)
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                else Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}