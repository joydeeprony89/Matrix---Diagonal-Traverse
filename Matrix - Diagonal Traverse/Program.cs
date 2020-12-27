using System;

namespace Matrix___Diagonal_Traverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            var input = new int[3][];
            for(int i = 0; i < 3; i++)
            {
                input[i] = new int[3];
                for(int j = 0; j < 3; j++)
                {
                    input[i][j] = counter++; 
                }
            }
            
            Console.WriteLine(string.Join(",",FindDiagonalOrder(input)));
        }

        static int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return new int[0];
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int[] result = new int[rows * columns];
            int r = 0, c =  0;
            for (int i = 0; i < rows * columns; i++)
            {
                result[i] = matrix[r][c];
                if ((r + c) % 2 == 0)
                {
                    if (r - 1 >= 0 && c + 1 < columns)
                    {
                        r = r - 1;
                        c = c + 1;
                    }
                    else if (r - 1 < 0 && c + 1 < columns)
                    {
                        c = c + 1;
                    }
                    else
                    {
                        r = r + 1;
                    }
                }
                else
                {
                    if (c - 1 >= 0 && r + 1 < rows)
                    {
                        c = c - 1;
                        r = r + 1;
                    }
                    else if (c - 1 < 0 && r + 1 < rows)
                    {
                        r = r + 1;
                    }
                    else
                    {
                        c = c + 1;
                    }
                }
            }

            return result;
        }
    }
}
