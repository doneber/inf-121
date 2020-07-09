using System;

namespace Composicion
{
    class Pagina
    {
        private string contenido;
        private int nro;
        public Pagina(string c, int n){
            this.contenido = c;
            this.nro = n;
        }
        public void mostrar(){
            Console.WriteLine($"Contenido: {this.contenido}, nro: {this.nro}");
        }
    }
}

