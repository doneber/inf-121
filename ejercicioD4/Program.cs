using System;

namespace defensa04121
{
    class Program
    {
        static void Main(string[] args)
        {

            EquipoComputacional a1 = new EquipoComputacional(1,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("CPU", "Invader", 5000) });
            EquipoComputacional a2 = new EquipoComputacional(2,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("Teclado", "LG", 100) });
            EquipoComputacional a3 = new EquipoComputacional(3,"malo",2, new Parte[]{ new Parte("raton", "SONY", 3000) ,new Parte("Monitor", "Invader", 5000) });
            EquipoComputacional a4 = new EquipoComputacional(4,"bueno",2, new Parte[]{ new Parte("raton", "SONY", 3000) ,new Parte("Monitor", "Invader", 5000) });

            EquipoComputacional b1 = new EquipoComputacional(5,"bueno",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("CPU", "Invader", 5000) });
            EquipoComputacional b2 = new EquipoComputacional(6,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("Teclado", "LG", 100) });
            EquipoComputacional b3 = new EquipoComputacional(7,"bueno",2, new Parte[]{ new Parte("raton", "SONY", 3000) ,new Parte("Monitor", "Invader", 5000) });

            EquipoComputacional c1 = new EquipoComputacional(8,"bueno",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("CPU", "Invader", 5000) });
            EquipoComputacional c2 = new EquipoComputacional(9,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("Teclado", "LG", 100) });
            EquipoComputacional c3 = new EquipoComputacional(10,"malo",2, new Parte[]{ new Parte("raton", "SONY", 3000) ,new Parte("Monitor", "Invader", 5000) });
            EquipoComputacional c4 = new EquipoComputacional(11,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("CPU", "Invader", 5000) });
            EquipoComputacional c5 = new EquipoComputacional(12,"malo",2, new Parte[]{ new Parte("Monitor", "Samsung", 3000) ,new Parte("Teclado", "LG", 100) });

            // e1.mostrar();
            // e2.mostrar();
            // e3.mostrar();
            Laboratorio l1 = new Laboratorio("Stallman", 4, new EquipoComputacional[]{ a1, a2, a3, a4 });
            // l1.mostrar();
            Laboratorio l2 = new Laboratorio("Linus Torvals", 3, new EquipoComputacional[]{ b1, b2, b3 });
            // l2.mostrar();
            Laboratorio l3 = new Laboratorio("Alan Turing", 5, new EquipoComputacional[]{ c1, c2, c3, c4, c5 });
            // l3.mostrar();

            EquipoComputacional f = new EquipoComputacional();
            Carrera c = new Carrera(3, new Laboratorio[]{ l1, l2, l3 });

            // // c.mostrarElMejorLabo();
            // // c.totalLabo("Linus Torvals");

            c.moverCompu("Alan Turing","Stallman",3);
            c.mostrar();

        }
    }
}
