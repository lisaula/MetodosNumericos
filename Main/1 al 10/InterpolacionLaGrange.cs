using System;
using System.Globalization;

namespace Main._1_al_10
{
    public class InterpolacionLaGrange
    {

        public string Calculate(double x, double[] xd, double[] yd)
        {


            double sum = 0;
            for (int i = 0, n = xd.Length; i < n; i++)
            {
                if (Math.Abs(x - xd[i]) < 0)
                {
                    return yd[i].ToString(CultureInfo.InvariantCulture);
                }
                double FXINT = yd[i];
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) || (Math.Abs(xd[i] - xd[j]) < 0))
                    {
                        continue;
                    }
                    FXINT *= (x - xd[j]) / (xd[i] - xd[j]);
                }
                sum += FXINT;
            }

            return "La respuesta correcta es :"+sum.ToString(CultureInfo.InvariantCulture);

        }
    }
}
