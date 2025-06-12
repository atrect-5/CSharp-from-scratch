internal class Program
{
    private static void Main(string[] args)
    {
        // Operadores relacionales

        // < menor que
        // > mayor que
        // <= menor o igual que
        // >= mayor o igual que
        // == Igual que 
        // != diferente que

        bool x = 5 < 20; // true, 5 es menor que 20
        bool y = 5 > 20; // false, 5 no es mayor que 20
        bool z = 5 <= 20; // true, 5 es menor o igual que 20
        bool a = 5 >= 20; // false, 5 no es mayor o igual que 20
        bool b = 5 == 20; // false, 5 no es igual que 20
        bool c = 5 != 20; // true, 5 es diferente de 20

        bool e = 20 < 20; // false, 20 no es menor que 20
        bool f = 20 > 20; // false, 20 no es mayor que 20
        bool g = 20 <= 20; // true, 20 es menor o igual que 20
        bool h = 20 >= 20; // true, 20 es mayor o igual que 20

        // Operadores logicos

        // && AND lógico
        // || OR lógico
        // ! NOT lógico

        bool i = true && true; // true, ambas condiciones son verdaderas
        bool j = true && false; // false, una condicion es falsa

        bool k = true || false; // true, al menos una condición es verdadera
        bool l = false || false; // false, ni una sola condicion es verdadera

        bool m = !true; // false, se niega el true
        bool n = !false; // true, se niega el false

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}