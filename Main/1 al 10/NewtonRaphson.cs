using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpressionsNET;

namespace Main
{
    public class NewtonRaphson
    {
        double fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }


        public string newtonRaphson(string function, string function2,double aprox, double TOL, double iterador)
        {
          
            int i = 1;
            while (i <= iterador)
            {
                double p = aprox - (fn(function, aprox)/fn(function2,aprox));
                //Console.WriteLine("#" + (i) + "  Po= " + aprox + "  P= " + p);
                if (Math.Abs(p - aprox) < TOL)
                    return "La Respuesta Correcta es P" + (i) + "= " + p;
                i++;
                aprox = p;
            }
            return "El metodo fracaso despues de " + iterador + " iteraciones";
        }
    }
}
