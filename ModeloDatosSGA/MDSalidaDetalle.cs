using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDSalidaDetalle
    {
        private int id_producto;
        private int cod_salida;
        private int cantidad;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cod_salida { get => cod_salida; set => cod_salida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
