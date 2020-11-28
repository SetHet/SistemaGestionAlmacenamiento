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
    public class NegocioSalidaCabecera
    {
        private ConexionSQLServer conexion;
        private MDSalidaCabecera salidaCabecera;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDSalidaCabecera SalidaCabecera { get => salidaCabecera; set => salidaCabecera = value; }

        public NegocioSalidaCabecera()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDSalidaCabecera Select(int cod)
        {
            string query = $"SELECT TOP (1) *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM SalidaCabecera WHERE cod_salida = {cod}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                SalidaCabecera = new MDSalidaCabecera();
                SalidaCabecera.Cod_salida = Convert.ToInt32(table.Rows[0]["cod_salida"]);
                SalidaCabecera.Fecha = DateTime.Parse(table.Rows[0]["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                SalidaCabecera.Id_sucursal = Convert.ToInt32(table.Rows[0]["id_sucursal"]);
                SalidaCabecera.Id_bodega = Convert.ToInt32(table.Rows[0]["id_bodega"]);
                SalidaCabecera.Rut_empleado = table.Rows[0]["rut_empleado"].ToString();
            }
            else
            {
                SalidaCabecera = null;
            }

            return SalidaCabecera;
        }

        public List<MDSalidaCabecera> Select()
        {
            string query = $"SELECT *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM SalidaCabecera";

            DataTable table = Conexion.Select(query);
            List<MDSalidaCabecera> lista = new List<MDSalidaCabecera>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    SalidaCabecera = new MDSalidaCabecera();
                    SalidaCabecera.Cod_salida = Convert.ToInt32(row["cod_salida"]);
                    SalidaCabecera.Fecha = DateTime.Parse(row["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    SalidaCabecera.Id_sucursal = Convert.ToInt32(row["id_sucursal"]);
                    SalidaCabecera.Id_bodega = Convert.ToInt32(row["id_bodega"]);
                    SalidaCabecera.Rut_empleado = row["rut_empleado"].ToString();
                    lista.Add(SalidaCabecera);
                }

            }

            SalidaCabecera = null;

            return lista;
        }

        public MDSalidaCabecera SelectLast()
        {
            string query = $"SELECT TOP (1) *, CONVERT(varchar(40), fecha, 22) as fechaUS FROM SalidaCabecera ORDER BY cod_salida DESC";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                SalidaCabecera = new MDSalidaCabecera();
                SalidaCabecera.Cod_salida = Convert.ToInt32(table.Rows[0]["cod_salida"]);
                SalidaCabecera.Fecha = DateTime.Parse(table.Rows[0]["fechaUS"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                SalidaCabecera.Id_sucursal = Convert.ToInt32(table.Rows[0]["id_sucursal"]);
                SalidaCabecera.Id_bodega = Convert.ToInt32(table.Rows[0]["id_bodega"]);
                SalidaCabecera.Rut_empleado = table.Rows[0]["rut_empleado"].ToString();
            }
            else
            {
                SalidaCabecera = null;
            }

            return SalidaCabecera;
        }


        public bool Insert(MDSalidaCabecera nuevoSalidaCabecera)
        {
            return Insert(nuevoSalidaCabecera.Fecha, nuevoSalidaCabecera.Id_sucursal, nuevoSalidaCabecera.Id_bodega, nuevoSalidaCabecera.Rut_empleado);
        }

        public bool Insert(DateTime fecha, int id_sucursal, int id_bodega, string rut_empleado)
        {
            string nonQuery = $"INSERT INTO SalidaCabecera (fecha, id_sucursal, id_bodega, rut_empleado) VALUES " +
                $"(CONVERT(datetime, '{fecha.ToString("yyyy-MM-dd HH:mm:ss")}', 20), {id_sucursal}, {id_bodega}, '{rut_empleado}')";
            return Conexion.NonQuery(nonQuery);
        }
    }
}
