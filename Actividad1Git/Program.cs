using Actividad1Git;
public class Main
{
    public static void main(string[] args)
    {
        Persona persona = new Persona("Angel", 10);
        persona.esMayorEdad();


        persona.SetEdad(20);
        persona.SetNombre("Marcos");
    }
}