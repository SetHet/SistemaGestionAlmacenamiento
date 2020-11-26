using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDEntradaCabecera
    {
        private int cod_entrada;
        private DateTime fecha;
        private int id_proveedor;
        private int id_bodega;
        private string rut_empleado;

        public int Cod_entrada { get => cod_entrada; set => cod_entrada = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public int Id_bodega { get => id_bodega; set => id_bodega = value; }
        public string Rut_empleado { get => rut_empleado; set => rut_empleado = value; }
    }
}
