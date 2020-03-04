
public class Biblioteca {
	private String nom;
	private int nlib;
	private String lib[][] = new String[50][3];
	
	//constructor por defecto
	public Biblioteca(){
		this.nom = "Bib. Informatica";
		this.nlib = 3;
		lib[0][0] = "java";       lib[0][1] = "perez";     lib[0][2] = "80";
		lib[1][0] = "php";        lib[1][1] = "flores"; lib[1][2] = "120";
		lib[2][0] = "digitales";  lib[2][1] = "perez";  lib[2][2] = "200";
	}
	public void mostrar(){
		System.out.println("\nDatos de Biblioteca");
		System.out.println("Nom = " + this.nom);
		System.out.println("Nro Lib = " + this.nlib);
		for (int i = 0; i < this.nlib; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.print(this.lib[i][j] + "\t\t");
			}
			System.out.println();
		}
	}
	public String getNom() {
		return nom;
	}
	public int getNlib() {
		return nlib;
	}
	public String[][] getLib() {
		return lib;
	}
	public int contarLibAutor(String nomAutor) {
		int c = 0;
		for (int i = 0; i < this.nlib; i++) {
			if(this.lib[i][1].equals(nomAutor))
				c++;
		}
		return c;
	}
	public double precioTotal(String nomAutor) {
		double total = 0;
		for (int i = 0; i < this.nlib; i++) {
			if(this.lib[i][1].equals(nomAutor))
				total = total + Double.parseDouble((this.lib[i][2]));
		}
		return total;
	}
	
	
	
	
}
