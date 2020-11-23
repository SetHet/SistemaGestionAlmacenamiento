using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDBodega
    {
        private int idBodega;
        private string nombre;
        private string direccion;

        public int IdBodega { get => idBodega; set => idBodega = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
