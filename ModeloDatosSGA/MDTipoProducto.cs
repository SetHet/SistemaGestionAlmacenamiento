using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDTipoProducto
    {
        private int idTipoProducto;
        private string nombreTipo;

        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
