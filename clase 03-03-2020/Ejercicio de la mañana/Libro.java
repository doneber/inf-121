
public class Libro {
	private String titulo;
	private String autor;
	private double precio;
	
	public Libro(String titulo, String autor, double precio){
		this.titulo = titulo;
		this.autor = autor;
		this.precio = precio;
	}
	public void mostrar(){
		System.out.println("\ndatos de Libro");
		System.out.println("titulo = " + this.titulo);
		System.out.println("autor = " + this.autor);
		System.out.println("precio = " + this.precio);
	}
}
