using System;

namespace Main

{
    public class MetodoSecante
    {
        double Fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }
        public string Calculate(string function, double p0, double p1, double tol, int iterator)
        {
            var q0 = Fn(function, p0);
            var q1 = Fn(function, p1);
            var i = 2;
            for (; i <= iterator; i++)
            {
                var processPartialResult = p1 - (q1 * (p1 - p0) / (q1 - q0));
                if (Math.Abs(processPartialResult - p1) < tol)
                {
                    return "La Respuesta Correcta es: " + processPartialResult;
                }

                p0 = p1;
                q0 = q1;
                p1 = processPartialResult;
                q1 = Fn(function, processPartialResult);

            }
            return "Processo falló en la iteración: " + i;
        }
    }
}