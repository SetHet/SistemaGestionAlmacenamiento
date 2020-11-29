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
            NegocioTipoProducto tp = new NegocioTipoProducto();
            foreach (var item in tp.GetCantidadTipoProductoActual(4))
            {
                Console.WriteLine($"{item.Id_tipo_producto} : {item.Cantidad} ");
            }


            Console.ReadKey();
        }
    }
}
