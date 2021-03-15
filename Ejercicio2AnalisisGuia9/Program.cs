using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que identifica la cantidad de piezas aptas que hay en el lote.";

        Double longitud, pieza = 0;

        Console.WriteLine("¿Cuántas piezas va a procesar? ");
        Double n = Double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
        Console.WriteLine("Digite la longuitud del perfil de esta pieza de hierro " + (i + 1) + ":");
        longitud = Double.Parse(Console.ReadLine());

        if (longitud >= 1.20 && longitud <= 1.40)
        {
        pieza = pieza + 1;
        }
        }
         
        Console.WriteLine();
        Console.WriteLine("La cantidad de piezas aptas en el lote son: " + pieza);


        Console.ReadKey();
        }  
    }
}
