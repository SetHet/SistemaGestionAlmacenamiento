using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDUnidadProducto
    {
        private int codUnidadProducto;
        private int idProducto;
        private int idEstado;
        private bool enviado;
        private int? idBodega;
        private string ubicacion;

        public int CodUnidadProducto { get => codUnidadProducto; set => codUnidadProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public bool Enviado { get => enviado; set => enviado = value; }
        public int? IdBodega { get => idBodega; set => idBodega = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
