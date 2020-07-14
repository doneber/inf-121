using System;

namespace defensa04121
{
    class Laboratorio
    {
        private string nombre;
        private int nroEquiposComp;
        private EquipoComputacional[] E = new EquipoComputacional[30];

        public Laboratorio(){
            nombre = "Lab Ingles";
            nroEquiposComp = 1;
            E[0] = new EquipoComputacional();
        }

        public Laboratorio(string nombre, int nroEquiposComp, EquipoComputacional[] equipos){
            this.nombre = nombre;
            this.nroEquiposComp = nroEquiposComp;
            for( int i = 0 ; i < nroEquiposComp; i++){
                E[i] = equipos[i];
            }
        }
        public void mostrar(){
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Nro eq: " + nroEquiposComp);
            for(int i=0; i< this.nroEquiposComp; i++){
                Console.WriteLine("_______________________");
                E[i].mostrar();
            }
        }

        public int contarBuenos(){
            int contador = 0;
            for(int i=0; i< this.nroEquiposComp; i++){
                if (E[i].getEstado() == "bueno"){
                    contador++;
                }
            }
            return contador;
        }
        public void precioTotalDeEquipos(){
            int total = 0;
            for(int i=0; i< this.nroEquiposComp; i++){
                total = total + E[i].valorNeto();
            }
            Console.WriteLine("El costo total es: "+ total);
        }

        public EquipoComputacional eliminarCompu(){
            this.nroEquiposComp--;
            return E[nroEquiposComp];
            
        }
        public void agregarCompu(EquipoComputacional e){
            this.E[nroEquiposComp] = e;
            this.nroEquiposComp++;
        }

        public string getNombre(){
            return nombre;
        }
    }
}
