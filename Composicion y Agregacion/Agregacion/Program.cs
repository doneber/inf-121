using System;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerador r = new Refrigerador("Sony");
            r.mostrar();

            Console.WriteLine("---------------");

            Alimento a1 = new Alimento("Leche","20/5/2020",5);
            a1.mostrar();

            Console.WriteLine("---------------");
            
            r.adicionarAlimento(a1);
            r.mostrar();
        }
    }
}

