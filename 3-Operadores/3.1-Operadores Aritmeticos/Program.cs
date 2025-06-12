internal class Program
{
    private static void Main(string[] args)
    {
        // Concatenar
        string firstName = "Alejandro";
        string lastName = "Gonzalez";
        string fullName = firstName + " " + lastName; // = $"{firstName} {lastName}";
        Console.WriteLine($"Full Name: {fullName}"); // Output: Full Name: Alejandro Gonzalez

        // No se convierten strings a enteros automáticamente, pero si se suman numeros
        Console.WriteLine(10 + 20); // Salida: 30 (suma de enteros)
        Console.WriteLine("5" + 10); // Salida: 510 (concatenacion, no suma)
        Console.WriteLine('5' + 10); // Salida: 63 (char '5' es 53 en ASCII, suma 10 da 63)


        // Recibir un dato en consola
        Console.Write("Ingresa un numero: ");
        int number = Convert.ToInt32(Console.ReadLine()); // Convierte el input a entero
        Console.Write("Ingresa otro numero: ");
        int number2 = int.Parse(Console.ReadLine() ?? "1"); // Convierte el input a entero, si no se ingresa nada, usa 1 por defecto

        // Operadores aritmeticos
        Console.WriteLine($"Suma: {number + number2}"); // Muestra la suma de los dos numeros ingresados
        Console.WriteLine($"Resta: {number - number2}"); // Muestra la resta de los dos numeros ingresados
        Console.WriteLine($"Multiplicacion: {number * number2}"); // Muestra la multiplicacion de los dos numeros ingresados
        Console.WriteLine($"Division: {number / number2}"); // Muestra la division de los dos numeros ingresados
        Console.WriteLine($"Modulo: {number % number2}"); // Muestra el modulo (residuo de division) de los dos numeros ingresados

        OperadorMath(number, number2);

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }

    private static void OperadorMath(int number, int number2)
    {
        // Operador Math
        Console.WriteLine("Operador Math:");
        Console.WriteLine($"Raiz cuadrada de {number}: {Math.Sqrt(number)}"); // Muestra la raiz cuadrada del primer numero ingresado
        Console.WriteLine($"Potencia {number}^{number2}: {Math.Pow(number, number2)}"); // Muestra la potencia de los dos numeros ingresados
        Console.WriteLine($"Valor absoluto de {number}: {Math.Abs(number)}"); // Muestra el valor absoluto del primer numero ingresado
        Console.WriteLine($"Numero mayor entre {number} y {number2}: {Math.Max(number, number2)}"); // Muestra el numero mayor entre los dos ingresados
        Console.WriteLine($"Numero menor entre {number} y {number2}: {Math.Min(number, number2)}"); // Muestra el numero menor entre los dos ingresados
        Console.WriteLine($"Numero aleatorio entre 1 y 100: {new Random().Next(1, 101)}"); // Muestra un numero aleatorio entre 1 y 100
        Console.WriteLine($"Logaritmo base 10 de {number}: {Math.Log10(number)}"); // Muestra el logaritmo base 10 del primer numero ingresado
        Console.WriteLine($"Logaritmo natural de {number}: {Math.Log(number)}"); // Muestra el logaritmo natural del primer numero ingresado
        Console.WriteLine($"Exponencial de {number} (e^{number}): {Math.Exp(number)}"); // Muestra el exponencial del primer numero ingresado
        Console.WriteLine($"Seno de {number} radianes: {Math.Sin(number)}"); // Muestra el seno del primer numero ingresado (en radianes)
        Console.WriteLine($"Coseno de {number} radianes: {Math.Cos(number)}"); // Muestra el coseno del primer numero ingresado (en radianes)
        Console.WriteLine($"Tangente de {number} radianes: {Math.Tan(number)}"); // Muestra la tangente del primer numero ingresado (en radianes)
        Console.WriteLine($"Arco seno de {number}: {Math.Asin(number)}"); // Muestra el arco seno del primer numero ingresado
        Console.WriteLine($"Arco coseno de {number}: {Math.Acos(number)}"); // Muestra el arco coseno del primer numero ingresado
        Console.WriteLine($"Arco tangente de {number}: {Math.Atan(number)}"); // Muestra el arco tangente del primer numero ingresado
    }
}