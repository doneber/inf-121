using System;

namespace Ejercicio_POO
{
    class ConjuntoEntero
    {
        private int n;
        private bool[] c=new bool[101];
	// Constructor para generar datos aleatorios por defecto
        public ConjuntoEntero(){
            n=100;
            Random random = new Random();  
            for(int i=0; i<101; i++){
                c[i]=false;
            }
        }
	    
	// Constructor para llenar k elementos en true 
        public ConjuntoEntero(int k){
            n=100;
            Random random = new Random();  
            for(int i=0; i<101; i++){
                c[i]=false;
            }
            for(int i=0; i<k; i++){
                c[random.Next(101)]=true;
            }
        }
	// Sobrecargamos el operador '+' para hacer lo que en Teoria de Conjutos se llama la "Unioin"
        public static ConjuntoEntero operator +(ConjuntoEntero conj, ConjuntoEntero conj2){
			ConjuntoEntero conjRes=new ConjuntoEntero();
            for(int i=0; i<101; i++){
                if(conj.C[i] || conj2.C[i])
                    conjRes.C[i]=true;
            }
			return conjRes;
		}
	//Metodo mostrar que no devuelve nada
        public void mostrar(){
            Console.WriteLine("n: "+n);
            for(int i=0; i<101; i++)
                if(c[i])
                    Console.Write(i+"\t");
            Console.WriteLine();
        }
	//Método mostrar que devuelve un string, sobrecargado solo para cumplir con el enunciado (el parametro no importa que le envies)
        public string mostrar(string s){
            String res = "";
            for(int i=0; i<101; i++)
                if(c[i]){
                    res+=" "+i;
                }
            if(res!="")
                return res;
            else
                return "--";
        }
	// Elimina pero verificamos que este en el rango de nuestro vector
        public void eliminarElemento(int x){
            if(x>= 0 && x <=100){
                c[x]=false;
                Console.WriteLine("Elemento eliminado exitosamente");
            }else{
                Console.WriteLine("Error al elminiar, numero inválido");

            }
        }
	    
	// Getters y setters
        public int N {
			get { return n; }
			set { n = value; }
		}
        public bool[] C {
			get { return c; }
			set { c = value; }
		}
    }
}
