import java.io.Serializable;
import java.util.Scanner;



public class Persona implements Serializable {
    private String nombre;
    private int ci;
    public Persona(){
        this.nombre="Jose";
        this.ci= 56778912;
    }
    public Persona(String nom, int ci){
        this.nombre= nom;
        this.ci= ci;
    }
    public void mostrar(){
        System.out.println("Nombre: "+ this.nombre);
        System.out.println("Ci: "+ this.ci);
    }
    public void leer(){
    	Scanner sc= new Scanner(System.in);
    	System.out.println("Nombre <String>:");
    	this.nombre = sc.nextLine();
    	System.out.println("CI <int>:");
    	this.ci = sc.nextInt();
    }
    public int getCi(){
        return this.ci;
    }
}