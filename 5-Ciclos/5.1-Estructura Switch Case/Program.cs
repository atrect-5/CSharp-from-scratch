internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * se imprime el dia de la semana según el número ingresado por el usuario.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        int dia;
        Console.Write("Ingrese el número del día de la semana (1-7): ");
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Día no válido");
                break;
        }


        /*
         * Ejemplo 2:
         * Una empresa quiere mostrar un mensaje según el cargo del empleado.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        string? rol = "", nombre = "";
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese su rol (admin, recepcion, operario): ");
        rol = Console.ReadLine()?.ToLower();

        switch (rol)
        {
            case "admin":
                Console.WriteLine($"Hola {nombre}, tienes acceso a todas las funciones del sistema.");
                break;
            case "recepcion":
                Console.WriteLine($"Hola {nombre}, tienes acceso a las funciones de recepción.");
                break;
            case "operario":
                Console.WriteLine($"Hola {nombre}, tienes acceso a las funciones de operario.");
                break;
            default:
                Console.WriteLine($"Hola {nombre}, no tienes acceso a ninguna función del sistema.");
                break;
        }

        /*
        * Ejemplo 3:
        * 
        */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        string?  nombre2 = "";
        Console.Write("Ingrese su nombre: ");
        nombre2 = Console.ReadLine();

        int opcion = 0;
        Console.WriteLine("Menu del restaurante:");
        Console.WriteLine("1. Pizza");
        Console.WriteLine("2. Hamburguesa");
        Console.WriteLine("3. Ensalada");
        Console.WriteLine("4. Postre");
        Console.Write("Seleccione una opción (1-4): ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                Console.WriteLine($"El cliente {nombre2}, ha seleccionado Pizza.");
                break;
            case 2:
                Console.WriteLine($"El cliente {nombre2}, ha seleccionado Hamburguesa.");
                break;
            case 3:
                Console.WriteLine($"El cliente {nombre2}, ha seleccionado Ensalada.");
                break;
            case 4:
                Console.WriteLine($"El cliente {nombre2}, ha seleccionado Postre.");
                break;
            default:
                Console.WriteLine($"El cliente {nombre2}, debe escoger otro pedido.");
                break;
        }


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}