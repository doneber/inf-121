using System;

namespace Agregacion
{
    class Alimento
    {
        private string nombre;
        private string fechaDeVencimiento;
        private int cantidad;
        
        public Alimento(string n,string f,int c){
            nombre = n;
            fechaDeVencimiento = f;
            cantidad =c ;
        }
        public void mostrar(){
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"FechaVen: {fechaDeVencimiento}");
            Console.WriteLine($"Cantidad: {cantidad}");
        }
    }
}
