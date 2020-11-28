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
            List<MDEntradaDetalle> lista;

            var ned = new NegocioEntradaDetalle();
            ned.Insert(1,2,30);

            var ee = ned.Select(1, 1); 
                Console.WriteLine($"Select(1,1):  {ee.Cod_entrada} {ee.Id_producto} {ee.Cantidad}");

            lista = ned.Select();

            foreach (var e in lista)
            {

                Console.WriteLine($"{e.Cod_entrada} {e.Id_producto} {e.Cantidad}");
            }

            Console.ReadKey();
        }
    }
}
