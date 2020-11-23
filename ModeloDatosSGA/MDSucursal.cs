using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDSucursal
    {
        private int idSucursal;
        private string nombre;
        private string direccion;

        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
