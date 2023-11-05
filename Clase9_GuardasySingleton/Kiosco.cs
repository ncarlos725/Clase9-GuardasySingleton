using Clase9_GuardasySingleton;

public class Kiosco
{
    private static Kiosco instance = null;
    private static object lockObject = new object();

    // Productos en el kiosco
    private List<Producto> productos = new List<Producto>();

    private Kiosco()
    {
        // Inicialización de productos
    }

    public static Kiosco Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Kiosco();
                }
                return instance;
            }
        }
    }

    public void Comprar(Usuario usuario, Producto producto)
    {
        
    }
}