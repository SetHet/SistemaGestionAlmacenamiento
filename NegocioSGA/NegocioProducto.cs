using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatosSGA;
using ConexionBD;
using System.Data;

namespace NegocioSGA
{
    public class NegocioProducto
    {
        private ConexionSQLServer conexion;
        private MDProducto bodega;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDProducto Producto { get => bodega; set => bodega = value; }

        public NegocioProducto()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDProducto Select(int id)
        {
            string query = $"SELECT TOP (1) * FROM Producto WHERE id_producto = {id}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                
                Producto = new MDProducto();
                Producto.IdProducto = Convert.ToInt32(table.Rows[0]["id_producto"]);
                Producto.IdTipoProducto = Convert.ToInt32(table.Rows[0]["id_tipo"]);
                Producto.Nombre = table.Rows[0]["nombre_producto"].ToString();
                Producto.Descripcion = table.Rows[0]["descripcion_producto"].ToString();
            }
            else
            {
                Producto = null;
            }

            return Producto;
        }

        public List<MDProducto> Select()
        {
            string query = $"SELECT * FROM Producto";

            DataTable table = Conexion.Select(query);
            List<MDProducto> lista = new List<MDProducto>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    
                    Producto = new MDProducto();
                    Producto.IdProducto = Convert.ToInt32(row["id_producto"]);
                    Producto.IdTipoProducto = Convert.ToInt32(row["id_tipo"]);
                    Producto.Nombre = row["nombre_Producto"].ToString();
                    Producto.Descripcion = row["descripcion_producto"].ToString();
                    lista.Add(Producto);
                }

            }

            Producto = null;

            return lista;
        }

        public bool Delete(int id)
        {
            string nonQuery = $"DELETE FROM Producto WHERE id_producto = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDProducto nuevoProducto)
        {
            //FALTA ID TIPO PRODUCTO QUE ES FORANEO
            string nonQuery = $"INSERT INTO Producto (id_tipo,nombre_producto,descripcion_producto) VALUES (''{nuevoProducto.IdTipoProducto}',{nuevoProducto.Nombre}','{nuevoProducto.Descripcion}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(int id_tipo ,string nombre, string descripcion)
        {
            MDProducto auxProducto = new MDProducto();
            auxProducto.IdProducto = 0;
            auxProducto.IdTipoProducto = 0;
            auxProducto.Nombre = nombre;
            auxProducto.Descripcion = descripcion;
            return Insert(auxProducto);
        }

        public bool Update(int id, int id_tipo ,string nombre, string descripcion)
        {
            string nonQuery = $"UPDATE Producto SET  IdTipoProducto = '{id_tipo}' , nombre_producto = '{nombre}', descripcion_producto = '{descripcion}' WHERE id_producto = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDProducto editableProducto)
        {
            return Update( editableProducto.IdProducto, editableProducto.IdTipoProducto, editableProducto.Nombre, editableProducto.Descripcion);
        }
    }
}
