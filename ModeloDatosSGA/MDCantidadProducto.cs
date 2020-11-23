using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDCantidadProducto
    {
        private int codPeticionEnvio;
        private int idProducto;
        private int cantidad;

        public int CodPeticionEnvio { get => codPeticionEnvio; set => codPeticionEnvio = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
