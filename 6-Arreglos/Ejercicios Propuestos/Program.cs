using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Ejemplo 1:
         * Realizar un programa que guardar los sueldos de 5 operarios en un arreglo.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 1--------------------");
        Console.ResetColor();

        double[] sueldos = new double[5];

        Console.WriteLine("Ingrese los sueldos de 5 operarios:");
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.Write($"Ingrese el sueldo del operario {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out sueldos[i]) || sueldos[i] < 0) // Si se ingresa un valor no numérico o negativo, se solicita nuevamente
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada inválida. Ingrese un sueldo válido: ");
                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("\nSueldos ingresados:");
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.WriteLine($"Operario {i + 1}: {sueldos[i]:C}");
        }


        /*
         * Ejemplo 2:
         * Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados 
         * (4 por la mañana y 4 por la tarde). Desarrollar un programa que permita almacenar 
         * los sueldos de los empleados agrupados por turno.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 2--------------------");
        Console.ResetColor();

        double[,] sueldosTurnos = new double[2, 4]; // 2 turnos, 4 empleados por turno

        string[] turnos = { "Mañana", "Tarde" };
        Console.WriteLine("Ingrese los sueldos de los empleados por turno:");
        for (int turno = 0; turno < sueldosTurnos.GetLength(0); turno++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nTurno: {turnos[turno]}");
            Console.ResetColor();
            for (int empleado = 0; empleado < sueldosTurnos.GetLength(1); empleado++)
            {
                Console.Write($"Ingrese el sueldo del empleado {empleado + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out sueldosTurnos[turno, empleado]) || sueldosTurnos[turno, empleado] < 0) // Validación de entrada
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Entrada inválida. Ingrese un sueldo válido: ");
                    Console.ResetColor();
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("\nSueldos ingresados por turno:");
        for (int turno = 0; turno < sueldosTurnos.GetLength(0); turno++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nTurno: {turnos[turno]}");
            Console.ResetColor();
            for (int empleado = 0; empleado < sueldosTurnos.GetLength(1); empleado++)
            {
                Console.WriteLine($"Empleado {empleado + 1}: {sueldosTurnos[turno, empleado]:C}");
            }
        }


        /*
         * Ejemplo 3:
         * Se tienen las notas del primer parcial de los alumnos de dos cursos, Matemática y el Física, 
         * cada curso cuenta con 5 alumnos. Realizar un programa que muestre el curso que obtuvo el 
         * mayor promedio general.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 3--------------------");
        Console.ResetColor();

        double[,] notas = new double[2, 5]; // 2 cursos, 5 alumnos por curso
        double[] promedios = new double[2]; // Para almacenar el promedio de cada curso
        string[] cursos = { "Matemática", "Física" };

        Console.WriteLine("Ingrese las notas de los alumnos por curso:");
        for (int curso = 0; curso < notas.GetLength(0); curso++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nCurso: {cursos[curso]}");
            Console.ResetColor();
            for (int alumno = 0; alumno < notas.GetLength(1); alumno++)
            {
                Console.Write($"Ingrese la nota del alumno {alumno + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[curso, alumno]) || notas[curso, alumno] < 0 || notas[curso, alumno] > 10) // Validación de entrada
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Entrada inválida. Ingrese una nota válida (0-10): ");
                    Console.ResetColor();
                }
                promedios[curso] += notas[curso, alumno]; // Sumar las notas para calcular el promedio
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("\nPromedios por curso:");
        promedios[0] /= notas.GetLength(1); // Calcular el promedio de Matemática
        promedios[1] /= notas.GetLength(1); // Calcular el promedio de Física

        Console.WriteLine($"Matemática: {promedios[0]:F2}" + (promedios[0] > promedios[1] ? " <-- Este fue el curso con mejor promedio" : ""));
        Console.WriteLine($"Física: {promedios[1]:F2}" + (promedios[1] > promedios[0] ? " <-- Este fue el curso con mejor promedio" : ""));


        /*
         * Ejemplo 4:
         * Crear un programa en el que se pueda ingresar por pantalla los nombres, apellidos, edad y sexo de cinco clientes, 
         * emplee los tipos de datos arreglos.
         */
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\n--------------------Ejemplo 4--------------------");
        Console.ResetColor();

        string?[] nombres = new string[5];
        string?[] apellidos = new string[5];
        int[] edades = new int[5];
        char[] sexos = new char[5]; // 'M' para masculino, 'F' para femenino

        Console.WriteLine("Ingrese los datos de 5 clientes:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nCliente {i + 1}");
            Console.ResetColor();
            Console.Write($"Nombre: ");
            nombres[i] = Console.ReadLine() ?? string.Empty; // Manejo de entrada nula
            Console.Write($"Apellido: ");
            apellidos[i] = Console.ReadLine() ?? string.Empty; // Manejo de entrada nula
            Console.Write($"Edad: ");
            while (!int.TryParse(Console.ReadLine(), out edades[i]) || edades[i] < 0) // Validación de entrada
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada inválida. Ingrese una edad válida: ");
                Console.ResetColor();
            }
            Console.Write($"Sexo (M/F): ");
            while (!char.TryParse(Console.ReadLine()?.ToUpper(), out sexos[i]) || (sexos[i] != 'M' && sexos[i] != 'F')) // Validación de entrada
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada inválida. Ingrese 'M' o 'F': ");
                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n\n--------------------");
        Console.ResetColor();

        Console.WriteLine("Datos de los clientes ingresados:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Cliente {i + 1}: {nombres[i]} {apellidos[i]} | Edad: {edades[i]} | Sexo: {(sexos[i] == 'M' ? "Masculino" : "Femenino")}");
        }


        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}