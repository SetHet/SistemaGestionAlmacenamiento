using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDProducto
    {
        private int idProducto;
        private int idTipoProducto;
        private string nombre;
        private string descripcion;
        private string dimenciones;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Dimenciones { get => dimenciones; set => dimenciones = value; }
    }
}
