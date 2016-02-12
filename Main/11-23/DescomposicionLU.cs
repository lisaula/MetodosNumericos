using System;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Main
{
    public class DescomposicionLU
    {
        public void calculate(double[,] x)
        {
            var m = DenseMatrix.OfArray(x);
            try
            {
                var p = m.LU();
                Console.WriteLine(@"Upper Triangle");
                Console.Write(p.U.ToMatrixString());
                Console.WriteLine(@"Lower Triangle");
                Console.Write((p.L).ToMatrixString());
            }
            catch (ArgumentException)
            {
                
                Console.WriteLine("La Matriz No es Cuadrada");
                return;
            }
        
         

        }
    }
}
