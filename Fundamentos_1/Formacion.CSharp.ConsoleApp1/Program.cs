﻿using Formacion.CSharp.ConsoleApp1.Models;

namespace Formacion.CSharp.ConsoleApp1;

/// <summary>
/// La clase Program contiene el método Main, donde inicia la ejecución del programa
/// </summary>
class Program
{
    /// <summary>
    /// Método Main, inicio del programa
    /// </summary>
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("".PadRight(56, '*'));
            Console.WriteLine("*  DEMO Y EJERCICIOS".PadRight(55) + "*");
            Console.WriteLine("".PadRight(56, '*'));
            Console.WriteLine("*".PadRight(55) + "*");
            Console.WriteLine("*  1. Declaración de Variables".PadRight(55) + "*");
            Console.WriteLine("*  2. Conversión de Variables".PadRight(55) + "*");
            Console.WriteLine("*  3. Sentencias de Control".PadRight(55) + "*");
            Console.WriteLine("*  4. Sentencias de Repetición".PadRight(55) + "*");
            Console.WriteLine("*  5. Control de Excepciones".PadRight(55) + "*");
            Console.WriteLine("*  9. Salir".PadRight(55) + "*");
            Console.WriteLine("*".PadRight(55) + "*");
            Console.WriteLine("".PadRight(56, '*'));

