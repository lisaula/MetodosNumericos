

namespace Main._1_al_10
{
    public class InterpolanteDeNewton
    {
        public string Calculate(double value, double[] x, double[] y)
        {
            var b = new double[x.Length, y.Length];

            for (var i = 0; i < x.Length; i++)
                b[i, 0] = y[i];

            for (var j = 1; j < x.Length; j++)
                for (var i = 0; i < x.Length - j; i++)
                    b[i, j] = (b[i + 1, j - 1] - b[i, j - 1]) / (x[i + j] - x[i]);

            double xt = 1;
            double yi = b[0, 0];
            for (var i = 0; i < x.Length - 1; i++)
            {
                xt = xt * (value - x[i]);
                yi = yi + b[0, i + 1] * xt;

            }

            return "La respuesta Correcta es:"+yi;
        }
    }
}