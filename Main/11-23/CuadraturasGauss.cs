using System;

namespace Main
{
    public class CuadraturasGauss
    {
        double fn(string function, double x)
        {
            MathParser parser = new MathParser();
            parser.LocalVariables.Add("x", (decimal)x);
            var result = parser.Parse(function);
            return (double)result;
        }

        public string cudraturasgauss(string function,double A, double B,int N)
        {
            var NP = new int[] {0, 2, 3, 4, 5, 6};
            var IAUX = new int[]{0, 1, 2, 4, 6, 9, 12};
            var Z = new double[] { 0.0, 0.577350269, 0.0, 0.774596669, 0.339981044, 0.861136312, 0.0, 0.538469310, 0.906179846, 0.238619186, 0.661209387, 0.932469514 };
            var W = new double[]
            {
                0.0, 1.0, 0.888888888, 0.555555555, 0.652145155, 0.347854845, 0.568888888, 0.478628671, 0.236926885, 0.467913935, 0.360761573, 0.171324493
            };
            var I = 1;
            while (I <= 5)
            {
                if (N == NP[I])
                {
                    goto PASO10;
                }
                I = I + 1;
            }
            return "N NO ES 2, 3, 4, 5, 6";
            PASO10:
            var S = 0.0;
            var J = IAUX[I];
            while (J <= IAUX[I + 1] - 1)
            {
                var ZAUX = (Z[J]*(B - A) + B + A)/2;
                S = S + fn(function, ZAUX)*W[J]; 
                ZAUX = (-Z[J]*(B - A) + A + B)/2;
                S = S + fn(function, ZAUX) * W[J]; 
                J = J + 1;
            }
            var AREA = ((B - A)/2)*S;

            return "La Respuesta Correcta es :" + AREA;
        }
        
    }
}