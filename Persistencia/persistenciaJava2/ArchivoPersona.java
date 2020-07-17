import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;


public class ArchivoPersona {
	private String nombre;
	public ArchivoPersona(String nombre) {
		this.nombre = nombre;
	}
	public void crear() throws FileNotFoundException, IOException {
		ObjectOutputStream archivo = new ObjectOutputStream( new FileOutputStream(this.nombre) );
		archivo.close();
	}
	public void agregar() throws FileNotFoundException, IOException{
		File f1 = new File(this.nombre); 
		if(f1.exists()){
			ObjectOutputStream copiaArchivo = new ObjectOutputStream( new FileOutputStream("archivoCopia.txt") );
			ObjectInputStream archivo = new ObjectInputStream(new FileInputStream(this.nombre));

			try {
				while(true){
					Persona p = (Persona)archivo.readObject();
					copiaArchivo.writeObject(p);
				}
			} catch (Exception e) {
				Persona nuevaPersona = new Persona();
				nuevaPersona.leer();
				copiaArchivo.writeObject(nuevaPersona);
				
				copiaArchivo.close();
				archivo.close();
				
				
				File f2 = new File("archivoCopia.txt");
				f1.delete();
				f2.renameTo(f1);
				System.out.println("Agregado.");
			}
		}else{
			System.out.println("El archivo no existe");
		}
	}
	public void listar() throws FileNotFoundException, IOException{
		ObjectOutputStream copiaArchivo = new ObjectOutputStream( new FileOutputStream("archivoCopia.txt") );
		ObjectInputStream archivo = new ObjectInputStream(new FileInputStream(this.nombre));
		
		try {
			while(true){
				Persona p = (Persona)archivo.readObject();
				p.mostrar();
				copiaArchivo.writeObject(p);
			}
		} catch (Exception e) {
			copiaArchivo.close();
			archivo.close();
			
			File f1 = new File(this.nombre); 
			File f2 = new File("archivoCopia.txt");
			f1.delete();
			f2.renameTo(f1);
		}
	}
	public void eliminar(int ci) throws FileNotFoundException, IOException{
		ObjectOutputStream copiaArchivo = new ObjectOutputStream( new FileOutputStream("archivoCopia.txt") );
		ObjectInputStream archivo = new ObjectInputStream(new FileInputStream(this.nombre));
		
		try {
			while(true){
				Persona p = (Persona)archivo.readObject();
				if(p.getCi() != ci)
					copiaArchivo.writeObject(p);
			}
		} catch (Exception e) {
			copiaArchivo.close();
			archivo.close();
			
			File f1 = new File(this.nombre); 
			File f2 = new File("archivoCopia.txt");
			f1.delete();
			f2.renameTo(f1);
		}
	}
}
