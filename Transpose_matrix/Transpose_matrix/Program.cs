using System;

namespace Transpose_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3];

            int number = 1;
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrix[x, y] = number;
                    number++;
                }
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(matrix[x, y]);
                }
                Console.WriteLine();
            }

            Transpose(matrix);
        }

        static void Transpose(int[,] matrix)
        {
            int[,] Newmatrix = new int[getMatrixY(matrix), getMatrixX(matrix)];
            for (int x = 0; x < getMatrixY(matrix); x++)
            {
                for(int y = 0; y <getMatrixX(matrix); y++)
                {
                    Newmatrix[x, y] = matrix[y, x];
                }
            }

            for (int x = 0; x < getMatrixY(matrix); x++)
            {
                for (int y = 0; y < getMatrixX(matrix); y++)
                {
                    Console.Write(Newmatrix[x, y]);
                }
                Console.WriteLine();
            }
        }

        static int getMatrixX(int[,] matrix)
        {
            return matrix.GetLength(0);
        }

        static int getMatrixY(int[,] matrix)
        {
            return matrix.GetLength(1);
        }
    }
}
