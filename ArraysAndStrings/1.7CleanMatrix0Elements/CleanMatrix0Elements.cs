using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7CleanMatrix0Elements
{
    class CleanMatrix0Elements
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 3] { { 1, 2, 3 }, { 4, 0, 6 }, { 7, 8, 9 }, { 10, 11, 0 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i,j]);
                    System.Console.Write("\t");
                }
                System.Console.WriteLine();
                System.Console.WriteLine("---------------------");
            }

            System.Console.WriteLine("=====================");
            CleanMatrixFor0( matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i, j]);
                    System.Console.Write("\t");
                }
                System.Console.WriteLine();
                System.Console.WriteLine("---------------------");
            }
        }

        private static void CleanMatrixFor0(int[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (row[i] || column[j])
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
        }
    }
}
