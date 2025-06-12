internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Explicacion de ciclo for
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"Iteración {i} del ciclo for");
        }

        /*
         * Ejemplo 2:
         * Se mostrara la hora, minutos y segungos 'n' cantidad de veces segun el usuario elija
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        int cantidad = 0;
        Console.WriteLine("Ingrese la cantidad de cantidad de veces que se repetira el ciclo");
        cantidad = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        /*
         * Ejemplo 3:
         * Ciclo For, usando decremento para ver los pares del 10 al 0
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        for (int i = 10; i >= 0; i-=2)
        {
            Console.WriteLine($"Iteración {i} del ciclo for con decremento");
        }


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}