internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * La tienda de Doña Rosa nos solicita un sistema en consola en el que pueda hacer el calculo del cambio que debe darle al cliente
         */
        double recibido, total, cambio;
        Console.WriteLine("--------------------Ejemplo 1--------------------");
        Console.Write("Monto pagado por el cliente: ");
        recibido = Convert.ToDouble(Console.ReadLine());
        Console.Write("Monto total de la compra: ");
        total = Convert.ToDouble(Console.ReadLine());

        cambio = recibido - total;
        if (cambio < 0)
        {
            Console.WriteLine("\nEl monto pagado es insuficiente para cubrir el total de la compra.");
        }
        else
        {
            Console.WriteLine($"\nEl cambio a entregar al cliente es: ${cambio}");
        }

        /*
         * Ejemplo 2:
         * La pasteleria Maria necesita un sistema en consola en el que pueda saber cuanto efectivo obtendra al momento de partir un pastel
         * en las unidades que la pasteleria le indique y vender cada unidad a un precio ingresado por la pasteleria 
         */
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        double unidades, precio, efectivo;
        Console.Write("Unidades en las que se parte el pastel: ");
        unidades = Convert.ToDouble(Console.ReadLine());
        Console.Write("Precio de cada unidad: ");
        precio = Convert.ToDouble(Console.ReadLine());

        efectivo = unidades * precio;
        Console.WriteLine($"\nEl efectivo obtenido por la venta del pastel es: ${efectivo}");

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}