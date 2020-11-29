using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatosSGA;
using NegocioSGA;

namespace ConsoleTenting
{
    class Program
    {
        static void Main(string[] args)
        {
            NegocioProducto neg = new NegocioProducto();

            int id = 2;
            Console.WriteLine("Entrada");
            foreach (var a in neg.GetCantidadProductoEntrada(1))
            {
                Console.WriteLine($"{a.IdProducto} : {a.Cantidad} ");
            }
            Console.WriteLine("Salida");
            foreach (var a in neg.GetCantidadProductoSalida(1))
            {
                Console.WriteLine($"{a.IdProducto} : {a.Cantidad} ");
            }
            Console.WriteLine("Diff");
            foreach (var a in neg.GetCantidadProducto(1))
            {
                Console.WriteLine($"{a.IdProducto} : {a.Cantidad} ");
            }

            Console.ReadKey();
        }
    }
}
