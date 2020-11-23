using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDRegistroCambio
    {
        private int codRegistroCambio;
        private string rutEmpleado;
        private int codUnidadProducto;
        private int codEnvio;
        private string descripcion;

        public int CodRegistroCambio { get => codRegistroCambio; set => codRegistroCambio = value; }
        public string RutEmpleado { get => rutEmpleado; set => rutEmpleado = value; }
        public int CodUnidadProducto { get => codUnidadProducto; set => codUnidadProducto = value; }
        public int CodEnvio { get => codEnvio; set => codEnvio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
