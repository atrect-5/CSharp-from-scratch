internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Un colegio pide un sistema que le indique al profesor el tipo de nota que tuvo un alumno
         * 100 - 80 : Excelente Nota
         *  79 - 60 : Buena Nota
         *  59 - 30 : Nota Reprobatoria
         *  29 - 0  : Mala nota
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        const double EN = 100, BN = 79, NR = 59, MN = 29;
        double nota;
        Console.Write("Ingrese la nota: ");
        nota = Convert.ToDouble(Console.ReadLine());

        if (nota < 0)
            Console.WriteLine("Nota invalida, debe ser mayor que 0");
        else if (nota <= MN)
            Console.WriteLine("Mala nota");
        else if (nota <= NR)
            Console.WriteLine("Nota reprobatoria");
        else if (nota <= BN)
            Console.WriteLine("Buena nota");
        else if (nota <= EN)
            Console.WriteLine("Excelente nota");
        else if (nota > EN)
            Console.WriteLine("Nota invalida, debe ser menor que 100");


        /*
         * Ejemplo 2:
         * Segun la hora:
         * 6:00 - 11:59 : Hora de desayuno
         * 12:00 - 17:59 : Hora de almuerzo
         * 18:00 - 23:59 : Hora de cena
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        DateTime dateNow = DateTime.Now; // Nos regresa la fecha actual dd/MM/yyyy HH:mm:ss
        Console.WriteLine(dateNow.ToString("f")); // Muestra la fecha en formato largo (ej. viernes, 20 de octubre de 2025 16:30)

        int hora = (int)dateNow.Hour;

        if (hora <= 23 && hora >= 18)
            Console.WriteLine("Hora de la cena");
        else if (hora >= 12)
            Console.WriteLine("Hora del almuerzo");
        else if (hora >= 6)
            Console.WriteLine("Hora del desayuno");
        else
            Console.WriteLine("Hora de dormir");


        /*
         * Ejemplo 3:
         * Un taller pide evaluar el kilometraje de una moto para aplicar un descuento al servicio
         * 0 - 100 : 75% de descuento
         * 101 - 1000 : 50% de descuento
         * 1001 - 5000 : 25% de descuento
         * > 5001 : Sin descuento
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        const int KM1 = 100, KM2 = 1000, KM3 = 5000;
        double kilometraje, precio;
        
        Console.Write("Ingrese el kilometraje de la moto: ");
        kilometraje = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el precio del servicio: ");
        precio = Convert.ToDouble(Console.ReadLine());

        if (kilometraje < 0)
        {
            Console.WriteLine("Kilometraje invalido, debe ser mayor que 0");
        } else if (kilometraje <= KM1)
            {
            precio *= 0.25;
            Console.WriteLine($"Descuento del 75%");
        }
        else if (kilometraje <= KM2)
        {
            precio *= 0.50;
            Console.WriteLine($"Descuento del 50%");
        }
        else if (kilometraje <= KM3)
        {
            precio *= 0.75;
            Console.WriteLine($"Descuento del 25%");
        }
        else
        {
            Console.WriteLine($"Sin descuento");
        }
        Console.WriteLine($"El precio final del servicio es: {precio:C2}"); // C2 para formato de moneda con 2 decimales


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}