namespace Formacion.CSharp.Ejercicios.ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Ejercicio2();
    }

    // Pedir un número por consola y analizarlo para retorna uno de los dos mensajes:
    // -> El número introducido es [valor]
    // -> No se ha introducido un número o no se puede convertir
    static void Ejercicio1()
    {
        // Opcion A
        Console.Clear();
        Console.Write("Introduce un número: ");
        string respuesta = Console.ReadLine();

        int numero = 0;
        bool resultado = int.TryParse(respuesta, out numero);

        if(resultado == true) Console.WriteLine($"El número es {numero}.");
        else Console.WriteLine($"{respuesta} no se puede convertir a número.");

        // Opcion B
        Console.Write("Introduce un número: ");
        string respuesta2 = Console.ReadLine();

        Console.WriteLine(int.TryParse(respuesta2, out _) 
            ? $"{respuesta2} es un número."
            : $"{respuesta2} no se puede convertir a número.");
    }

    // Preguntar por consola una fecha
    // Convertir a DateTime utilizando TryParse
    // Si se puede conventir mostra la fecha que retorna la ejecución del método .ToLongDateString()
    static void Ejercicio2()
    {
        // Opcion A
        Console.Clear();
        Console.Write("Introduce una fecha: ");
        string respuesta = Console.ReadLine();

        DateTime fecha;
        bool resultado = DateTime.TryParse(respuesta, out fecha);

        if (resultado == true) Console.WriteLine(fecha.ToLongDateString());
        else Console.WriteLine($"{respuesta} no se puede convertir en fecha.");

        // Opcion B
        Console.Write("Introduce una fecha: ");
        string respuesta2 = Console.ReadLine();

        DateTime fecha2;
        Console.WriteLine(DateTime.TryParse(respuesta2, out fecha2)
            ? fecha2.ToLongDateString()
            : $"{respuesta2} no se puede convertir en fecha.");
    }
}