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

        public bool Update(MDTipoProducto editarTipoProducto)
        {
            return Update(editarTipoProducto.IdTipoProducto, editarTipoProducto.NombreTipo);
        }
    }
}
