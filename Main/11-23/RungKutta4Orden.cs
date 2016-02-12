using System;
using info.lundin.math;

namespace Main
{
    public class RungKutta4Orden
    {


        public string metodo4orden(string function, double X0, double XF, double Y0, int N)
        {
            var h = (XF - X0)/N;
            int i = 1;
            var k1 = 0.0;
            var k2 = 0.0;
            var k3 = 0.0;
            var k4 = 0.0;
            Console.WriteLine("#" + 0 + "  X= " + X0 + "  Y= " + Y0);
            while (i <= N)
            {
                var exp = new ExpressionParser();
                exp.Values.Add("x", X0);
                exp.Values.Add("y", Y0);
                k1= exp.Parse(function);
                var exp2 = new ExpressionParser();
                exp2.Values.Add("x", X0+(h/2));
                exp2.Values.Add("y", Y0+(h*(k1/2)));
                k2 = exp2.Parse(function);
                var exp3 = new ExpressionParser();
                exp3.Values.Add("x", X0 + (h / 2));
                exp3.Values.Add("y", Y0 + (h * (k2 / 2)));
                k3 = exp3.Parse(function);
                var exp4 = new ExpressionParser();
                exp4.Values.Add("x", X0 + (h));
                exp4.Values.Add("y", Y0 + (h*(k3)));
                k4 = exp4.Parse(function);
                Y0 = Y0 + ((h/6)*(k1 + (2*k2) + (2*k3) + k4));
                X0 = X0 + h;
                Console.WriteLine("#" + (i) +"  X= " + X0 +"  Y= " + Y0);
                i++;

            }
            return "La Respuesta Correcta es :" + Y0;
        }
    }
}