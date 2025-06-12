internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Explicacion de un ciclo while
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        int n = 0;

        while (n <= 5)
        {
            Console.WriteLine($"El valor de 'n' es: {n}");
            n++;
        }

        /*
         * Ejemplo 2:
         * Una empresa pide hacer un menu, y al seleccionar 3 o mas, debe salir del ciclo
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        int opcion = 0;

        while (opcion < 3)
        {
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Opcion 1");
            Console.WriteLine("2. Opcion 2");
            Console.WriteLine("3. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado la Opcion 1.");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado la Opcion 2.");
                    break;
                default:
                    Console.WriteLine("Saliendo del menu...");
                    break;
            }
        }

        /*
         * Ejemplo 3:
         * Contador de cuantos alumnos se ingresaron
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        int contador = 0;
        string? alumno = "";

        while (alumno?.ToLower() != "salir") {
            Console.Write("Nombre del alumno ('salir' para terminar): ");
            alumno = Console.ReadLine();
            contador++;
            Console.WriteLine(alumno?.ToLower() != "salir" ? $"Alumno #{contador}: {alumno}\n" : "");
        }
        Console.WriteLine($"\nTotal de alumnos ingresados: {contador - 1}"); // Restamos 1 para no contar el 'salir'

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}