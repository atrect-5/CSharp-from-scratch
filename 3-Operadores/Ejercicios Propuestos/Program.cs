internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejercicio 1:
         * Un colegio le solicita a usted como programador en C#, un sistema en el que pueda calcular el promedio de un alumno. 
         * El maestro debe ingresar 4 notas, debe recordar que la fórmula de promedio es: (num1 + num2 + num3 + num4) / 4.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------Ejercicio 1--------------------");
        Console.ResetColor();

        double nota1, nota2, nota3, nota4;
        Console.Write("Ingrese la primer nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la tercer nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la cuarta nota: ");
        nota4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El promedio del alumno es: {(nota1 + nota2 + nota3 + nota4) / 4}");

        /*
         * Ejercicio 2:
         * Una pastelería que en todos sus pasteles coloca la edad de la persona que cumple años, le solicita un programa en 
         * el que se pueda calcular la edad de la persona, solamente ingresando el año actual y el año de nacimiento.
         */

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 2--------------------");
        Console.ResetColor();

        int anioActual, anioNacimiento;
        Console.Write("Ingrese el año actual: ");
        anioActual = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el año de nacimiento: ");
        anioNacimiento = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"La edad de la persona es: {anioActual - anioNacimiento} años");

        /*
         * Ejercicio 3:
         * Un supermercado le solicita a usted un programa en consola para llevar control de una promoción que se acaba de lanzar. 
         * Si el código de identificación del producto es par se llevará el 50% de descuento.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 3--------------------");
        Console.ResetColor();

        int condigoProducto;
        double precioProducto;
        Console.Write("Ingrese el código del producto: ");
        condigoProducto = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el precio del producto: $");
        precioProducto = Convert.ToDouble(Console.ReadLine());

        bool esPar = (condigoProducto % 2) == 0;
        if (esPar)
        {
            precioProducto /= 2; // Se corta a la mitad el precio
            Console.WriteLine("Descuento de 50% aplicado");
        }

        Console.WriteLine("El precio del producto es: " + precioProducto.ToString("C2"));

        /*
         * Ejercicio 4:
         * Industrias Nipleras es una empresa agricultora, el cual tiene 100 trabajadores y le solicita un programa para dividir 
         * los 1000m2  entre los trabajadores y por cada metro se le pagarán $30, el programa debe calcular cuántos m2 le tocan 
         * a cada trabajador y mostrar el total a devengar al finalizar el trabajo.
         */
        Console.ForegroundColor= ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 4--------------------");
        Console.ResetColor();

        const int trabajadores = 100;
        const int metrosCuadrados = 1000;
        const double pagoPorMetro = 30.0;
        double metrosPorTrabajador = (double)metrosCuadrados / trabajadores;
        double totalAPagar = metrosPorTrabajador * pagoPorMetro;
        Console.WriteLine($"Se dividirán {metrosCuadrados} m2 entre {trabajadores} trabajadores, pagando {pagoPorMetro.ToString("C2")} por m2.");
        Console.WriteLine($"Cada trabajador recibirá {metrosPorTrabajador} m2 y un total de {totalAPagar.ToString("C2")} al finalizar el trabajo.");

        Console.ForegroundColor= ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}