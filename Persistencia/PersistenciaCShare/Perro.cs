using System;

namespace Archivos
{
	[Serializable]
	public class Perro
	{
		private string nombre;
		private string raza;
		private int nroCrias;
		private Cria[] crias = new Cria[10];
		public Perro(){
			this.nombre="";
			this.raza="";
			this.nroCrias=2;
			for(int i = 0; i < 10 ; i++)
				crias[i]=new Cria();
		}
		public void leer(){
			Console.WriteLine("Nombre?");
			this.nombre = Console.ReadLine();
			Console.WriteLine("Raza?");
			this.raza = Console.ReadLine();
			Console.WriteLine("Nro crias?");
			string linea = Console.ReadLine(); 
			this.nroCrias = int.Parse(linea);
			Console.WriteLine("Usted dijo que tenia nro de crias: "+this.nroCrias);
			for(int i = 0; i < this.nroCrias ; i++)
					this.crias[i].leer();
				
		}
		public void mostrar(){
			Console.WriteLine("Nombre:" +this.nombre);
		    Console.WriteLine("Raza: "+this.raza);
			Console.WriteLine("Nro Crias: "+this.nroCrias);		    
			for(int i = 0; i < this.nroCrias ; i++)
					this.crias[i].mostrar();	
		}
	}
	
	[Serializable]
	public class Cria
	{
		private string nombre;
		public Cria(){
			this.nombre="";
		}
		public void leer(){
			Console.WriteLine("Nombre de la Cria?");
			this.nombre = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("Nombre Cria:" +this.nombre);
		}
		public static Cria operator ++(Cria p)
		{
			Console.WriteLine("Q PEDO wey");
			return p;
		}
	}	
}
