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
            List<MDSalidaDetalle> lista;

            var ned = new NegocioSalidaDetalle();
            ned.Insert(2,1,15);

            var ee = ned.Select(1,1); 
                Console.WriteLine($"Select(1):  {ee.Cod_salida} {ee.Id_producto} {ee.Cantidad}");

            lista = ned.Select();

            foreach (var e in lista)
            {

                Console.WriteLine($"Select:  {e.Cod_salida} {e.Id_producto} {e.Cantidad}");
            }

            Console.ReadKey();
        }
    }
}
