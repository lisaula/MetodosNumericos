namespace MathExpressionsNET
{
    class RegresionLineal
    {
        public static double regresionLineal(double[] valoresX, double[] valoresY, double xo)
        {
            var m = valoresX.Length;
            var constante1 = 0.0;
            var constante2 = 0.0;
            var constante3 = 0.0;
            var constante4 = 0.0;
            var i = 0;

            while (i < m)
            {
                constante1 = constante1 + valoresY[i];
                constante2 = constante2 + (valoresX[i]*valoresX[i]);
                constante3 = constante3 + valoresX[i];
                constante4 = constante4 + (valoresX[i]*valoresY[i]);

                i = i + 1;
            }
            var coeficiente1 = ((constante1*constante2) - (constante3*constante4))/
                               ((m*constante2) - (constante3*constante3));

            var coeficiente2 = ((m*constante4) - (constante1*constante3))/((m*constante2) - (constante3*constante3));

            var y = coeficiente1 + (xo*coeficiente2);

            return y;
        }
    }
}