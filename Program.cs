using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb4694 {
    internal class Program {
        static void Main(string[] args) {
            int[,] matrix = ReadMatrix();
            GetMaxSqaureSum(matrix);
        }

        static int[,] ReadMatrix() {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++) {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            return matrix;
        }

        static void GetMaxSqaureSum(int[,] matrix) {
            int sum = 0;
            int max = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++) {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++) {
                    sum = 0;
                    sum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > max) {
                        max = sum;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
