/*
 * Created by SharpDevelop.
 * User: Eber
 * Date: 21/7/2020
 * Time: 11:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace examenPersistencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArchivoEncuesta miArch = new ArchivoEncuesta("votaciones.txt");
			
			while(true){
				Console.WriteLine("Opcion 1: Adicionar");
				Console.WriteLine("Opcion 2: Mostrar");
				Console.WriteLine("Opcion 3: Crear");
				Console.WriteLine("Opcion 4: El mas visto");
				Console.WriteLine("Opcion 5: Mayor audiencia a 65%");
				string opcion = Console.ReadLine();
				switch (opcion){
					case "1":
						miArch.adicionar();
						break;
					case "2":
						miArch.mostrar();
						break;
					case "3":
						miArch.crear();
						break;
					case "4":
						Console.WriteLine("Q nro de depto quiere saber?");
						int nroCanal= int.Parse(Console.ReadLine());
						miArch.canalMasVisto(nroCanal);
						break;
					case "5":
						Console.WriteLine("Mayor audiencia");
						miArch.canalMasAundiencia();
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