using System;

namespace Composicion
{
    class Libro
    {
        private string nombre;
        private int nroPaginas;
        private Pagina[] paginas;
        
        public Libro(){
            nombre = "ABCedario";
            paginas = new Pagina[3];
            nroPaginas = 3;
            paginas[0]= new Pagina("A",1);
            paginas[1]= new Pagina("B",2);
            paginas[2]= new Pagina("C",3);
        }
        public void mostrar(){
            Console.WriteLine($"nombre: {nombre}, nro: {nroPaginas}");
            for(int i = 0; i<nroPaginas; i++){
                paginas[i].mostrar();
            }
        }
    }
}

