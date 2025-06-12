internal class Program
{
    private static void Main(string[] args)
    {

        /*
         * Ejercicio 1:
         * Una empresa constructora le solicita un programa en el que pueda validar si ya ha hecho los planos antes de empezar a construir.
         * El programa debe consultar si ya se hicieron, si es así se debe imprimir en pantalla 
         * “Puede construir”, si no debe imprimir “Solicite los planos”.
         * */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------Ejercicio 1--------------------");
        Console.ResetColor();

        string? estanLosPlanos;
        Console.Write("Los planos estan listos para contruir? (s/n) ");
        estanLosPlanos = Console.ReadLine();
        Console.WriteLine(estanLosPlanos == "s"
            ? "Puede construir"
            : "Solicite los planos");


        /*
         * Ejercicio 2:
         * Una empresa que se dedica a vender computadoras le solicita un programa en 
         * el que se debe solicitar el porcentaje de batería de alguna computadora próxima a vender,
         * si esta es mayor al 15% se debe imprimir en pantalla “Se puede vender”, sino debe imprimir “Cargue la batería para venderla”.
         * */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------Ejercicio 2--------------------");
        Console.ResetColor();

        int bateria;
        Console.Write("Ingrese porcentaje de bateria de la computadora a vender: ");
        bateria = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((bateria > 100 || bateria < 0)
            ? "Porcentaje invalido (0 - 100)"
            : bateria <= 15
                ? "Cargue la batería para venderla"
                : "Se puede vender");


        /*
         * Ejercicio 3:
         * Un vivero le solicita un programa en el que debe ingresar si ya se regaron todas las plantas debe imprimir 
         * “Puede retirarse”, sino debe imprimir “Debe regar las plantas”.
         * */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------Ejercicio 3--------------------");
        Console.ResetColor();

        string? seRegaronPlantas;
        Console.Write("Ya se han regado todas las plantas? (s/n) ");
        seRegaronPlantas = Console.ReadLine();
        Console.WriteLine(seRegaronPlantas == "s"
            ? "Puede retirarse"
            : "Debe regar las plantas");

        /*
         * Ejercicio 4:
         * Una empresa que se dedica al cultivo de tomate le solicita un programa en el cual debe ingresar y 
         * se debe imprimir en pantalla un texto de acuerdo con la siguiente tabla:
         * Mes de Inicio   Mes de Fin      Actividad
         * Diciembre       Enero           Limpieza de la tierra.
         * Febrero         Marzo           Siembra de tomate.
         * Abril           Mayo            Cultivo de tomate.
         * Junio           Septiembre      Regar abono.
         * Octubre         Noviembre       Dejar descansar la tierra.
         * */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------Ejercicio 4--------------------");
        Console.ResetColor();

        DateTime dateNow = DateTime.Now;
        Console.WriteLine($"Fecha: {dateNow.ToString("f")}");
        int month = dateNow.Month;

        if (month >= 12 || month <= 1)
            Console.WriteLine("Limpieza de la tierra");
        else if (month <= 3)
            Console.WriteLine("Siembra de tomate");
        else if (month <= 5)
            Console.WriteLine("Cultivo de tomate");
        else if (month <= 9)
            Console.WriteLine("Regar abono");
        else
            Console.WriteLine("Dejar descansar la tierra");


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}