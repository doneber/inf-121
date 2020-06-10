using System;

namespace Ejercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // a)
            ConjuntoEntero conj=new ConjuntoEntero(3);
            conj.mostrar();
            ConjuntoEntero conj2=new ConjuntoEntero(3);
            conj2.mostrar();
            // b)
            ConjuntoEntero conj3 = conj+conj2;
            conj3.mostrar();

            // c)
            int x=  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is; "+x);
            conj3.eliminarElemento(x);
            conj3.mostrar();

            Console.WriteLine("----------------");
            Console.WriteLine(conj3.mostrar(""));
        }
    }
}
