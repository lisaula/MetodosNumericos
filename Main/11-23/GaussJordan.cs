using System;
using System.Runtime.InteropServices;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Main
{
    public class GaussJordan
    {

        public void  Calculate(double[,] matrix, int dimension)
        {

            for (var i = 0; i < dimension; i++)
            {
                var temp = matrix[i, i];

                for (var j = 0; j < dimension + 1; j++)
                {
                    matrix[i, j] = matrix[i, j]/temp;
                }

                for (var k = 0; k < dimension; k++)
                {
                    temp = matrix[k, i];
                    if (i != k)
                    {
                        for (var j = 0; j <= dimension; j++)
                        {
                            matrix[k, j] = matrix[k, j] - (temp*matrix[i, j]);
                        }
                    }
                }

            }
            PrintMatrix(matrix,dimension);

        }

        private void PrintMatrix(double[,] matrix, int dimension)
        {
            Console.WriteLine();
            Console.WriteLine("Matrix");
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j <= dimension; j++)
                {
                    Console.Write(@"{0:F2}	", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
   