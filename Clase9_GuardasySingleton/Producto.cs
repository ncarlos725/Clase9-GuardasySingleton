public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public bool ParaMayorEdad { get; set; }
    public bool EsAlcohol { get; set; }

    public Producto(string nombre, double precio, int stock, bool paraMayorEdad, bool esAlcohol)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
        ParaMayorEdad = paraMayorEdad;
        EsAlcohol = esAlcohol;
    }

    public override string ToString()
    {
        return $"{Nombre}: Precio = ${Precio}, Stock = {Stock}, Para mayores de edad = {ParaMayorEdad}, Es alcohol = {EsAlcohol}";
    }
}