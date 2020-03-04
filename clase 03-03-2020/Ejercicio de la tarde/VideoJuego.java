public class VideoJuego {
	private String nombre, categoria;
	private int anioCreacion;

	public VideoJuego() {

	}

	public VideoJuego(String nombre, String categoria, int anioCreacion) {
		this.nombre = nombre;
		this.categoria = categoria;

		this.anioCreacion = anioCreacion;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getCategoria() {
		return categoria;
	}

	public void setCategoria(String categoria) {
		this.categoria = categoria;
	}

	public int getAnioCreacion() {
		return anioCreacion;
	}

	public void setAnioCreacion(int anioCreacion) {
		this.anioCreacion = anioCreacion;
	}

	public void mostrar() {
		System.out.println("Nombre: " + nombre + " Categoria: " + categoria
				+ " AñoCreacion: " + anioCreacion);
	}
}
