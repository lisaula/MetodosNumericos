using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;


namespace Main
{
    public class Inversa
    {
        public void Calculate(double[,] x,double[] b)
        {
            var m = DenseMatrix.OfArray(x);
            var inv = m.Inverse();
            var v = DenseVector.OfArray(b);
            var resp = inv * v;
            Console.WriteLine(@"Matriz Inversa A^-1");
            Console.WriteLine(inv.ToMatrixString());
            Console.WriteLine(@"Vector B");
            Console.WriteLine(v.ToVectorString());
            Console.WriteLine(@"X=A^-1 * B : ");
            Console.Write(resp.ToVectorString());
        }
    }

}