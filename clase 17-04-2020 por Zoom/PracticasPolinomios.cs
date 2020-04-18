/*
 * Created by SharpDevelop.
 * User: Eber
 * Date: 17/4/2020
 * Time: 6:30 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tarea
{
	/// <summary>
	/// Description of PracticasPolinomios.
	/// </summary>
	public class PracticasPolinomios
	{
		private string nomEst;
		private int nroPolinomiosRes;
		private int[,] polinomios = new int[50,30];
		public PracticasPolinomios()
		{
			
		}
		public PracticasPolinomios(string nom, int nro, int[,] poli)
		{
			nomEst = nom;
			nroPolinomiosRes = nro;
			polinomios = poli;
		}
		public void mostrar(){
			Console.WriteLine("Nombre: "+this.nomEst);
			Console.WriteLine("Nro polinomios resueltos: "+this.nroPolinomiosRes);
			Console.WriteLine("Polinomios:");
			for(int i=0; i<nroPolinomiosRes;i++){
				for(int j=0; j<polinomios.GetLength(1);j++){
					if(polinomios[i,j]!=0)
						Console.Write(polinomios[i,j]+"x^"+j);
					if(j+1<polinomios.GetLength(1) && polinomios[i,j+1]!=0)
						Console.Write("+ " );
				}
				Console.WriteLine();
			}
		}
	}
}
