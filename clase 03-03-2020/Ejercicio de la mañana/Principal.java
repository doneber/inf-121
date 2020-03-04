
public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Biblioteca b = new Biblioteca();
		Libro l1 = new Libro("php", "flores", 80.5);
		Libro l2 = new Libro("html", "Rojo", 50);
		
		b.mostrar();
		l1.mostrar();
		l2.mostrar();
		
		//b)
		System.out.println("\ntotal Lib =" + b.contarLibAutor("perez"));
		
		
		//d)
		System.out.println("Preciop total = " + b.precioTotal("perez"));		
		
	}

}
