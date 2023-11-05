using System;
using System.Collections.Generic;
using System.Threading;

namespace Clase9_GuardasySingleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crea un kiosco como Singleton
            Kiosco kiosco = Kiosco.Instance;

            // Carga productos en el kiosco
            Producto gaseosa = new Producto("Gaseosa", 2.5, 10, false, false);
            Producto cerveza = new Producto("Cerveza", 3.5, 5, false, true);

            // Crea usuarios
            Usuario carlos = new Usuario("Carlos", 22);
            Usuario ana = new Usuario("Ana", 17);

            // Crea hilos para simular compras simultáneas
            Thread threadCarlosGaseosa = new Thread(() => kiosco.Comprar(carlos, gaseosa));
            Thread threadAnaGaseosa = new Thread(() => kiosco.Comprar(ana, gaseosa));
            Thread threadCarlosCerveza = new Thread(() => kiosco.Comprar(carlos, cerveza));
            Thread threadAnaCerveza = new Thread(() => kiosco.Comprar(ana, cerveza));

            // Inicia los hilos
            threadCarlosGaseosa.Start();
            threadAnaGaseosa.Start();
            threadCarlosCerveza.Start();
            threadAnaCerveza.Start();

            // Espera a que todos los hilos finalicen
            threadCarlosGaseosa.Join();
            threadAnaGaseosa.Join();
            threadCarlosCerveza.Join();
            threadAnaCerveza.Join();

            // Mostrar el estado final de los productos
            Console.WriteLine("Estado final de los productos:");
            Console.WriteLine(gaseosa);
            Console.WriteLine(cerveza);
        }
    }
}
   
    

