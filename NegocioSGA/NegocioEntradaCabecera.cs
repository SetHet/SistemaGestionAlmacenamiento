using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatosSGA;
using ConexionBD;
using System.Data;
using System.Globalization;

namespace NegocioSGA
{
    public class NegocioEntradaCabecera
    {
        private ConexionSQLServer conexion;
        private MDEntradaCabecera entradaCabecera;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDEntradaCabecera EntradaCabecera { get => entradaCabecera; set => entradaCabecera = value; }

        public NegocioEntradaCabecera()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDEntradaCabecera Select(int cod)
        {
            string query = $"SELECT TOP (1) *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM EntradaCabecera WHERE cod_entrada = {cod}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                EntradaCabecera = new MDEntradaCabecera();
                EntradaCabecera.Cod_entrada = Convert.ToInt32(table.Rows[0]["cod_entrada"]);
                EntradaCabecera.Fecha = DateTime.Parse(table.Rows[0]["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                EntradaCabecera.Id_proveedor = Convert.ToInt32(table.Rows[0]["id_proveedor"]);
                EntradaCabecera.Id_bodega = Convert.ToInt32(table.Rows[0]["id_bodega"]);
                EntradaCabecera.Rut_empleado = table.Rows[0]["rut_empleado"].ToString();
            }
            else
            {
                EntradaCabecera = null;
            }

            return EntradaCabecera;
        }
        
        public List<MDEntradaCabecera> Select()
        {
            string query = $"SELECT *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM EntradaCabecera";

            DataTable table = Conexion.Select(query);
            List<MDEntradaCabecera> lista = new List<MDEntradaCabecera>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EntradaCabecera = new MDEntradaCabecera();
                    EntradaCabecera.Cod_entrada = Convert.ToInt32(row["cod_entrada"]);
                    EntradaCabecera.Fecha = DateTime.Parse(row["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    EntradaCabecera.Id_proveedor = Convert.ToInt32(row["id_proveedor"]);
                    EntradaCabecera.Id_bodega = Convert.ToInt32(row["id_bodega"]);
                    EntradaCabecera.Rut_empleado = row["rut_empleado"].ToString();
                    lista.Add(EntradaCabecera);
                }

            }

            EntradaCabecera = null;

            return lista;
        }

        public MDEntradaCabecera SelectLast()
        {
            string query = $"SELECT TOP (1) *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM EntradaCabecera ORDER BY cod_entrada DESC";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                EntradaCabecera = new MDEntradaCabecera();
                EntradaCabecera.Cod_entrada = Convert.ToInt32(table.Rows[0]["cod_entrada"]);
                EntradaCabecera.Fecha = DateTime.Parse(table.Rows[0]["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                EntradaCabecera.Id_proveedor = Convert.ToInt32(table.Rows[0]["id_proveedor"]);
                EntradaCabecera.Id_bodega = Convert.ToInt32(table.Rows[0]["id_bodega"]);
                EntradaCabecera.Rut_empleado = table.Rows[0]["rut_empleado"].ToString();
            }
            else
            {
                EntradaCabecera = null;
            }

            return EntradaCabecera;
        }


        public bool Insert(MDEntradaCabecera nuevoEntradaCabecera)
        {
            return Insert(nuevoEntradaCabecera.Fecha, nuevoEntradaCabecera.Id_proveedor, nuevoEntradaCabecera.Id_bodega, nuevoEntradaCabecera.Rut_empleado);
        }

        public bool Insert(DateTime fecha, int id_proveedor, int id_bodega, string rut_empleado)
        {
            string nonQuery = $"INSERT INTO EntradaCabecera (fecha, id_proveedor, id_bodega, rut_empleado) VALUES " +
                $"(CONVERT(datetime, '{fecha.ToString("yyyy-MM-dd HH:mm:ss")}', 20), {id_proveedor}, {id_bodega}, '{rut_empleado}')";
            return Conexion.NonQuery(nonQuery);
        }
        
    }
}
