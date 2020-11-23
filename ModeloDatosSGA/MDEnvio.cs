using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDEnvio
    {
        private int codEnvio;
        private int codPeticionEnvio;
        private int codUnidadProducto;
        private DateTime fecha;
        private int? idBodega;
        private int? idSucursal;
        private int? idProveedor;

        public int CodEnvio { get => codEnvio; set => codEnvio = value; }
        public int CodPeticionEnvio { get => codPeticionEnvio; set => codPeticionEnvio = value; }
        public int CodUnidadProducto { get => codUnidadProducto; set => codUnidadProducto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int? IdBodega { get => idBodega; set => idBodega = value; }
        public int? IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int? IdProveedor { get => idProveedor; set => idProveedor = value; }
    }
}
