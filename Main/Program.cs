using System;
using System.Linq;
using Main._1_al_10;
using MathExpressionsNET;

// ReSharper disable All


namespace Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"....Proyecto de Metodos.....");
                Console.WriteLine(@"1) Metodo De Biseccion");
                Console.WriteLine(@"2) Metodo De Punto Fijo");
                Console.WriteLine(@"3) Metodo De Newton Raphson");
                Console.WriteLine(@"4) Metodo De Secante");
                Console.WriteLine(@"5) Metodo De La Falsa Posicion");
                Console.WriteLine(@"6) Metodo De Muller");
                Console.WriteLine(@"7) Interpolacion de LaGrange");
                Console.WriteLine(@"8) InterpolanteDeNewton");
                Console.WriteLine(@"9) Trazador Cubico Natural");
                Console.WriteLine(@"10) Trazador Cubico Sujeto");
                Console.WriteLine(@"11) Diferenciacion Numerica");
                Console.WriteLine(@"12) Regla de Trapezio");
                Console.WriteLine(@"13) Metodo de Simpson");
                Console.WriteLine(@"14) Cuadraturas de Gauss");
                Console.WriteLine(@"15) Metodo de Euler");
                Console.WriteLine(@"16) Rung Kutta de 4 Orden");
                Console.WriteLine(@"17) Sistema de Ecuaciones Rung Kutta ");
                Console.WriteLine(@"18) Gauss");
                Console.WriteLine(@"19) GaussJordan");
                Console.WriteLine(@"20) Descomposicion de LU");
                Console.WriteLine(@"21) Sistema de ecuaciones mediante la inversa");
                op= int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Algoritmo1();
                        break;
                    case 2:
                        Algoritmo2();
                        break;
                    case 3:
                       Algoritmo3();
                        break;
                    case 4:
                        Algoritmo4();
                        break;
                    case 5:
                        Algoritmo5();
                        break;
                    case 6:
                        Algoritmo6(); 
                        break;
                    case 7:
                        Algoritmo7();
                        break;
                    case 8:
                        Algoritmo8();
                        break;
                    case 9:
                        Algoritmo9();
                    break;
                    case 10:
                        Algoritmo10();
                    break;
                    case 11:
                        Algoritmo11();
                    break;
                    case 12:
                        Algoritmo12();
                    break;
                    case 13:
                        Algoritmo13();
                    break;
                    case 14:
                        Algoritmo14();
                    break;
                    case 15:
                        Algoritmo15();
                    break;
                    case 16:
                        Algoritmo16();
                    break;
                    case 17:
                        Algoritmo17();
                    break;
                    case 18:
                        Algoritmo18();
                    break;
                    case 19:
                        Algoritmo19();
                    break;
                    case 20:
                        Algoritmo20();
                    break;
                    case 21:
                        Algoritmo21();
                    break;
                }

            } while (op<=23);
            Console.WriteLine(@"Saliendo del Programa....");
            Console.ReadLine();
        }

    
        public static void Algoritmo1()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese limite inferior");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese limite superior");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var m = new MetodoDeBiseccion();
            Console.WriteLine(m.MetodoBiseccion(fn, a, b, t, n));
        }
        public static void Algoritmo2()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese la derivada de funcion");
            var fn2 = Console.ReadLine();
            Console.WriteLine(@"Ingrese la aproximacion inicial");
            var aprox = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var pf = new PuntoFijo();
            Console.WriteLine(pf.puntofijo(fn, fn2, aprox, t, n));
        }
        public static void Algoritmo3()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese funcion ya despejada");
            var fn2 = Console.ReadLine();
            Console.WriteLine(@"Ingrese la aproximacion inicial");
            var aprox = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var NR = new NewtonRaphson();
            Console.WriteLine(NR.newtonRaphson(fn, fn2, aprox, t, n));
        }
        public  static void Algoritmo4()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese la aproximacion inicial P0");
            var P0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese la aproximacion inicial P1");
            var P1 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var sec = new MetodoSecante();
            Console.WriteLine(sec.Calculate(fn,P0,P1,t,n));
        }
        public static void Algoritmo5()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese la aproximacion inicial P0");
            var P0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese la aproximacion inicial P1");
            var P1 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var posf = new PosicionFalsa();
            Console.WriteLine(posf.Calculate(fn,P0,P1,t,n));
        }
        public static void Algoritmo6()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese x0");
            var x0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese x1");
            var x1 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese x2");
            var x2 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Tolerancia");
            var t = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var muller = new Muller();
            Console.WriteLine(muller.Mullermethod(fn, x0, x1, x2, t, n));
        }
        public static void Algoritmo7()
        {
            Console.WriteLine("Ingrese valor");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese  los valores de x separados por comas");
            string xvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  los valores de f(x) evaluados separados por comas");
            string xfnvalues = Console.ReadLine();
            var xvalueslist = xvalues.Split(',');
            var xfnvalueslist = xfnvalues.Split(',');
            var x = xvalueslist.Select(i => Double.Parse(i)).ToList();
            var a = xfnvalueslist.Select(i => Double.Parse(i)).ToList();
            var interLG = new InterpolacionLaGrange();
            Console.WriteLine(interLG.Calculate(value, x.ToArray(), a.ToArray()));
        }
        public static void Algoritmo8()
        {
            Console.WriteLine("Ingrese valor");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese  los valores de x separados por comas");
            string xvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  los valores de f(x) evaluados separados por comas");
            string xfnvalues = Console.ReadLine();
            var xvalueslist = xvalues.Split(',');
            var xfnvalueslist = xfnvalues.Split(',');
            var x = xvalueslist.Select(i => Double.Parse(i)).ToList();
            var a = xfnvalueslist.Select(i => Double.Parse(i)).ToList();
            var interN = new InterpolanteDeNewton();
            Console.WriteLine(interN.Calculate(value, x.ToArray(), a.ToArray()));
        }
        public static void Algoritmo9()
        {
            Console.WriteLine(@"Ingrese  los valores de x separados por comas");
            string xvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  los valores de f(x) evaluados separados por comas");
            string xfnvalues = Console.ReadLine();
            var xvalueslist = xvalues.Split(',');
            var xfnvalueslist = xfnvalues.Split(',');
            var x = xvalueslist.Select(i => Double.Parse(i)).ToList();
            var a = xfnvalueslist.Select(i => Double.Parse(i)).ToList();
            TrazadorCubicoNatural tcn =new TrazadorCubicoNatural();
            tcn.Ejecutar(x.ToArray(),a.ToArray());
        }
        public static void Algoritmo10()
        {
            Console.WriteLine(@"Ingrese  los valores de x separados por comas");
            string xvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  los valores de f(x) evaluados separados por comas");
            string xfnvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  el valor de fp0");
            double fp0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese  el valor de fpn");
            double fpn = double.Parse(Console.ReadLine());
            var xvalueslist = xvalues.Split(',');
            var xfnvalueslist = xfnvalues.Split(',');
            var x = xvalueslist.Select(i => Double.Parse(i)).ToList();
            var a = xfnvalueslist.Select(i => Double.Parse(i)).ToList();
            var tcs = new InterpolacionMedianteTrazadores();
            tcs.Calculate(x.ToArray(), a.ToArray(),fp0,fpn);
        }
        public static void Algoritmo11()
        {
            Console.WriteLine(@"Ingrese  los valores de x separados por comas");
            string xvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  los valores de f(x) evaluados separados por comas");
            string xfnvalues = Console.ReadLine();
            Console.WriteLine(@"Ingrese  el valor XD");
            double xd = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese  el numero N");
            int n = int.Parse(Console.ReadLine());
            var xvalueslist = xvalues.Split(',');
            var xfnvalueslist = xfnvalues.Split(',');
            var x = xvalueslist.Select(i => Double.Parse(i)).ToList();
            var a = xfnvalueslist.Select(i => Double.Parse(i)).ToList();
            var difn = new DiferenciacionNumerica();
            Console.WriteLine(difn.DifereciacionNumerica(n, xd, x.ToArray(), a.ToArray()));
        }
        public static void Algoritmo12()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese limite inferior");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese limite superior");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var trapezio = new ReglaTrapezio();
            Console.WriteLine(trapezio.Reglatrapezio(fn,a,b,n));
        }
        public static void Algoritmo13()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese limite inferior");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese limite superior");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var simpson = new Simpson();
            Console.WriteLine(simpson.simpsonEvaluar(fn, a, b, n));
        }
        public static void Algoritmo14()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese limite inferior");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese limite superior");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var cuadraturasGauss = new CuadraturasGauss();
            Console.WriteLine(cuadraturasGauss.cudraturasgauss(fn, a, b, n));
        }
        public static void Algoritmo15()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese X0");
            var x0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese XF");
            var xf = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Y0");
            var y0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var euler = new MetodoEuler();
            Console.WriteLine(euler.Euler(fn, x0, xf, y0,n));
        }
        public static void Algoritmo16()
        {
            Console.WriteLine(@"Ingrese funcion a evaluar");
            var fn = Console.ReadLine();
            Console.WriteLine(@"Ingrese X0");
            var x0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese XF");
            var xf = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese Y0");
            var y0 = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Ingrese numero de iteraciones");
            var n = int.Parse(Console.ReadLine());
            var kutta4orden = new RungKutta4Orden();
            Console.WriteLine(kutta4orden.metodo4orden(fn, x0, xf, y0, n));
        }
        public static void Algoritmo17()
        {
            
        }
        public static void Algoritmo18()
        {
            
        }
        public static void Algoritmo19()
        {
            Console.WriteLine("Ingrese la Matriz a evaluar");
            var matrix = Console.ReadLine();
            Console.WriteLine("Ingrese el tamano de N");
            var dimension = int.Parse(Console.ReadLine());
            var strToArr = new StringtoDoubleArray();
            double[,] x = strToArr.ToDoubleBidimensionalArray(matrix);
            var gj = new GaussJordan();
            //ejemplo
            //double[,] x = { { 2, 4, 6, 18 }, { 4, 5, 6, 24 }, { 3, 1, -2, 4 } };
            gj.Calculate(x,dimension );

        }
        public static void Algoritmo20()
        {
            Console.WriteLine("Ingrese la Matriz a evaluar");
            var matrix = Console.ReadLine();
            DescomposicionLU lu = new DescomposicionLU();
            var strToArr = new StringtoDoubleArray();
            //double[,] x = strToArr.ToDoubleBidimensionalArray(matrix);
            //ejemplo 
            double[,] x = {{2,1,-1,},{-3,-1,2},{-2,1,2}};
            lu.calculate(x);
        }
        public static void Algoritmo21()
        {
            Console.WriteLine("Ingrese la Matriz a evaluar");
            var matrix = Console.ReadLine();
            Console.WriteLine("Ingrese el vector de resultado");
            var strV = Console.ReadLine();
            Inversa inv = new Inversa();
            var strToArr = new StringtoDoubleArray();
            double[,] x=strToArr.ToDoubleBidimensionalArray(matrix);
            var strVlist = strV.Split(',');
            double[] b= strVlist.Select(i => Double.Parse(i)).ToArray();
            //ejemplo x es la matriz y b el vector de resultado
            //double[,] x = {{3,4},{5,6}};
            //double[] b = {3,7};
            inv.Calculate(x,b);
        }


    }


}




