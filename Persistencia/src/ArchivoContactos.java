import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;


public class ArchivoContactos {
	private String nombre;
	public ArchivoContactos(String nombre){
		this.nombre = nombre;
	}
	
	public void crear() throws IOException{
		FileOutputStream fos = new FileOutputStream(this.nombre);
		ObjectOutputStream archivo = new ObjectOutputStream(fos);
		archivo.close();
		System.out.println("Archivo creado exitosamente");
	}
	public void adicionar() throws IOException{
		FileOutputStream fos = new FileOutputStream("copiaContactos.txt");
		FileInputStream fis = new FileInputStream(this.nombre);
		ObjectOutputStream copia = new ObjectOutputStream(fos);
		ObjectInputStream archivo = new ObjectInputStream(fis);
		try {
			while(true){
				String contacto = (String) archivo.readObject();
				copia.writeObject(contacto);
			}
		} catch (Exception e) {
			Scanner sc = new Scanner(System.in);
			String nuevoContacto = sc.nextLine();
			copia.writeObject(nuevoContacto);
			copia.close();
			archivo.close();
			
			File fArchivo = new File(this.nombre);
			File fCopia = new File("copiaContactos.txt");
			fArchivo.delete();
			fCopia.renameTo(fArchivo);
			
			
		}
	}
	public void listar() throws IOException{
		FileOutputStream fos = new FileOutputStream("copiaContactos.txt");
		FileInputStream fis = new FileInputStream(this.nombre);
		ObjectOutputStream copia = new ObjectOutputStream(fos);
		ObjectInputStream archivo = new ObjectInputStream(fis);
		try {
			while(true){
				String contacto = (String) archivo.readObject();
				System.out.println(contacto);
				copia.writeObject(contacto);
			}
		} catch (Exception e) {
			copia.close();
			archivo.close();
			
			File fArchivo = new File(this.nombre);
			File fCopia = new File("copiaContactos.txt");
			fArchivo.delete();
			fCopia.renameTo(fArchivo);
			
			
		}
	}
}
