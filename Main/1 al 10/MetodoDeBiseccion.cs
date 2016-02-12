using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class MetodoDeBiseccion
    {

        double fn(string function,double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x",(decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }



        public string MetodoBiseccion(string function,double a, double b, double Tol, int iterador)
        {
           
            if ((fn(function,a) < 0 && fn(function,b) < 0) || (fn(function,b) > 0 && fn(function,a) > 0)||a>b)
                return "El metodo fracaso";
            var FA = fn(function,a);
            var i = 1;
            while(i<=iterador)
            {
                double p = a + ((b-a)/2);
                var FP = fn(function,p);
              //  Console.WriteLine("#"+(i)+"  A= "+a+"  B= "+b+"  P= "+p+"  F(p)= "+FP);
                if (FP == 0 || (b - a)/2 < Tol)
                    return "La Respuesta Correcta es P"+(i)+"= "+p;
                i++;
                if (FA*FP > 0)
                {
                    a = p;
                    FA = FP;
                }
                else
                    b = p;
            }
            return "El metodo fracaso despues de "+iterador+" iteraciones";
        }
    }
}
   