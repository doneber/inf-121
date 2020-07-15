
using System;
using System.Diagnostics;

namespace Archivos
{
	class Principal
	{

		public static void Main(string[] args)
		{
			Archivo miArch = new Archivo("perritos.txt");
			
			while(true){
				Console.WriteLine("Opcion 1: Adicionar");
				Console.WriteLine("Opcion 2: Mostrar");
				Console.WriteLine("Opcion 3: Crear");
				string opcion = Console.ReadLine();
				switch (opcion){
					case "1":
						Console.Clear();
						miArch.adicionar();
						break;
					case "2":
						Console.Clear();
						miArch.mostrar();
						break;
					case "3":
						miArch.crear();
						Console.Clear();
						break;
					
					default:
						return;
					
				}
				
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}