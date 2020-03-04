
public class Main {
	public static void main(String[] args) {
		System.out.println("Empezamos con el ejercicio");
		//Instancie 3 videojuegos
		VideoJuego vd1, vd2, vd3;
		vd1 = new VideoJuego("Clash of Clans", "Shooter",2010);
		vd2 = new VideoJuego("Minecraft", "construccion", 2007);
		vd3 = new VideoJuego("Fornite", "Shooter", 2020);
		vd1.mostrar();
		vd2.mostrar();
		vd3.mostrar
		//Compre los videojuegos 
		compararVideojuegos(vd2, vd3);
		//Cree un vector de videojuegos
		//VideoJuego vec[] = new VideoJuego[4];
		VideoJuego vecJuegos[] = {vd1,vd2,vd3,vd1};// <-- VECTOR
		ordenarVideojuegos(vecJuegos);
		for (int i = 0; i < vecJuegos.length; i++) {
			vecJuegos[i].mostrar();
		}
	}
	static public void compararVideojuegos  (VideoJuego v1, VideoJuego v2){
		if(v1.getAnioCreacion() == v2.getAnioCreacion())
			System.out.println("Si se crearon el mismos anio");
		else
			System.out.println("No se crearon el mismo año");
	}
	static public void ordenarVideojuegos(VideoJuego[] vecJ){
		for (int i = 0; i < vecJ.length; i++) {
			VideoJuego aux1 = vecJ[i];
			for (int j = i+1; j < vecJ.length; j++) {
				VideoJuego aux2 = vecJ[j];
				VideoJuego elAuxiliar;
				if( aux1.getAnioCreacion() > aux2.getAnioCreacion()){
					elAuxiliar = vecJ[i];
					vecJ[i]=vecJ[j];
					vecJ[j]=elAuxiliar;
				}
			}
		}
	}
	
}
