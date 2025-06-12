internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Explicacion de que le do while al menos se ejecuta 1 vez
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        bool x = false;
        do
        {
            Console.WriteLine($"Opcion = {x}"); // Este bloque se ejecuta al menos una vez
        }
        while (x);

        while (x)
        {
            Console.WriteLine($"Opcion = {x}"); // Este bloque no se ejecuta porque x es false
        }


        /*
         * Ejemplo 2:
         * Menu que aparece al menos una vez y se repite hasta que el usuario ingrese 3 o mas
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        int opcion = 0;
        do
        {
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Opcion 1");
            Console.WriteLine("2. Opcion 2");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese una opcion (1-3): ");
            
            opcion = int.Parse(Console.ReadLine() ?? "0"); // Leer la opcion del usuario
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado la Opcion 1.\n");
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado la Opcion 2.\n");
                    break;
                default:
                    Console.WriteLine("Saliendo del menu...");
                    break;
            }

        } while (opcion < 3); 


        /*
         * Ejemplo 3:
         * Contador de cuantos alumnos se ingresaron
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        int contador = 0;
        string? alumno;

        do
        {
            Console.Write("Nombre del alumno ('salir' para terminar): ");
            alumno = Console.ReadLine();
            contador++;
            Console.WriteLine(alumno?.ToLower() != "salir" ? $"Alumno #{contador}: {alumno}\n" : "");
        } while (alumno?.ToLower() != "salir");

        Console.WriteLine($"\nTotal de alumnos ingresados: {contador - 1}"); // Restamos 1 para no contar el 'salir'


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}