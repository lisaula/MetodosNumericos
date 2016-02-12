using System;
using MathExpressionsNET;

namespace TestLibraries
{
    public class Program
    {
        static void Main(string[] args)
        {
            var func = new MathFunc("(2 * x ^ 2 - 1 + 0 * a) ^ -1 * (2 * x ^ 2  - 1 * 1) ^ -1").Simplify();
            // func == (x ^ 2 * 2 + -1) ^ -2;
            using (var mathAssembly = new MathAssembly("x^2+x^3+34*x^2","x"))
            {
                var funcResult = mathAssembly.Func(5);
                // funcResult == 0.00041649312786339027 (precision value is -1/2401)
                var funcDerResult = mathAssembly.FuncDerivative(5);
                // funcDerResult == -0.00033999439009256349 (precision value is -40/117649)
                Console.WriteLine(funcResult+" "+funcDerResult);

            }
            Console.Read();
        }
    }
}
