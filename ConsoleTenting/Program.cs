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
            List<MDSalidaCabecera> lista;

            var ned = new NegocioSalidaCabecera();
            ned.Insert(DateTime.Now,1,1,"12.345.678-9");

            var ee = ned.Select(1); 
                Console.WriteLine($"Select(1):  {ee.Cod_salida} {ee.Fecha} {ee.Id_sucursal}");

            lista = ned.Select();

            foreach (var e in lista)
            {

                Console.WriteLine($"Select(1):  {e.Cod_salida} {e.Fecha} {e.Id_sucursal}");
            }

            Console.ReadKey();
        }
    }
}
