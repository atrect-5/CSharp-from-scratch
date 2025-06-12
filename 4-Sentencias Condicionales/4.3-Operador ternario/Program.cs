internal class Program
{
    private static void Main(string[] args)
    {
        const int NM = 60;
        int nota = 20;
        string resultado = "";
        // Depende de la condicion, se le asigna el valor a resultado <condicion> ? <si> : <no>
        resultado = nota < NM ? "Reprobo la clase" : "Aprobo la clase";

        Console.WriteLine(resultado);

        string variable = null;
        // Si variable es null, se escribira el texto siguiente, si no es null, se escribira el valor de variable
        Console.WriteLine(variable ?? "La variable es null");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}