using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Archivos
{
	public class Archivo
	{
		private string nombreArch;
		public Archivo(string nombreArch)
		{
			this.nombreArch=nombreArch;
		}
		public void crear(){
			Stream miStream3 = new FileStream(this.nombreArch,FileMode.Create,FileAccess.Write,FileShare.None);
			miStream3.Close();
		}
		public void adicionar(){
			string pathArchivoAux = "copiaArchivo.txt";
			Stream miStream = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			Stream miStreamAux = new FileStream(pathArchivoAux,FileMode.Create,FileAccess.Write,FileShare.None);
			BinaryFormatter formateador = new BinaryFormatter();
			try{
				while(true){
					//Obtenemos el dato
					Perro perritoAux = (Perro)formateador.Deserialize(miStream);
					//copiamos al archAux
					formateador.Serialize(miStreamAux,perritoAux);
					Console.WriteLine(".");
				}
			}catch(Exception e){
				Perro perrito = new Perro();
				perrito.leer();
				formateador.Serialize(miStreamAux,perrito);
				
				miStream.Close();
				miStreamAux.Close();
				File.Delete(this.nombreArch);
				File.Move(pathArchivoAux,this.nombreArch);
			}
			
		}
		public void mostrar(){
			Stream miStream2 = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			
			Console.WriteLine("*********************************");
			Console.WriteLine("******  PERRITOOOOS!   **********");
			Console.WriteLine("*********************************");
			BinaryFormatter formateador = new BinaryFormatter();
			try{
				formateador = new BinaryFormatter();
				while(true){
					Perro perritoAux = (Perro)formateador.Deserialize(miStream2);
					perritoAux.mostrar();
					Console.WriteLine();
				}
			}catch(Exception e){
				Console.WriteLine("Finalizado :D");
				miStream2.Close();
			}
			
		}
	}
}
