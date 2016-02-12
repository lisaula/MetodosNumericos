using System.Security.Cryptography;
using System.Security.Permissions;

namespace Main
{
    public class DiferenciacionNumerica
    {


        public string DifereciacionNumerica(int N,double XD, double []x,double[]fx)
        {
            double DP = 0;
            var i = 0;
            while (i<=N)
            {
                double p = 1;
                var j = 0;  
                while (j <= N)
                {
                    if (i != j)
                        p*=(x[i] - x[j]);
                    j++;
                }
                var k = 0;
                double s = 0;
                    while (k <= N)
                    {
                        if (i != k)
                        {
                            double Pone = 1;
                            j = 0;
                            while (j <= N)
                            {
                                if (j != i && j != k)
                                    Pone*=(XD - x[j]);
                                j++;
                            }
                            s+=Pone;
                        }
                        k++;
                    }
                    DP=DP+(fx[i]/p)*s;
                    i++;
                }
            return "La Respuesta Correcta es :"+DP;
      
            }
        }
    }