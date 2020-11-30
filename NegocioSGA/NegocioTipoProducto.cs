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
    public class NegocioTipoProducto
    {
        private ConexionSQLServer conexion;
        private MDTipoProducto tipoProducto;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDTipoProducto TipoProducto { get => tipoProducto; set => tipoProducto = value; }

        public NegocioTipoProducto()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDTipoProducto Select(int id)
        {
            string query = $"SELECT TOP (1) * FROM TipoProducto WHERE id_tipo_producto = {id}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                TipoProducto = new MDTipoProducto();
                TipoProducto.IdTipoProducto = Convert.ToInt32(table.Rows[0]["id_tipo_producto"]);
                TipoProducto.NombreTipo = table.Rows[0]["nombre_tipo"].ToString();
            }
            else
            {
                TipoProducto = null;
            }

            return TipoProducto;
        }

        public List<MDTipoProducto> Select()
        {
            string query = $"SELECT * FROM TipoProducto";

            DataTable table = Conexion.Select(query);
            List<MDTipoProducto> lista = new List<MDTipoProducto>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    TipoProducto = new MDTipoProducto();
                    TipoProducto.IdTipoProducto = Convert.ToInt32(row["id_tipo_producto"]);
                    TipoProducto.NombreTipo = row["nombre_tipo"].ToString();
                    lista.Add(TipoProducto);
                }

            }
            
            TipoProducto = null;

            return lista;
        }

        public bool Delete(int id)
        {
            string nonQuery = $"DELETE FROM TipoProducto WHERE id_tipo_producto = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDTipoProducto nuevoTipoProducto)
        {
            string nonQuery = $"INSERT INTO TipoProducto (nombre_tipo) VALUES ('{nuevoTipoProducto.NombreTipo}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(string nombre)
        {
            MDTipoProducto auxTipoProducto = new MDTipoProducto();
            auxTipoProducto.IdTipoProducto = 0;
            auxTipoProducto.NombreTipo = nombre;
            return Insert(auxTipoProducto);
        }

        public bool Update(int id, string nombre)
        {
            string nonQuery = $"UPDATE TipoProducto SET nombre_tipo = '{nombre}' WHERE id_tipo_producto = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDTipoProducto editableTipoProducto)
        {
            return Update(editableTipoProducto.IdTipoProducto, editableTipoProducto.NombreTipo);
        }


        public List<DTipoProductoCantidad> GetCantidadTipoProductoActualByBodega(int id_bodega)
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            List<MDTipoProducto> listaTipoProducto = Select();
            DTipoProductoCantidad tipoProductoCantidad;
            int cant_salida;
            int cant_entrada;

            List<DTipoProductoCantidad> listaTipoProductoEntrada = GetCantidadTipoProductoEntradaByBodega(id_bodega);
            Dictionary<int, int> diccTipoProductoCantidadEntrada = new Dictionary<int, int>();

            List<DTipoProductoCantidad> listaTipoProductoSalida = GetCantidadTipoProductoSalidaByBodega(id_bodega);
            Dictionary<int, int> diccTipoProductoCantidadSalida = new Dictionary<int, int>();

            //Rellenar dicc entrada
            foreach (var id_cantidad in listaTipoProductoEntrada)
            {
                diccTipoProductoCantidadEntrada[id_cantidad.Id_tipo_producto] = id_cantidad.Cantidad;
            }

            //Rellenar dicc salida
            foreach (var id_cantidad in listaTipoProductoSalida)
            {
                diccTipoProductoCantidadSalida[id_cantidad.Id_tipo_producto] = id_cantidad.Cantidad;
            }

            //rellenar lista
            foreach (var tipo in listaTipoProducto)
            {
                tipoProductoCantidad = new DTipoProductoCantidad();
                tipoProductoCantidad.Id_tipo_producto = tipo.IdTipoProducto;

                cant_entrada = 0;
                cant_salida = 0;

                if (diccTipoProductoCantidadEntrada.ContainsKey(tipo.IdTipoProducto))
                {
                    cant_entrada = diccTipoProductoCantidadEntrada[tipo.IdTipoProducto];
                }

                if (diccTipoProductoCantidadSalida.ContainsKey(tipo.IdTipoProducto))
                {
                    cant_salida = diccTipoProductoCantidadSalida[tipo.IdTipoProducto];
                }

                tipoProductoCantidad.Cantidad = cant_entrada - cant_salida;

                lista.Add(tipoProductoCantidad);
            }



            return lista;
        }

        public List<DTipoProductoCantidad> GetCantidadTipoProductoEntradaByBodega(int id_bodega)
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            DTipoProductoCantidad tipoProductoCantidad;

            string query = $"SELECT " +
                $"prod.id_tipo_producto as id_tipo, " +
                $"SUM(ISNULL(entDet.cantidad, 0)) as cantidad " +
                $"FROM producto prod " +
                $"LEFT JOIN " +
                $"(EntradaDetalle entDet " +
                $"JOIN EntradaCabecera entCab " +
                $"ON(entCab.cod_entrada = entDet.cod_entrada)) " +
                $"ON(entDet.id_producto = prod.id_producto) " +
                $"WHERE id_bodega = {id_bodega} " +
                $"GROUP BY id_tipo_producto, id_bodega";

            DataTable table = Conexion.Select(query);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    tipoProductoCantidad = new DTipoProductoCantidad();
                    tipoProductoCantidad.Id_tipo_producto = Convert.ToInt32(row["id_tipo"]);
                    tipoProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(tipoProductoCantidad);
                }
            }

            return lista;
        }

        public List<DTipoProductoCantidad> GetCantidadTipoProductoSalidaByBodega(int id_bodega)
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            DTipoProductoCantidad tipoProductoCantidad;

            string query = $"SELECT " +
                $"prod.id_tipo_producto as id_tipo, " +
                $"SUM(ISNULL(salDet.cantidad, 0)) as cantidad " +
                $"FROM producto prod " +
                $"LEFT JOIN (" +
                $"SalidaDetalle salDet " +
                $"JOIN SalidaCabecera salCab " +
                $"ON (salCab.cod_salida = salDet.cod_salida)) " +
                $"ON (salDet.id_producto = prod.id_producto) " +
                $"WHERE id_bodega = {id_bodega} " +
                $"GROUP BY id_tipo_producto, id_bodega";

            DataTable table = Conexion.Select(query);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    tipoProductoCantidad = new DTipoProductoCantidad();
                    tipoProductoCantidad.Id_tipo_producto = Convert.ToInt32(row["id_tipo"]);
                    tipoProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(tipoProductoCantidad);
                }
            }

            return lista;
        }



        
        public List<DTipoProductoCantidad> GetCantidadTipoProductoActual()
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            List<MDTipoProducto> listaTipoProducto = Select();
            DTipoProductoCantidad tipoProductoCantidad;
            int cant_salida;
            int cant_entrada;

            List<DTipoProductoCantidad> listaTipoProductoEntrada = GetCantidadTipoProductoEntrada();
            Dictionary<int, int> diccTipoProductoCantidadEntrada = new Dictionary<int, int>();

            List<DTipoProductoCantidad> listaTipoProductoSalida = GetCantidadTipoProductoSalida();
            Dictionary<int, int> diccTipoProductoCantidadSalida = new Dictionary<int, int>();

            //Rellenar dicc entrada
            foreach (var id_cantidad in listaTipoProductoEntrada)
            {
                diccTipoProductoCantidadEntrada[id_cantidad.Id_tipo_producto] = id_cantidad.Cantidad;
            }

            //Rellenar dicc salida
            foreach (var id_cantidad in listaTipoProductoSalida)
            {
                diccTipoProductoCantidadSalida[id_cantidad.Id_tipo_producto] = id_cantidad.Cantidad;
            }

            //rellenar lista
            foreach (var tipo in listaTipoProducto)
            {
                tipoProductoCantidad = new DTipoProductoCantidad();
                tipoProductoCantidad.Id_tipo_producto = tipo.IdTipoProducto;

                cant_entrada = 0;
                cant_salida = 0;

                if (diccTipoProductoCantidadEntrada.ContainsKey(tipo.IdTipoProducto))
                {
                    cant_entrada = diccTipoProductoCantidadEntrada[tipo.IdTipoProducto];
                }

                if (diccTipoProductoCantidadSalida.ContainsKey(tipo.IdTipoProducto))
                {
                    cant_salida = diccTipoProductoCantidadSalida[tipo.IdTipoProducto];
                }

                tipoProductoCantidad.Cantidad = cant_entrada - cant_salida;

                lista.Add(tipoProductoCantidad);
            }



            return lista;
        }

        public List<DTipoProductoCantidad> GetCantidadTipoProductoEntrada()
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            DTipoProductoCantidad tipoProductoCantidad;

            string query = $"SELECT " +
                $"prod.id_tipo_producto as id_tipo, " +
                $"SUM(ISNULL(entDet.cantidad, 0)) as cantidad " +
                $"FROM producto prod " +
                $"LEFT JOIN " +
                $"(EntradaDetalle entDet " +
                $"JOIN EntradaCabecera entCab " +
                $"ON(entCab.cod_entrada = entDet.cod_entrada)) " +
                $"ON(entDet.id_producto = prod.id_producto) " +
                $"GROUP BY id_tipo_producto";

            DataTable table = Conexion.Select(query);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    tipoProductoCantidad = new DTipoProductoCantidad();
                    tipoProductoCantidad.Id_tipo_producto = Convert.ToInt32(row["id_tipo"]);
                    tipoProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(tipoProductoCantidad);
                }
            }

            return lista;
        }

        public List<DTipoProductoCantidad> GetCantidadTipoProductoSalida()
        {
            List<DTipoProductoCantidad> lista = new List<DTipoProductoCantidad>();
            DTipoProductoCantidad tipoProductoCantidad;

            string query = $"SELECT " +
                $"prod.id_tipo_producto as id_tipo, " +
                $"SUM(ISNULL(salDet.cantidad, 0)) as cantidad " +
                $"FROM producto prod " +
                $"LEFT JOIN (" +
                $"SalidaDetalle salDet " +
                $"JOIN SalidaCabecera salCab " +
                $"ON (salCab.cod_salida = salDet.cod_salida)) " +
                $"ON (salDet.id_producto = prod.id_producto) " +
                $"GROUP BY id_tipo_producto";

            DataTable table = Conexion.Select(query);

            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    tipoProductoCantidad = new DTipoProductoCantidad();
                    tipoProductoCantidad.Id_tipo_producto = Convert.ToInt32(row["id_tipo"]);
                    tipoProductoCantidad.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(tipoProductoCantidad);
                }
            }

            return lista;
        }
    }
}
