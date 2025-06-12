internal class Program
{
    private static void Main(string[] args)
    {

        /*
         * Ejemplo 1:
         * Se ingresa la edad de una persona para saber si es mayor de edad
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();
        int edad;
        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Eres mayor de edad");
        else
            Console.WriteLine("Eres menor de edad");


        /*
         * Ejemplo 2:
         * Se debe verificar la temperatura de una persona para saber si no tiene fiebre
         * Y se debe verificar si uso gel antibacterial para poder ingresar al establecimiento
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();
        const int TN = 37; // Temperatura Normal
        double temperatura;
        string? gel;

        Console.Write("Ingrese la temperatura (°C): ");
        temperatura = Convert.ToDouble(Console.ReadLine());
        Console.Write("¿Usó gel antibacterial? (s/n): ");
        gel = Console.ReadLine()?.ToLower();

        if (gel == "s" && temperatura <= TN)
        {
            Console.WriteLine("Puede ingresar al establecimiento.");
        }
        else
        {
            Console.WriteLine("No puede ingresar al establecimiento.");
        }


        /*
         * Ejemplo 3:
         * El maestro de una clase debe poner una nota a un alumno, si es mayor a 70, el alumno paso la clase
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();
        const int NM = 70, NMA = 100; // Nota minima | Nota maxima
        double nota;

        Console.Write("Ingrese la nota del alumno: ");
        nota = Convert.ToDouble(Console.ReadLine());

        if ( 0 > nota || nota > NMA)
        {
            Console.WriteLine("Nota invalida (Entre 0 y 100)");
        }
        else if (nota >= NM)
        {
            Console.WriteLine("El alumno aprobó la clase.");
        }
        else
        {
            Console.WriteLine("El alumno reprobo la clase");
        }


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}