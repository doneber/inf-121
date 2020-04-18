/*
 * Created by SharpDevelop.
 * User: Eber
 * Date: 17/4/2020
 * Time: 7:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tarea
{
	/// <summary>
	/// Description of Lista.
	/// </summary>
	public class Lista
	{
		private string nomDoc;
		private int nroEstudiantes;
		private string[] nombresEst = new string[100];
		private int[] puntajesEst=new int[100];
		
		public int NroEstudiantes {
			get { return nroEstudiantes; }
			set { nroEstudiantes = value; }
		}
		
		public string NomDoc {
			get { return nomDoc; }
			set { nomDoc = value; }
		}
		public string[] NombresEst {
			get { return nombresEst; }
			set { nombresEst = value; }
		}
		
		public int[] PuntajesEst {
			get { return puntajesEst; }
			set { puntajesEst = value; }
		}
		public Lista()
		{
		}
		public Lista(string nd, int ne, string[] n, int[] p)
		{
			nomDoc = nd;
			nroEstudiantes = ne;
			nombresEst = n;
			puntajesEst = p;
		}
		public void mostrar(){
			Console.WriteLine("Nombre Docente: " + nomDoc);
			Console.WriteLine("Nro estudiantes: " + nroEstudiantes);
			Console.WriteLine("Estudiantes y notas:");
			for(int i=0; i<nroEstudiantes;i++){
				Console.WriteLine(nombresEst[i] +" -> " + puntajesEst[i]);
			}
		}
		public static Lista operator +(Lista lis, Lista lis2){
			Lista lisRes;
			lisRes = new Lista();
			lisRes.nomDoc = lis.nomDoc;
			lisRes.nroEstudiantes = lis.nroEstudiantes;
			for(int i=0; i<lis.nroEstudiantes;i++){
				if(lis2.nombresEst[i]!="")
					lisRes.nombresEst[i]=lis.nombresEst[i] + " y "+lis2.nombresEst[i];
				else
					lisRes.nombresEst[i]=lis.nombresEst[i];
				lisRes.puntajesEst[i]= lis.puntajesEst[i] + lis2.puntajesEst[i];
			}
			return lisRes;
		}
	}
}
