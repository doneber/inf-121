using System;

namespace defensa04121
{
    class Carrera
    {
        private int nroLaboratorios;
        private Laboratorio[] L = new Laboratorio[30];
        public Carrera(){
            nroLaboratorios = 1;
            L[0]= new Laboratorio();
        }
        public Carrera(int nroLaboratorios, Laboratorio[] labos){
            this.nroLaboratorios = nroLaboratorios;
            L = labos;
        }

        public void mostrar(){
            Console.WriteLine("Nro de Labs:" + this.nroLaboratorios);
            for(int i= 0; i < this.nroLaboratorios; i++){
                Console.WriteLine("*********************************************");    
                L[i].mostrar();
            }
        }
        public void mostrarElMejorLabo(){
            // 2) Mostraremos el labo con mas compus en buen estado
            int mayor = -1;
            // int indice = -1;
            for(int i= 0; i < this.nroLaboratorios; i++){
                if(L[i].contarBuenos() > mayor){
                    mayor = L[i].contarBuenos();
                    // indice = i;
                }
            }

            Console.WriteLine("************************************");
            Console.WriteLine("El mayor labo con buenas compus es: ");
            for(int i= 0; i < this.nroLaboratorios; i++){
                if(L[i].contarBuenos() == mayor){
                    Console.WriteLine("************************************");
                    this.L[i].mostrar();
                    Console.WriteLine("************************************");
                }

            }
        }
        public void totalLabo(string nomLabo){
            // Mostremos el costo del labo x
            for(int i= 0; i < this.nroLaboratorios; i++){
                if(L[i].getNombre() == nomLabo){
                    L[i].precioTotalDeEquipos();
                }
            }
            


        }
        public void moverCompu(string laboX, string laboY, int nroCompusAMover){
            // Movemos compus del 'laboX' al 'laboY' donde 'nroCompusAMover' es la cantidad  de compsu a mover
            Laboratorio x = null;
            Laboratorio y = null;
            for(int i= 0; i < this.nroLaboratorios; i++){
                if (this.L[i].getNombre() == laboX ){
                    x = this.L[i];
                }
                if (this.L[i].getNombre() == laboY ){
                    y = this.L[i];
                }
            }

            for(int i= 0; i < nroCompusAMover; i++){
                EquipoComputacional aux = x.eliminarCompu();
                y.agregarCompu(aux);
            }

        }
    }
}
