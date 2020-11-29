using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatosSGA
{
    public class DTipoProductoCantidad
    {
        private int id_tipo_producto;
        private int cantidad;

        public int Id_tipo_producto { get => id_tipo_producto; set => id_tipo_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
