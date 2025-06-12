internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejercicio 1:
         * Una empresa que se dedica al cultivo de tomate le solicita un programa en el cual debe ingresar y 
         * se debe imprimir en pantalla un texto de acuerdo con la siguiente tabla:
         * Mes de Inicio	Mes de Fin	    Actividad
         * Noviembre	    Noviembre	    Limpieza de la tierra.
         * Febrero	        Febrero	        Siembra de tomate.
         * Abril	        Abril	        Cultivo de tomate.
         * Junio 	        Junio	        Regar abono.
         * Octubre	        Octubre	        Dejar descansar la tierra.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 1--------------------");
        Console.ResetColor();

        Console.Write("Ingrese el mes de inicio (Noviembre, Febrero, Abril, Junio, Octubre): ");
        string mes = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        switch (mes)
        {
            case "noviembre":
                Console.WriteLine("Limpieza de la tierra.");
                break;
            case "febrero":
                Console.WriteLine("Siembra de tomate.");
                break;
            case "abril":
                Console.WriteLine("Cultivo de tomate.");
                break;
            case "junio":
                Console.WriteLine("Regar abono.");
                break;
            case "octubre":
                Console.WriteLine("Dejar descansar la tierra.");
                break;
            default:
                Console.WriteLine("Mes no válido o sin actividad registrada.");
                break;
        }


        /*
         * Ejercicio 2:
         * Realiza un programa en C#, que muestre los primeros 100 números enteros iniciando desde el 1.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 2--------------------");
        Console.ResetColor();

        Console.WriteLine("Primeros 100 números enteros iniciando desde el 1:");
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
        }

        /*
         * Ejercicio 3:
         * Realiza un programa en C#, que muestre la suma de los números impares del 1 al 100.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 3--------------------");
        Console.ResetColor();

        int sumaImpares = 0;
        
        for (int i = 1; i <= 100; i+=2)
        {
            sumaImpares += i;
        }

        Console.WriteLine("Suma de los números impares del 1 al 100: " + sumaImpares);


        /*
         * Ejercicio 4:
         * Realiza un programa en C#, que muestre un menú en pantalla con las opciones:
         *  Sumar
         *  Restar
         *  Multiplicar
         *  Dividir
         *  Salir
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejercicio 4--------------------");
        Console.ResetColor();

        int opcion, numero1 = 0, numero2 = 0;
        do {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------");
            Console.ResetColor();

            Console.WriteLine("Menú de operaciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine(">5. Salir");

            Console.Write("Seleccione una opción (1-5): ");
            opcion = int.Parse(Console.ReadLine()?.Trim() ?? "0");

            if(opcion >= 1 && opcion < 5)
            {
                Console.Write("\nIngrese el primer número: ");
                numero1 = int.Parse(Console.ReadLine()?.Trim() ?? "0");
                Console.Write("Ingrese el segundo número: ");
                numero2 = int.Parse(Console.ReadLine()?.Trim() ?? "0");
            }


            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {numero1 * numero2}");
                    break;
                case 4:
                    if (numero2 != 0)
                        Console.WriteLine($"Resultado de la división: {numero1 / (double)numero2}");
                    else
                        Console.WriteLine("Error: División por cero no permitida.");
                    break;
                default:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }

        } while (opcion < 5);


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}