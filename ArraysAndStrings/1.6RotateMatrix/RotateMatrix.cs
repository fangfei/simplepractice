using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6RotateMatrix
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {
        }

        private static void Rotate(int[][] matrix, int n)
        {
            for (int layer=0;layer<n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i];
                    matrix[first][i] = matrix[last - offset][first];
                    matrix[last - offset][first] = matrix[last][last - offset];
                    matrix[last][last - offset] = matrix[i][last];
                    matrix[i][last] = top;
                }
            }
        }
    }
}
