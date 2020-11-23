using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDPeticionEnvio
    {
        private int codPeticionEnvio;
        private string rutEmpleado;
        private int? idBodega;
        private int? idSucursal;
        private int? idProveedor;

        public int CodPeticionEnvio { get => codPeticionEnvio; set => codPeticionEnvio = value; }
        public string RutEmpleado { get => rutEmpleado; set => rutEmpleado = value; }
        public int? IdBodega { get => idBodega; set => idBodega = value; }
        public int? IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int? IdProveedor { get => idProveedor; set => idProveedor = value; }
    }
}
