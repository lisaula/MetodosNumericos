using System;
using Main;

namespace MathExpressionsNET
{
    class LinealDiferenciasFinitas
    {
        public static void MetodoLinealDiferenciasFinitas(string px, string qx, string rx, double a, double b, double alpha, double beta, int N)
        {
            if (N < 2)
                return;

            var A = new double[N + 1];
            var B = new double[N + 1];
            var C = new double[N + 1];
            var D = new double[N + 1];
            var L = new double[N + 1];
            var U = new double[N + 1];
            var Z = new double[N + 1];
            var W = new double[N + 2];
            var Y = new double[N + 2];
            var X = new double[N + 2];


            //Paso 1
            var h = (b - a) / (N + 1);
            var x = a + h;
            A[0] = (2 + (h * h * EvaluateFn(qx, x)));
            B[0] = (-1 +((h / 2) * EvaluateFn(px, x)));
            D[0] = (-h * h * EvaluateFn(rx, x) + (1 + (h / 2) * EvaluateFn(px, x)) * alpha);

            //Paso 2
            for (var i = 1; i < N - 1; i++)
            {
                x = a + (i * h);
                A[i] = (2 + (h * h * EvaluateFn(qx, x)));
                B[i] = (-1 + (h / 2) * EvaluateFn(px, x));
                C[i] = (-1 - (h / 2) * EvaluateFn(px, x));
                D[i] = (-h * h * EvaluateFn(rx, x));
            }

            //Paso 3
            x = b - h;
            A[N - 1] = (2 + h * h * EvaluateFn(qx, x));
            C[N - 1] = (-1 - (h / 2) * EvaluateFn(px, x));
            D[N - 1] = (-h * h * EvaluateFn(rx, x) + (1 - (h / 2) * EvaluateFn(px, x)) * beta);

            //Paso 4
            L[0] = A[0];
            U[0] = B[0] / A[0];
            Z[0] = D[0] / L[0];

            //Paso 5
            for (var i = 1; i < N - 1; i++)
            {
                L[i] = A[i] - C[i] * U[i - 1];
                U[i] = B[i] / L[i];
                Z[i] = ((D[i] - C[i] * Z[i - 1]) / L[i]);
            }

            //Paso 6
            L[N - 1] = (A[N - 1] - C[N - 1] * U[N - 2]);
            Z[N - 1] = ((D[N - 1] - C[N - 1] * Z[N - 2]) / L[N - 1]);

            //Paso 7
            Y[0] = alpha;
            Y[N + 1] = beta;
            Y[N] = Z[N - 1];

            W[0] = alpha;
            W[N + 1] = beta;

            //Paso 8 
            for (var i = N - 1; i > -1; i--)
            {
                Y[i] = Z[i] - U[i] * Y[i + 1];
                W[i + 1] = Y[i];
            }

            //Paso 9
            for (var i = 0; i <= N + 1; i++)
            {
                X[i] = a + (i * h);
            }

            //Paso 10
            for (var i = 0; i < W.Length; i++)
            {
                Console.WriteLine(X[i] + @" | " + W[i] );
            }


        }

        public static double EvaluateFn(string function, double x)
        {
            var parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }
    }
}