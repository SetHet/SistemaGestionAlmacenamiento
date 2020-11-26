using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDSalidaCabecera
    {
        private int cod_salida;
        private DateTime fecha;
        private int id_sucursal;
        private int id_bodega;
        private string rut_empleado;

        public int Cod_salida { get => cod_salida; set => cod_salida = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public int Id_bodega { get => id_bodega; set => id_bodega = value; }
        public string Rut_empleado { get => rut_empleado; set => rut_empleado = value; }
    }
}
