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
                Producto.IdTipoProducto = Convert.ToInt32(table.Rows[0]["id_tipo_producto"]);
                Producto.Nombre = table.Rows[0]["nombre"].ToString();
                Producto.Descripcion = table.Rows[0]["descripcion"].ToString();
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
                    Producto.IdTipoProducto = Convert.ToInt32(row["id_tipo_producto"]);
                    Producto.Nombre = row["nombre"].ToString();
                    Producto.Descripcion = row["descripcion"].ToString();
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
            string nonQuery = $"INSERT INTO Producto (id_tipo_producto, nombre, descripcion) VALUES ({nuevoProducto.IdTipoProducto},'{nuevoProducto.Nombre}','{nuevoProducto.Descripcion}')";
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
            string nonQuery = $"UPDATE Producto SET  Id_Tipo_Producto = {id_tipo} , nombre = '{nombre}', descripcion = '{descripcion}' WHERE id_producto = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDProducto editableProducto)
        {
            return Update( editableProducto.IdProducto, editableProducto.IdTipoProducto, editableProducto.Nombre, editableProducto.Descripcion);
        }

        public List<DProductoCantidad> GetCantidadProductos(int id_bodega)
        {
            Dictionary<int, int> diccSalidaProCant = new Dictionary<int, int>();
            List<DProductoCantidad> listaProdCantEntrada = GetCantidadProductoEntrada(id_bodega);
            List<DProductoCantidad> listaProdCantSalida = GetCantidadProductoSalida(id_bodega);
            List<DProductoCantidad> listaProdCantDiferencia = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            foreach (var salidaProdCant in listaProdCantSalida)
            {
                diccSalidaProCant[salidaProdCant.IdProducto] = salidaProdCant.Cantidad;
            }

            foreach (var entradaProdCant in listaProdCantEntrada)
            {
                auxProductoCantidad = new DProductoCantidad();
                auxProductoCantidad.IdProducto = entradaProdCant.IdProducto;
                if (diccSalidaProCant.ContainsKey(entradaProdCant.IdProducto))
                {
                    auxProductoCantidad.Cantidad = entradaProdCant.Cantidad - diccSalidaProCant[entradaProdCant.IdProducto];
                }
                else
                {
                    auxProductoCantidad.Cantidad = entradaProdCant.Cantidad;
                }
                listaProdCantDiferencia.Add(auxProductoCantidad);
            }


            return listaProdCantDiferencia;
        }

        public List<DProductoCantidad> GetCantidadProductoEntrada(int id_bodega)
        {
            string query = $"SELECT entDet.id_producto as id_producto, SUM(cantidad) as cantidad " +
                $"FROM Bodega bod " +
                $"JOIN EntradaCabecera entCab " +
                $"ON(entCab.id_bodega = bod.id_bodega) " +
                $"JOIN EntradaDetalle entDet " +
                $"ON(entCab.cod_entrada = entDet.cod_entrada) " +
                $"WHERE bod.id_bodega = {id_bodega} " +
                $"GROUP BY entDet.id_producto";

            DataTable table = Conexion.Select(query);

            List<DProductoCantidad> listaProductosCantidad = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    auxProductoCantidad = new DProductoCantidad();
                    auxProductoCantidad.IdProducto = Convert.ToInt32(row["id_producto"]);
                    auxProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    listaProductosCantidad.Add(auxProductoCantidad);
                }
            }

            return listaProductosCantidad;
        }

        public List<DProductoCantidad> GetCantidadProductoSalida(int id_bodega)
        {
            string query = $"SELECT salDet.id_producto as id_producto, SUM(cantidad) as cantidad " +
                $"FROM Bodega bod " +
                $"JOIN SalidaCabecera salCab " +
                $"ON(salCab.id_bodega = bod.id_bodega) " +
                $"JOIN SalidaDetalle salDet " +
                $"ON(salCab.cod_salida = salDet.cod_salida) " +
                $"WHERE bod.id_bodega = {id_bodega} " +
                $"GROUP BY salDet.id_producto";

            DataTable table = Conexion.Select(query);

            List<DProductoCantidad> listaProductosCantidad = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    auxProductoCantidad = new DProductoCantidad();
                    auxProductoCantidad.IdProducto = Convert.ToInt32(row["id_producto"]);
                    auxProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    listaProductosCantidad.Add(auxProductoCantidad);
                }
            }

            return listaProductosCantidad;
        }

        public List<DProductoCantidad> GetCantidadProductos()
        {
            Dictionary<int, int> diccSalidaProCant = new Dictionary<int, int>();
            List<DProductoCantidad> listaProdCantEntrada = GetCantidadProductoEntrada();
            List<DProductoCantidad> listaProdCantSalida = GetCantidadProductoSalida();
            List<DProductoCantidad> listaProdCantDiferencia = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            foreach (var salidaProdCant in listaProdCantSalida)
            {
                diccSalidaProCant[salidaProdCant.IdProducto] = salidaProdCant.Cantidad;
            }

            foreach (var entradaProdCant in listaProdCantEntrada)
            {
                auxProductoCantidad = new DProductoCantidad();
                auxProductoCantidad.IdProducto = entradaProdCant.IdProducto;
                if (diccSalidaProCant.ContainsKey(entradaProdCant.IdProducto))
                {
                    auxProductoCantidad.Cantidad = entradaProdCant.Cantidad - diccSalidaProCant[entradaProdCant.IdProducto];
                }
                else
                {
                    auxProductoCantidad.Cantidad = entradaProdCant.Cantidad;
                }
                listaProdCantDiferencia.Add(auxProductoCantidad);
            }


            return listaProdCantDiferencia;
        }

        public List<DProductoCantidad> GetCantidadProductoEntrada()
        {
            string query = $"SELECT entDet.id_producto as id_producto, SUM(cantidad) as cantidad " +
                $"FROM Bodega bod " +
                $"JOIN EntradaCabecera entCab " +
                $"ON(entCab.id_bodega = bod.id_bodega) " +
                $"JOIN EntradaDetalle entDet " +
                $"ON(entCab.cod_entrada = entDet.cod_entrada) " +
                $"GROUP BY entDet.id_producto";

            DataTable table = Conexion.Select(query);

            List<DProductoCantidad> listaProductosCantidad = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    auxProductoCantidad = new DProductoCantidad();
                    auxProductoCantidad.IdProducto = Convert.ToInt32(row["id_producto"]);
                    auxProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    listaProductosCantidad.Add(auxProductoCantidad);
                }
            }

            return listaProductosCantidad;
        }

        public List<DProductoCantidad> GetCantidadProductoSalida()
        {
            string query = $"SELECT salDet.id_producto as id_producto, SUM(cantidad) as cantidad " +
                $"FROM Bodega bod " +
                $"JOIN SalidaCabecera salCab " +
                $"ON(salCab.id_bodega = bod.id_bodega) " +
                $"JOIN SalidaDetalle salDet " +
                $"ON(salCab.cod_salida = salDet.cod_salida) " +
                $"GROUP BY salDet.id_producto";

            DataTable table = Conexion.Select(query);

            List<DProductoCantidad> listaProductosCantidad = new List<DProductoCantidad>();
            DProductoCantidad auxProductoCantidad;

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    auxProductoCantidad = new DProductoCantidad();
                    auxProductoCantidad.IdProducto = Convert.ToInt32(row["id_producto"]);
                    auxProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    listaProductosCantidad.Add(auxProductoCantidad);
                }
            }

            return listaProductosCantidad;
        }
    }
}
