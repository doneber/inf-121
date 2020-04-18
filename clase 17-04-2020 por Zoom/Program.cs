/*
 * Created by SharpDevelop.
 * User: Eber
 * Date: 17/4/2020
 * Time: 6:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tarea
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("La práctica: ");
			int[,] m = new int[2,3];
			m[1,0]=3;
			m[1,1]=12;
			m[1,2]=1;
			PracticasPolinomios p1 = new PracticasPolinomios("Pedro", 2,m);
			p1.mostrar();
			Console.WriteLine("=========Lista=====================");
			Lista l1 = new Lista("Menfy", 3, new string[]{"Pedro", "JP", "Dj"},new int[]{35,46,20});
			l1.mostrar();
			Console.WriteLine("========Luego...===================");

			Lista aux = new Lista("", 0, new string[]{"Marcos", "", ""},new int[]{16,0,0});
			Lista lista = l1+aux;
			lista.mostrar();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}