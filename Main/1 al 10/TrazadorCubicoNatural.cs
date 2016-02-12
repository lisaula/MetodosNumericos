using System;
using System.Collections.Generic;

namespace MathExpressionsNET
{
    public class TrazadorCubicoNatural
    {
        public void Ejecutar(double[]a, double[]x)
        {
            var n = x.Length;
            var h = new List<double>();
            var alpha = new List<double>();
            var b = new List<double>();
            var c = new List<double>();
            var d = new List<double>();


            //Paso 1
            for(int i = 0; i < n-1; i++)
            {
                h.Add(x[i + 1] - x[i]);
            }

            //Paso 2
            alpha.Add(0);
            for (int j = 1; j < n-1; j++)
            {
                alpha.Add((3 / h[j]) * (a[j + 1] - a[j]) - (3 / h[j]) * (a[j] - a[j - 1]));
            }

            //Paso 3
            var l = new List<double>();
            var miu = new List<double>();
            var z = new List<double>();

            l.Add(1);
            miu.Add(0);
            z.Add(0);
           
            //Paso 4
            for (int i = 1; i < n-1; i++)
            {
                l.Add(2 * (x[i + 1] - x[i - 1]) - h[i - 1] * miu[i - 1]);
                miu.Add(h[i] / l[i]);
                z.Add((alpha[i] - h[i - 1] * z[i - 1]) / l[i]); 
            }

            //Paso 5
            for (int i = 0; i < n; i++)
            {
                l.Add(1);
                c.Add(0);
                b.Add(0);
                d.Add(0);
                z.Add(0);
            }
           

            //Paso 6
            for (int j = n-2; j > -1 ; j--)
            {
                c[j] = (z[j] - (miu[j] * c[j + 1]));
                b[j] = (((a[j+1] - a[j]) / h[j]) - ( (h[j] * (c[j+1] + (2*c[j]) )) / 3 ) );
                d[j] = ((c[j + 1] - c[j]) / (3 * h[j]));
            }

            //Paso 7
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(i + ") " + a[i] + " sigue " + b[i] + " sigue " + c[i] + " sigue " + d[i]);
                Console.WriteLine(" ");
            }

        }
    }
}