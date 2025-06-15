internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Estructura de un arreglo en C#.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        // Asignacion de un array manualmente
        string[] nombres = new string[4];
        nombres[0] = "Vicente"; // Los arreglos inician en la posicion 0
        nombres[1] = "María";
        nombres[2] = "Alejandro";
        nombres[3] = "Ana";

        string[] nombres2 = ["Vicente", "María", "Alejandro", "Ana"]; // Otras formas de asignar un array
        string[] nombres3 = new string[] { "Vicente", "María", "Alejandro", "Ana" }; 

        // se imprime el array completo (tambien se puede guardar la informacion en el arreglo de esa misma manera)
        Console.WriteLine("Array de nombres:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"nombres[{i}] = {nombres[i]}");
        }
        // Alternativamente, se puede usar un bucle foreach para recorrer el array elemento por elemento, en lugar de usar un indice.
        // foreach (string nombre in nombres)
        // {
        //     Console.WriteLine(nombre);
        // }

        /*
         * Ejemplo 2:
         * Un profesor quiere guardar las calificaciones de 10 alumnos en un arreglo y mostrar el promedio de las calificaciones ingresadas.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        int[] calificaciones = new int[10];
        int suma = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingrese la calificación del alumno {i + 1}: ");
            // Convertir la entrada del usuario a un entero y asignarlo al arreglo
            calificaciones[i] = int.Parse(Console.ReadLine() ?? "0");
            suma += calificaciones[i]; // Sumar la calificación al total
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("\nCalificaciones ingresadas:");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Alumno {i + 1}: {calificaciones[i]}");
        }
        Console.WriteLine($"Promedio de calificaciones: {suma / (double)calificaciones.Length}");

        /*
         * Ejemplo 3:
         * En una pizzeria se parten las pizzas en 8 partes y se quiere guardar el precio al que se vendio cada rebanada 
         * (ya que se venden a diferente precio), tambien se quiere saber cuanto se vendio en total.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        double[] preciosRebanadas = new double[8];
        double totalVendido = 0.0;

        for (int i = 0; i < preciosRebanadas.Length; i++)
        {
            Console.Write($"Ingrese el precio de la rebanada {i + 1}: ");
            // Convertir la entrada del usuario a un double y asignarlo al arreglo
            preciosRebanadas[i] = double.Parse(Console.ReadLine() ?? "0.0");
            totalVendido += preciosRebanadas[i]; // Sumar el precio al total vendido
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("\nPrecios de las rebanadas ingresados:");
        for (int i = 0; i < preciosRebanadas.Length; i++)
        {
            Console.WriteLine($"Rebanada {i + 1}: ${preciosRebanadas[i]:F2}");
        }
        Console.WriteLine("Total vendido: $" + totalVendido.ToString("F2"));


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}