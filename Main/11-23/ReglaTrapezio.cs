using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpressionsNET;

namespace Main
{
    public class ReglaTrapezio
    {
        double fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }
        public string Reglatrapezio(string function,double limiteA,double limiteB,int iteracion)
        {
            var suma = 0.0;
            var area = 0.0;
            var dx = (limiteB - limiteA)/iteracion;
            var xi = limiteA;
            var i = 1;
            while (i<iteracion)
            {
                xi = xi + dx;
                suma = suma + (2*fn(function,xi));
                Console.WriteLine("#" + (i) + " h= " + dx + " xi= " + xi + "  Suma= " + suma );
                i++;
            }
            area = dx/2*((fn(function,limiteA) + suma + fn(function,limiteB)));
            return "La Respuesta Correcta es :" + area;
        }
    }
}

