using System;
using info.lundin.math;

namespace Main
{
    public class MetodoEuler
    {
       
        public string Euler(string function,double X0,double XF,double Y0,int N)
        {
            
           
            var h = (XF - X0)/N;
            int i = 1;
            Console.WriteLine("#" + 0 + "  X= " + X0 + "  Y= " + Y0);
            while (i <= N)
            {
                var exp = new ExpressionParser();
                exp.Values.Add("x",X0);
                exp.Values.Add("y",Y0);
                var result = exp.Parse(function);
                Y0 = Y0 + (h*result);
                X0 = X0 + (h);
                Console.WriteLine("#" + (i) + "  X= " + X0 + "  Y= " + Y0);
                i++;
               
            }
            return "La Respuesta Correcta es :" + Y0;
        }
    }
}