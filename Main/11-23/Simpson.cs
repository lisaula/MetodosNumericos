using System;
using System.Linq;
using MathExpressionsNET;

namespace Main
{
    public class Simpson
    {
        double fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }

        public string simpsonEvaluar(string function,double a ,double b,int N)
        {
            var h = (b - a)/N;
            var x0 = fn(function, a) + fn(function, b);
            var x1 = 0.0;
            var x2 = 0.0;
            var x = 0.0;
            for (int i = 1; i <= N-1; i++)
            {
                x = a + (i*h);
                if ((i%2) == 0)
                    x2 = x2 + fn(function, x);
                else
                    x1 = x1 + fn(function, x);

                Console.WriteLine("#" + (i) + " h= " + h + "  x0= " + x0 + "  x1= " + x1 + "  x2= " + x2);
                
            }

            var result = h*(x0 + (2*x2) + (4*x1))/3;
            return "La Respuesta Correcta es :" + result;
        }

       
    }
}