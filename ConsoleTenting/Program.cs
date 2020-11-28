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
            List<MDEntradaCabecera> entradaCabecera;

            NegocioEntradaCabecera nec = new NegocioEntradaCabecera();
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            nec.Insert(DateTime.Now, 1, 1, "12.345.678-9");

            entradaCabecera = nec.Select();

            foreach (var e in entradaCabecera)
            {

            Console.WriteLine($"{e.Cod_entrada} {e.Rut_empleado} {e.Fecha}");
            }

            Console.ReadKey();
        }
    }
}