            Console.WriteLine(Environment.NewLine);
            Console.Write("   Opción: ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            int.TryParse(Console.ReadLine(), out int opcion);
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    DeclaracionVariables();
                    break;
                case 2:
                    Console.Clear();
                    ConversionVariables();
                    break;
                case 3:
                    Console.Clear();
                    SentenciasDeControl();
                    break;
                case 4:
                    Console.Clear();
                    SentenciasDeRepeticion();
                    break;
                case 5:
                    Console.Clear();
                    ControlDeExcepciones();
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Environment.NewLine + $"La opción {opcion} no es valida.");
                    break;
            }

            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Declaración de variables
    /// </summary>
    static void DeclaracionVariables()
    {
        ///////////////////////////////////////////////////////////////
        //
        //  Declaración de variables
        //  [tipo] [nombre variable] = [valor inicial (opcional)]
        //
        ///////////////////////////////////////////////////////////////

        string texto = "Hola Mundo !!!";
        string otroTexto;
        System.String texto2 = "Mi nombre es Aaron";

        int numero = 10;
        int otroNumero;
        System.Int32 numero2 = 0;

        decimal a, b, c;
        

        ///////////////////////////////////////////////////////////////
        //
        //  Declaración de variables que contienen objetos
        //  [tipo] [nombre variable] = [new constructor (opcional)]
        //
        ///////////////////////////////////////////////////////////////        

        // Instanciamos un objeto Alumno y posteriormente modificamos sus propiedades o variables
        Alumno alumno = new Alumno();
        alumno.Nombre = "Ana";
        alumno.Apellidos = "Sanz";
        alumno.Edad = 33;

        // Instanciamos un objeto Alumno y al mismo tiempo asignamos valores a sus propiedades o variables
        Alumno alumno1 = new Alumno()
        {
            Nombre = "Julian",
            Apellidos = "Sánchez",
            Edad = 25
        };


        ///////////////////////////////////////////////////////////////      
        //
        // Instaciamos un objeto Alumno usando VAR, OBJECT, DYNAMIC
        //
        ///////////////////////////////////////////////////////////////                

        // Las variables con tipo implícito VAR siempre deben inicializar
        var alumno2 = new Alumno();
        alumno2.Nombre = "María José";

        Console.WriteLine($"Tipo 2: {alumno2.GetType()}");
        Console.WriteLine($"Nombre 2: {alumno2.Nombre}" + Environment.NewLine);


        // OBJECT tiene la capacidad de contener cualquier tipo de dato
        // Comprobaciones de código en la etapa de diseño

        // Las variables de tipo OBJECT no permite acceder a los miembros del objeto
        // para accder tenemos que aplicar la conversión
        
        Object alumno3 = new Alumno();
        ((Alumno)alumno3).Nombre = "Isabel";
        // alumno3.Nombre = "Isabel"; <- No funciona por ser un Object

        Console.WriteLine($"Tipo 3: {alumno3.GetType()}");
        Console.WriteLine($"Nombre 3: {((Alumno)alumno3).Nombre}\n");
        // Console.WriteLine($"Nombre 3: {alumno3.Nombre}"); <- No funciona por ser un Object


        // dynamic tiene la capacidad de contener cualquier tipo de datos
        // Comprobaciones de código en ejecución, NO SE COMPRUEBA CUANDO COMPILAMOS
        dynamic alumno4 = new Alumno();
        alumno4.Nombre = "Antonio José";
        alumno4.Edad = 30;

        Console.WriteLine($"Tipo 4: {alumno4.GetType()}");
        Console.WriteLine($"Nombre 4: {alumno4.Nombre}" + Environment.NewLine);


        // Alternativas de sintaxis propio de las versiones más recientes de C# y .NET Core
        Alumno alumno5 = new();
        alumno5.Nombre = "Borja";

        Console.WriteLine($"Tipo 5: {alumno5.GetType()}");
        Console.WriteLine($"Nombre 5: {alumno5.Nombre}" + Environment.NewLine);


        ///////////////////////////////////////////////////////////////
        //
        //  Declaración de un Array
        //  [tipo][] [nombre variable] = [valor inicial]
        //
        ///////////////////////////////////////////////////////////////

        int[] numeros = new int[10];
        int[] numeros2 = { 10, 5, 345, 55, 13, 1000, 83 };

        numeros[7] = 32;
        Console.WriteLine(numeros2[5]);

        Alumno[] alumnos = new Alumno[20];
        alumnos[0] = new Alumno();
        alumnos[1] = new Alumno();

        Alumno[] alumnos2 = {
                new Alumno() { Nombre = "Julian", Apellidos = "Sánchez", Edad = 24 },
                new Alumno(),
                new Alumno()
            };

        Alumno[] alumnos3 = { new Alumno(), new Alumno(), new Alumno() };

        alumnos3[1].Nombre = "Ana María";
        alumnos3[1].Apellidos = "Sánchez";
        alumnos3[1].Edad = 24;
        Console.WriteLine(alumnos3[1].Nombre);
    }

    /// <summary>
    /// Conversión de variables
    /// </summary>
    static void ConversionVariables()
    {
        byte num1 = 10;         //  8 bits
        int num2 = 32;          // 32 bits
        string num3 = "42";     // bits variable según contenido

        Console.WriteLine($"Num 1 (byte): {num1} - Num 2 (int): {num2} - Num 3 (string): {num3}" + Environment.NewLine);

        // Conversión implicita, SI posible si el receptor es de mayor tamaño en bits
        num2 = num1;

        // Conversión implicita, NO es posible si el receptor es de menor tamaño en bits
        // No se puede convertir implícitamente el tipo 'int' en 'byte'.
        // num1 = num2;

        // La opción es una conversión explicita, indicada por el programador
        // Es valida si el valor esta comprendido entre los valores de la varible receptora
        num2 = 32;
        num1 = (byte)num2;

        // Conversión explicita, utilizando los métodos del objeto CONVERT
        // Para valores fuera del rango de la variable receptora genera una excepción
        num2 = 32;
        num1 = Convert.ToByte(num2);
        num1 = Convert.ToByte(num3);

        Console.WriteLine("Después de las conversiones");
        Console.WriteLine($"Num 1 (byte): {num1} - Num 2 (int): {num2} - Num 3 (string): {num3}\n");


        ///////////////////////////////////////////////////////////////                
        // Transformaciones de STRING a cualquier tipo de dato númerico
        ///////////////////////////////////////////////////////////////                

        // Utilizando los métodos del objeto CONVERT
        num1 = Convert.ToByte(num3);
        num2 = Convert.ToInt32(num3);

        // Conversión explicita, utilizando el método Parse
        num1 = byte.Parse(num3);

        // Conversión explicita, utilizando el método TryParse
        byte.TryParse(num3, out num1);

        // El método .TryParse retorna True/False dependiendo de si la transformación es posible
        // El resultao de la transformación de almacena en num4, siendo 0 si la tranformación no es posible
        num3 = "102";
        int num4;
        bool result = int.TryParse(num3, out num4);

        // En este ejemplo solo comprobamos si la transformación es posible.
        // Mediante [out _] indicamos que no queremos el resultado de la transformación  
        var esEntero = int.TryParse(num3, out _);

        Console.WriteLine($"Resultado: {result} - Valor Num 4: {num4}");
        Console.WriteLine($"Resultado Num 5: {esEntero}");
    }

    /// <summary>
    /// Sentencias de Control, uso de IF/ELSE y SWITCH
    /// </summary>
    static void SentenciasDeControl()
    {
        ///////////////////////////////////////////////////////////////
        //
        //  Sentencias de Control, uso de IF/ELSE y SWITCH
        //
        ///////////////////////////////////////////////////////////////
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;

        // Uso de IF/ELSE
        Reserva reserva = new Reserva();
        
        Console.Write("ID de la Reserva: ");
        reserva.id = Console.ReadLine();

        Console.Write("Nombre del Cliente: ");
        reserva.cliente = Console.ReadLine();

        Console.Write("Tipo de Reserva: (100, 200, 300 o 400) ");
        // Opcion A
        string respuesta = Console.ReadLine();
        int.TryParse(respuesta, out reserva.tipo);

        // Opcion B
        //int.TryParse(Console.ReadLine(), out reserva.tipo);

        Console.Write("Es Fumador ? (Sí o No) ");
        string fumador = Console.ReadLine();

        // Opción 1, utilizando IF/ELSE
        if (fumador.ToLower().Trim() == "si" || fumador.ToLower().Trim() == "sí")
        {
            reserva.fumador = true;
        }
        else
        {
            reserva.fumador = false;
        }

        // Opción 2, utilizando IF/ELSE IF/ELSE
        if (fumador.ToLower().Trim() == "si" || fumador.ToLower().Trim() == "sí")
        {
            reserva.fumador = true;
        }
        else if (fumador.ToLower().Trim() == "no")
        {
            reserva.fumador = false;
        }
        else 
        {
            reserva.fumador = false;
            Console.WriteLine($"El valor {fumador} no es valido, pero se asigna habitación de no fumador.");
        }

        // Opción 3, utilizando IF/ELSE (sin bloques)
        if (fumador.ToLower().Trim() == "si" || fumador.ToLower().Trim() == "sí") reserva.fumador = true;        
        else reserva.fumador = false;

        // Opción 4a, asignación condicional con ? :
        // Siempre un IF/ELSE y asignación de un valor (no ejecutan sentencias)
        reserva.fumador = (fumador.ToLower().Trim() == "si" || fumador.ToLower().Trim() == "sí") ? true : false;

        // Opción 4b, asignación condicional con ? :
        // Siempre un IF/ELSE y asignación de un valor (no ejecutan sentencias)
        reserva.fumador = (fumador.ToLower().Trim() == "si" || fumador.ToLower().Trim() == "sí");

        // Opción 5, utilizando SWITCH
        switch(fumador.ToLower().Trim())
        {
            case "si":
                reserva.fumador = true;
                break;
            case "sí":
                reserva.fumador = true;
                break;
            case "no":
                reserva.fumador = false;
                break;
            default:
                reserva.fumador = false;
                Console.WriteLine($"El valor {fumador} no es valido, pero se asigna habitación de no fumador.");
                break;
        }
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("ID Reserva: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{reserva.id}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Cliente: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(reserva.cliente);

        // Pintar el tipo de habitación
        // 100 -> Habitación individual
        // 200 -> Habitación doble
        // 300 -> Habitación Junior Suite
        // 400 -> Habitación Suite (cyan)
        // xxx -> xxx, tipo de habitación desconocido (rojo)


        // IF/ELSEIF/ELSE
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Tipo: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;

        if (reserva.tipo == 100) Console.WriteLine("Habitación Individual");
        else if (reserva.tipo == 200) Console.WriteLine("Habitación Doble");
        else if (reserva.tipo == 300) Console.WriteLine("Habitación Junior Suite");
        else if (reserva.tipo == 400)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Habitación Suite");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{reserva.tipo}, desconocido");
        }

        // SWITCH
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Tipo: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;

        switch (reserva.tipo)
        {
            case 100:
                Console.WriteLine("Habitación Individual");
                break;
            case 200:
                Console.WriteLine("Habitación Doble");
                break;
            case 300:
                Console.WriteLine("Habitación Junior Suite");
                break;
            case 400:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Habitación Suite");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{reserva.tipo}, desconocido");
                break;
        }

        // Pintar si es fumador
        // true -> Sí (rojo)
        // false -> No (verde)

        // Asignador condicional (condición) ? "Sí" : "No"

        // Opción A
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Fumador: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.ForegroundColor = (reserva.fumador == true) ? ConsoleColor.Red : ConsoleColor.Green;
        Console.ForegroundColor = (reserva.fumador) ? ConsoleColor.Red : ConsoleColor.Green;     
        string fuma = (reserva.fumador) ? "Sí" : "No";
        Console.WriteLine(fuma);
        
        // Opción B
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Fumador: ".PadLeft(15, ' '));
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.ForegroundColor = (reserva.fumador) ? ConsoleColor.Red : ConsoleColor.Green;       
        Console.WriteLine((reserva.fumador) ? "Sí" : "No");

        Console.ForegroundColor = ConsoleColor.Gray;
    }

    /// <summary>
    /// Sentencias de Control, uso de FOR, FOREACH, WHILE y DO/WHILE
    /// </summary>
    static void SentenciasDeRepeticion()
    {
        ///////////////////////////////////////////////////////////////
        //
        //  Sentencias de Control, uso de FOR, FOREACH, WHILE y DO/WHILE
        //
        ///////////////////////////////////////////////////////////////
        
        string[] frutas = {"naranja", "limón", "pomelo", "líma"};
        object[] objetos = {"naranja", 10, new Alumno(), new Reserva()};

        // Recorremos una colección con un contador FOR
        // Mostramos el contenido de Array utilizando la posición de los elementos
        // Python: for i in range(0, i < len(frutas), i += 1)

        // Opción 1a
        for(int i = 0; i < frutas.Length; i += 1)
        {
            Console.WriteLine($"Posición {i} -> {frutas[i]}");
        }
        Console.WriteLine("");

        // Opcion 1b
        for (int i = 0; i < frutas.Length; i += 1) Console.WriteLine($"Posición {i} -> {frutas[i]}");
        Console.WriteLine("");

        // Recorremos una colección utilizando un FOREACH
        // Mostramos el contenido de Array utilizando los valores elementos
        // Python: for fruta in frutas
        foreach (string fruta in frutas)
        {
            Console.WriteLine($" -> {fruta}");
        }
        Console.WriteLine("");

        // Recorremos una colección utilizando un WHILE
        int contador = 0;
        while (contador < frutas.Length)
        {
            Console.WriteLine($"Posición {contador} -> {frutas[contador]}");
            contador++;
        }
        Console.WriteLine("");

        contador = 0;
        while (true)
        {
            Console.WriteLine($"Posición {contador} -> {frutas[contador]}");
            contador++;
            if (contador >= frutas.Length) break;
        }
        Console.WriteLine("");

        // Recorremos una colección utilizando un DO/WHILE
        contador = 0;
        do
        {
            Console.WriteLine($"Posición {contador} -> {frutas[contador]}");
            contador++;
        } while (contador < frutas.Length);
        Console.WriteLine("");


        //////////////////////////////////////////////////////////////////////////////////

        decimal[] numeros = {10, 5, 345, 52, 13, 1000, 83};

        decimal suma = 0;
        decimal max = 0;
        decimal min = numeros[0];

        // FOR
        for (int i = 0; i < numeros.Length; i = i + 1)
        {
            suma = suma + numeros[i];
            if (numeros[i] > max) max = numeros[i];
            if (numeros[i] < min) min = numeros[i];
        }

        // Mostramos la suma y la media, el número mayor y el menor 
        Console.WriteLine("CALCULADO CON FOR");
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Media: {(suma / numeros.Length).ToString("N2")}");
        Console.WriteLine($"Número mayor: {max}");
        Console.WriteLine($"Número menor: {min}");
        Console.WriteLine("");

        // FOREACH
        suma = 0;
        max = 0;
        min = numeros[0];

        foreach (var num in numeros)
        {
            suma += num;
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine("CALCULADO CON FOREACH");
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Media: {(suma / numeros.Length).ToString("N2")}");
        Console.WriteLine($"Número mayor: {max}");
        Console.WriteLine($"Número menor: {min}");
        Console.WriteLine("");

        // WHILE
        suma = 0;
        max = 0;
        min = numeros[0];

        contador = 0;
        while (contador < numeros.Length)
        {
            suma += numeros[contador];
            if (numeros[contador] > max) max = numeros[contador];
            if (numeros[contador] < min) min = numeros[contador];
            contador++;
        }

        Console.WriteLine("CALCULADO CON WHILE");
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Media: {(suma / numeros.Length).ToString("N2")}");
        Console.WriteLine($"Número mayor: {max}");
        Console.WriteLine($"Número menor: {min}");
        Console.WriteLine("");


        // Ejemplo de obtener información con métedos de LINQ
        Console.WriteLine("CALCULADO CON LINQ");
        Console.WriteLine($"Suma total: {numeros.Sum()}");
        Console.WriteLine($"Media: {numeros.Average().ToString("N2")}");
        Console.WriteLine($"Número mayor: {numeros.Max()}");
        Console.WriteLine($"Número menor: {numeros.Min()}");
    }

    /// <summary>
    /// Control de Excepciones, uso de TRY/CATCH/FINALLY
    /// </summary>
    static void ControlDeExcepciones()
    {
        ///////////////////////////////////////////////////////////////
        //
        //  Control de Excepciones, uso de TRY/CATCH/FINALLY
        //
        ///////////////////////////////////////////////////////////////

        // Cuando se produce una excepción en el código de un bloque TRY 
        // la excepción se controla mediante los bloques CATCH.
        //
        // Primero especificamos todas las excepciones especificas y luego
        // la excepción genérica.
        //
        // El bloque FINALLY garantiza la ejecución de código tanto si se
        // produce una excepción como sino.

        int numero1 = 5;
        int numero2 = 100;

        try
        {
            int numero3 = numero2 / numero1;
            Console.WriteLine($"El valor de número 3 es {numero3}");
        }
        catch (DivideByZeroException err)
        {
            Console.WriteLine("Excepción específica");
            Console.WriteLine($"Mensaje: {err.Message}");
            Console.WriteLine($"Tipo: {err.GetType()}");
        }
        catch (FileNotFoundException err)
        {
            Console.WriteLine("Excepción específica");
            Console.WriteLine($"Mensaje: {err.Message}");
            Console.WriteLine($"Tipo: {err.GetType()}");
        }
        catch (Exception err)
        {   
            Console.WriteLine("Excepción genérica");
            Console.WriteLine($"Mensaje: {err.Message}");
            Console.WriteLine($"Tipo: {err.GetType()}");
        }
        finally
        {
            Console.WriteLine("FIN");
        }
        Console.WriteLine("");


        // THROW permite generar mediante código una excepción
        //
        // Dentro de un bloque CATCH reenvia la excepción a un nivel TRY/CATCH
        // superior.

        try
        {
            Console.WriteLine("NIVEL 1");

            Console.WriteLine(" -> Inicio Nivel 2");
            try
            {
                Console.WriteLine("NIVEL 2");
                int n1 = 0;
                int n2 = 100;
                int n3 = n2 / n1;
            }
            catch (Exception e)
            {                
                Console.WriteLine($"Error 2: {e.Message}");
                throw new Exception("No se puede dividir por cero");
            }
            finally
            {
                Console.WriteLine(" -> Fin Nivel 2");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error 1: {e.Message}");
        }
    }
}