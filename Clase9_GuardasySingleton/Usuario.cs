public class Usuario
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Usuario(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

