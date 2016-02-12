using System;

namespace Main._1_al_10
{
    public class InterpolacionMedianteTrazadores
    {
        public void Calculate(double[] x, double[]a, double fp0, double fpn)
        {
            var n = a.Length-1;
            var alpha = new double[n+1];
            var h = new double[n+1];
            var l = new double[n+1];
            var u = new double[n+1];
            var z = new double[n+1];
            var c = new double[n+1];
            var b = new double[n+1];
            var d = new double[n+1];

            for (var i = 0; i <= n-1; i++)
            {
              h[i]=(x[i+1]-x[i]);
            }

            alpha[0] = (3*(a[1] - a[0])/h[0]) - 3*fp0;
            alpha[n] = (3*fpn) - 3*(a[n] - a[n - 1])/(h[n - 1]);

            for (var i = 1; i <= n - 1; i++)
            {
                alpha[i] = ((3 / h[i]) * (a[i + 1] - a[i])) - ((3 / h[i - 1]) * (a[i] - a[i - 1]));
            }

            l[0] = 2 * h[0];
            u[0] = 0.5;
            z[0] = alpha[0] / l[0];

            for (int i = 1; i < a.Length - 1; i++)
            {
                l[i] = 2 * (x[i + 1] - x[i - 1]) - h[i - 1] * u[i - 1];
                u[i] = h[i] / l[i];
                z[i] = (alpha[i] - h[i - 1] * z[i - 1]) / l[i];

            }

            l[n] = h[n-1] * (2 - u[n-1]);
            z[n] = (alpha[n] - (h[n - 1] * z[n - 1])) / l[n];
            c[n] = z[n]; 

            for (var j = n-1; j >= 0; j--)
            {
                c[j] = z[j] - u[j] * c[j + 1];
                b[j] = (a[j + 1] - a[j]) / h[j] - h[j] * (c[j + 1] + 2 * c[j]) / 3;
                d[j] = (c[j + 1] - c[j]) / (3 * h[j]);
            }

            for (int j = 0; j <= n; j++)
            {
                Console.WriteLine("a[" + j + "]: " + a[j] + " b[" + j + "]: " + b[j] + " c[" + j + "]: " + c[j] + " d[" + j + "]: " + d[j]);
            }

        }
    }
}
