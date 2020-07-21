using System;

namespace examenPersistencia
{
	[Serializable]
	public class Votacion
	{
		public string canal;
		public int dpto1;
		public int dpto2;
		public int dpto3;
		public int dpto4;
		public int dpto5;
		public Votacion(string canal, int dpto1, int dpto2, int dpto3, int dpto4, int dpto5)
		{
			this.canal = canal;
			this.dpto1 = dpto1;
			this.dpto2 = dpto2;
			this.dpto3 = dpto3;
			this.dpto4 = dpto4;
			this.dpto5 = dpto5;
		}
		public Votacion(){
			this.canal = "";
			this.dpto1 = 0;
			this.dpto2 = 0;
			this.dpto3 = 0;
			this.dpto4 = 0;
			this.dpto5 = 0;
		}
		public void mostrar(){
			Console.WriteLine(this.canal+"\t\t"+this.dpto1+"\t\t"+this.dpto2+"\t\t"+this.dpto3+"\t\t"+this.dpto4+"\t\t"+this.dpto5);
		}
		public void leer(){
			Console.WriteLine("Canal nombre?");
			this.canal = Console.ReadLine();
			Console.WriteLine("Porsentaje de votacion dpto1?");
			this.dpto1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Porsentaje de votacion dpto2?");
			this.dpto2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Porsentaje de votacion dpto3?");
			this.dpto3 = int.Parse(Console.ReadLine());
			Console.WriteLine("Porsentaje de votacion dpto4?");
			this.dpto4 = int.Parse(Console.ReadLine());
			Console.WriteLine("Porsentaje de votacion dpto5?");
			this.dpto5 = int.Parse(Console.ReadLine());
		}
	}
}
