using System;

namespace defensa04121
{
    class EquipoComputacional
    {
        private int nroId;
        private string estado;
        private int nroPartes;
        private Parte[] P;
        public EquipoComputacional(){
            this.nroId  = 1;
            this.estado = "bien";
            this.nroPartes = 1;
            this.P = new Parte[1];
            this.P[0] = new Parte();
        }
        public EquipoComputacional(int nroId, string estado, int nroPartes, Parte[] partes){
            this.nroId  = nroId;
            this.estado = estado;
            this.nroPartes = nroPartes;
            this.P = partes;
        }
        public void mostrar(){
            Console.WriteLine("Nro Id Compu: "+this.nroId);
            Console.WriteLine("Estado: "+this.estado);
            Console.WriteLine("Nro de partes: "+this.nroPartes);
            for(int i=0; i< this.nroPartes; i++){
                this.P[i].mostrar();
            }
        }
        
        public int valorNeto(){
            int valor=0;
            for(int i=0; i< this.nroPartes; i++){
                valor = valor + P[i].getPrecio();
            }
            return valor;
        }

        public string getEstado(){
            return estado;
        }
        public int getNroId(){
            return this.nroId;
        }
    }
}
