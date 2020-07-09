using System;

namespace Agregacion
{
    class Refrigerador
    {
        private string marca;
        private int cantAlimentos;
        private Alimento[] alimentos;

        public Refrigerador(string m){
            marca = m;
            cantAlimentos = 0;
            alimentos = new Alimento[30];
        }
        public void adicionarAlimento(Alimento a){
            alimentos[cantAlimentos]=a;
            cantAlimentos++;
        }
        public void mostrar(){
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"cantAlimentos: {cantAlimentos}");
            for(int i = 0; i<cantAlimentos;i++){
                alimentos[i].mostrar();
            }
        }
        public void mostrarAlimento(string x){
          for(int i = 0 ; i < cantAlimentos; i++){
            if (alimentos[i].nombre == x){
              alimentos[i].mostrar();
            }
          }
        }
    }
}
