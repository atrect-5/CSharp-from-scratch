internal class Program
{
    // Constante gobal
    const double PIGLOBAL = 3.1416;
    private static void Main(string[] args)
    {
        /*
         * Variables en C#
         * 
         * Pasos:
         * definir el tipo de dato
         * definir el nombre de la variable (no puede empezar con un número, no puede contener espacios ni caracteres especiales excepto _)
         * definir el valor de la variable (opcional, se puede hacer después)
         * */
        // Constantes
        const double PI = 3.1416;
        Console.WriteLine("El valor de PI es: " + PI); // El valor de PI es: 3.1416
        OtroMetodo(); // Llamamos a OtroMetodo donde se imprime el valor de PIGLOBAL

        // Variables
        double radio = 5.0; // Variable de tipo double
        radio += 3.0; // Incrementamos el valor de radio en 3.0
        Console.WriteLine("El valor de radio es: " + radio); // El valor de radio es: 8

        int numero1, numero2 = 15; // Se crean las variables numero1 y numero2 de tipo entero, se inicializa numero2 con 15
        numero1 = 5; // Se le asigna el valor despues de crearse
        Console.WriteLine("El valor de numero1 es: " + numero1); // El valor de numero es: 5
        Console.WriteLine("El valor de numero2 es: " + numero2); // El valor de numero2 es: 15

        int numero3, numero4; // Se crean las variables numero3 y numero4 de tipo entero
        numero3 = numero4 = 10; // Se les asigna el valor de 10 a ambas variables
        Console.WriteLine("El valor de numero3 es: " + numero3); // El valor de numero3 es: 10
        Console.WriteLine("El valor de numero4 es: " + numero4); // El valor de numero4 es: 10


        ///////////////// Tipos de datos /////////////////
        /// Variables numericas
        // byte (Puede almacenar valores entre 0 y 255) (tamano: 1 byte)
        byte variableByte = 0; // Asignamos el valor 
        variableByte = 255; // Asignamos el valor máximo

        // sbyte (Puede almacenar valores entre -128 y 127) (tamano: 1 byte) (signed byte)
        sbyte variableSByte = -128; // Asignamos el valor mínimo
        variableSByte = 127; // Asignamos el valor máximo


        // short (Puede almacenar valores entre -32,768 y 32,767) (tamano: 2 bytes)
        short variableShort = -32768; // Asignamos el valor mínimo
        variableShort = 32767; // Asignamos el valor máximo

        // ushort (Puede almacenar valores entre 0 y 65,535) (tamano: 2 bytes) (unsigned short)
        ushort variableUShort = 0; // Asignamos el valor mínimo
        variableUShort = 65535; // Asignamos el valor máximo


        // int (Puede almacenar valores entre -2,147,483,648 y 2,147,483,647) (tamano: 4 bytes)
        int variableInt = -2147483648; // Asignamos el valor mínimo
        variableInt = 2147483647; // Asignamos el valor máximo

        // uint (Puede almacenar valores entre 0 y 4,294,967,295) (tamano: 4 bytes) (unsigned int)
        variableInt = 0; // Asignamos el valor mínimo
        uint variableUInt = 4294967295; // Asignamos el valor máximo


        // long (Puede almacenar valores entre -9,223,372,036,854,775,808 y 9,223,372,036,854,775,807) (tamano: 8 bytes)
        long variableLong = -9223372036854775808; // Asignamos el valor mínimo
        variableLong = 9223372036854775807; // Asignamos el valor máximo

        // ulong (Puede almacenar valores entre 0 y 18,446,744,073,709,551,615) (tamano: 8 bytes) (unsigned long)
        ulong variableULong = 0; // Asignamos el valor mínimo
        variableULong = 18446744073709551615; // Asignamos el valor máximo


        // float (Puede almacenar valores entre -3.402823E+38 y 3.402823E+38) (tamano: 4 bytes) (Puede almacenar decimales con presicion de 7 decimales)
        float variableFloat = 3.1415927f; // 7 decimales de precisión

        // double (Puede almacenar valores entre -1.7976931348623157E+308 y 1.7976931348623157E+308) (tamano: 8 bytes) (Puede almacenar decimales con presicion de 15-16 decimales)
        double variableDouble = 3.141592653589793; // 15-16 decimales de precisión

        // decimal (Puede almacenar valores entre -79,228,162,514,264,337,593,543,950,335 y 79,228,162,514,264,337,593,543,950,335) (tamano: 16 bytes) (Puede almacenar decimales con presicion de 28-29 decimales)
        decimal variableDecimal = 3.1415926535897932384626433832m; // 28-29 decimales de precisión

        
        /// Variable booleana
        // boolean (Puede almacenar valores true o false) (tamano: 1 byte) (Debido a que C# es de tipado fuerte, solo adite true o false y no 0 ni 1)
        bool variableBool = true; // Asignamos el valor true

        /// Variables de texto
        // char (Puede almacenar un solo caracter) (tamano: 2 bytes) (Unicode) (Se usa con comillas simples -> ') 
        char variableChar = 'A'; // Asignamos el valor A
        char variableChar2 = '%'; // Asignamos el valor %

        // string (Puede almacenar una cadena de caracteres) (tamano: variable) (Unicode) (Se usa con comillas dobles -> ")
        string variableString = "Hola, mundo!"; // Asignamos el valor Hola, mundo!

        /// Variables de fecha y hora
        // DateTime (Puede almacenar una fecha y hora) (tamano: 8 bytes)
        DateTime variableDateTime = DateTime.Now; // Asignamos el valor de la fecha y hora actual

        /// Variables dinamicas
        // dynamic (Puede almacenar cualquier tipo de dato) (tamano: variable) (Se usa cuando no se conoce el tipo de dato en tiempo de compilacion)
        dynamic variableDynamic = "Hola, mundo!"; // Asignamos el valor Hola, mundo!
        variableDynamic = 10; // Cambiamos el valor a un entero

        // var (Se usa cuando el tipo de dato se infiere en tiempo de compilacion) (tamano: variable)
        var variableVar = "Hola, mundo!"; // Asignamos el valor Hola, mundo!
        //variableVar = 10; // No se puede cambiar el tipo de dato, ya que se infiere en tiempo de compilacion

        /// Convirtiendo un tipo de dato a otro
        // Convertir de string a int
        string numeroComoString = "123";
        int suma = Convert.ToInt32(numeroComoString) + 100; // Convertimos el string a int
        Console.WriteLine("El numero convertido es: " + suma); // El numero convertido es: 223

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }

    public static void OtroMetodo()
    {
        //Console.WriteLine("El valor de PI es: " + PI); // Error, ya que PI solo existe en Main
        Console.WriteLine("El valor de PIGLOBAL es: " + PIGLOBAL); // El valor de PIGLOBAL es: 3.1416
    }
}