using System;
using System.Runtime.InteropServices;
using MathExpressionsNET;

namespace Main
{
     
    public class Muller
    {
        double fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }

        public string Mullermethod(string function,double x0,double x1,double x2,double Tol, double iteracion)
        {
          

            var h1 = x1 - x0;
            var h2 = x2 - x1;
            var b1 = (fn(function, x1) - fn(function, x0))/h1;
            var b2 = (fn(function, x2) - fn(function, x1))/h2;
            var d = (b2 - b1)/(h2 + h1);
            double E;
            double H;
            int i = 3;
            while (i <= iteracion)
            {
                 var B = b2 + (h2*d);
                 var D = Math.Pow(((B*B) - (4*fn(function, x2)*d)), 0.5);
                if (Math.Abs(B - D) < Math.Abs(B + D))
                {
                     E = B + D;
                }
                else
                {
                     E = B - D;
                }
                H = (-2*fn(function, x2))/E;
                var p = x2 + H;
                //Console.WriteLine("#" + (i) + "  x0= " + x0 + "  x1= " + x1 + "  x2= " + x2 + "  P"+(i)+"= " + p);
                if(Math.Abs(H)<Tol)
                      return "La Respuesta Correcta es P" + (i) + "= " + p;

                x0 = x1;
                x1 = x2;
                x2 = p;
                h1 = x1 - x0;
                h2 = x2 - x1;
                b1 = (fn(function, x1) - fn(function, x0))/h1;
                b2 = (fn(function, x2) - fn(function, x1))/h2;
                d = (b2 - b1)/(h2 + h1);
                i++;

            }
          return "El metodo fracaso despues de " + iteracion + " iteraciones";
        }
     }
  }