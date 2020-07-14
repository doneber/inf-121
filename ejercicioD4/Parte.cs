using System;

namespace defensa04121
{
    class Parte
    {
        private string nombre;
        private string marca;
        private int precio;
        public Parte(){
            this.nombre = "Monitor";
            this.marca = "Sony";
            this.precio = 2000;
        }
        public Parte(string mombre, string marca, int precio){
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }
        public void mostrar(){
            Console.WriteLine("Nombre: "+ this.nombre);
            Console.WriteLine("Marca: "+ this.marca);
            Console.WriteLine("Precio: "+ this.precio);
        }
        public int getPrecio(){

            return this.precio;
        }
    }
}
