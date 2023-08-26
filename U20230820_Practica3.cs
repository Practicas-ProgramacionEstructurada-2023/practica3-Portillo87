using System;
using System.Diagnostics;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

        //Declaraciom de variables
        string?  Marca_Zapato;
        string? Color_Zapato;
        int Cantidad;
        double Precio_Zapatos;

        //Capturando datos
        Console.WriteLine("\n-------Capturando Variables--------\n");
        Console.WriteLine("Ingrese la macar de zapatos a comprar:\n");
        Marca_Zapato = Convert.ToString(Console.ReadLine ());

        Console.WriteLine("\nIngrese el color del par de zapatos:\n");
        Color_Zapato = Convert.ToString(Console.ReadLine ());

        Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar:\n");
        Cantidad = Convert.ToInt32(Console.ReadLine ());

        Console.WriteLine("\nIngrese el precio del par de zapatos a comprar: \n");
        Precio_Zapatos = Convert.ToDouble(Console.ReadLine ());
        Console.WriteLine("------Fin de capturas------\n");

        //Capturando el total a pagar
        double Total = Cantidad * Precio_Zapatos;

        //Imprimiendo resultado
        Console.WriteLine("------Imprimiendo Resultados ------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nLa marca de zapatos a comprar es: " + Marca_Zapato);
        Console.WriteLine("\nEl color de zapatos es: " + Color_Zapato);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nLa cantiadad de pares de zapatos a comprar es: " + Cantidad);
        Console.WriteLine("\nEl precio de zapatos a comprar es: " + Precio_Zapatos);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nEl total a pagar es: " + Total);
        Console.WriteLine("------Fin de imprimiendo Resultados ------\n");
        


        }
    }
}