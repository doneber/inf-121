using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace examenPersistencia
{
	/// <summary>
	/// Description of ArchivoEncuesta.
	/// </summary>
	public class ArchivoEncuesta
	{
		private string nombreArch;
		private Votacion regVot;
		public ArchivoEncuesta(string nombreArch)
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
					Votacion votacionAux = (Votacion)formateador.Deserialize(miStream);
					//copiamos al archAux
					formateador.Serialize(miStreamAux,votacionAux);
					Console.WriteLine(".");
				}
			}catch(Exception e){
				Votacion nuevaVotacion = new Votacion();
				nuevaVotacion.leer();
				formateador.Serialize(miStreamAux,nuevaVotacion);
				
				miStream.Close();
				miStreamAux.Close();
				File.Delete(this.nombreArch);
				File.Move(pathArchivoAux,this.nombreArch);
			}
			
		}
		public void mostrar(){
			Stream miStream2 = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			
			Console.WriteLine("Canal\t\tdpto1\t\tdpto2\t\tdpto3\t\tdpto4\t\tdpto5");
			BinaryFormatter formateador = new BinaryFormatter();
			try{
				formateador = new BinaryFormatter();
				while(true){
					Votacion votacionAux = (Votacion)formateador.Deserialize(miStream2);
					votacionAux.mostrar();
					Console.WriteLine();
				}
			}catch(Exception e){
				Console.WriteLine("Finalizado :D");
				miStream2.Close();
			}
		}
		public void canalMasVisto(int nroDepto){
			Stream miStream2 = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			BinaryFormatter formateador = new BinaryFormatter();
			int elMasVisto=0;
			try{
				formateador = new BinaryFormatter();
				while(true){
					Votacion votacionAux = (Votacion)formateador.Deserialize(miStream2);
					if(nroDepto == 1){
						if(votacionAux.dpto1 > elMasVisto)
							elMasVisto = votacionAux.dpto1;
					}
					if(nroDepto == 2){
						if(votacionAux.dpto2 > elMasVisto)
							elMasVisto = votacionAux.dpto2;
					}
					if(nroDepto == 3){
						if(votacionAux.dpto3 > elMasVisto)
							elMasVisto = votacionAux.dpto3;
					}
					if(nroDepto == 4){
						if(votacionAux.dpto4 > elMasVisto)
							elMasVisto = votacionAux.dpto4;
					}
					if(nroDepto == 5){
						if(votacionAux.dpto5 > elMasVisto)
							elMasVisto = votacionAux.dpto5;
					}
				}
			}catch(Exception e){
				miStream2.Close();
			}
			//Ahora si vemos
			miStream2 = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			Console.WriteLine("El mas visto tiene:"+elMasVisto);
			try{
				formateador = new BinaryFormatter();
				while(true){
					Votacion votacionAux = (Votacion)formateador.Deserialize(miStream2);
					if(nroDepto == 1){
						if(votacionAux.dpto1 == elMasVisto)
							Console.WriteLine("El canal: "+votacionAux.canal);
					}
					if(nroDepto == 2){
						if(votacionAux.dpto2 == elMasVisto)
							Console.WriteLine("El canal: "+votacionAux.canal);
					}
					if(nroDepto == 3){
						if(votacionAux.dpto3 == elMasVisto)
							Console.WriteLine("El canal: "+votacionAux.canal);
					}
					if(nroDepto == 4){
						if(votacionAux.dpto4 == elMasVisto)
							Console.WriteLine("El canal: "+votacionAux.canal);
					}
					if(nroDepto == 5){
						if(votacionAux.dpto5 == elMasVisto)
							Console.WriteLine("El canal: "+votacionAux.canal);
					}
				}
			}catch(Exception e){
				miStream2.Close();
			}			
		}
		public void canalMasAundiencia(){
			Stream miStream2 = new FileStream(this.nombreArch,FileMode.Open,FileAccess.Read,FileShare.None);
			BinaryFormatter formateador = new BinaryFormatter();
			
			try{
				formateador = new BinaryFormatter();
				while(true){
					Votacion votacionAux = (Votacion)formateador.Deserialize(miStream2);
					int promedio = (votacionAux.dpto1+votacionAux.dpto2+votacionAux.dpto3+votacionAux.dpto4+votacionAux.dpto5)/5;
					if(promedio>65){
						votacionAux.mostrar();
					}
				}
			}catch(Exception e){
				miStream2.Close();
			}
		}
	}
}
