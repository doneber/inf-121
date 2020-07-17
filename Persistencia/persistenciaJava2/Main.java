import java.io.FileNotFoundException;
import java.io.IOException;


public class Main {
	public static void main(String[] args) throws FileNotFoundException, IOException {
		ArchivoPersona ap = new ArchivoPersona("f://archPersona.txt");
		ap.crear();
		ap.listar();
	}
}
