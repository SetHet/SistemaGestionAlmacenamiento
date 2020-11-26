using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDEntradaDetalle
    {
        private int id_producto;
        private int cod_entrada;
        private int cantidad;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cod_entrada { get => cod_entrada; set => cod_entrada = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
