using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD;
using ModeloDatosSGA;
using System.Data;

namespace NegocioSGA
{
    public class NegocioSalidaDetalle
    {
        private ConexionSQLServer conexion;
        private MDSalidaDetalle salidaDetalle;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDSalidaDetalle SalidaDetalle { get => salidaDetalle; set => salidaDetalle = value; }

        public NegocioSalidaDetalle()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDSalidaDetalle Select(int cod_salida, int id_producto)
        {
            string query = $"SELECT TOP (1) * FROM SalidaDetalle WHERE cod_salida = {cod_salida} AND id_producto = {id_producto}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                SalidaDetalle = new MDSalidaDetalle();
                SalidaDetalle.Cod_salida = Convert.ToInt32(table.Rows[0]["cod_salida"]);
                SalidaDetalle.Id_producto = Convert.ToInt32(table.Rows[0]["id_producto"]);
                SalidaDetalle.Cantidad = Convert.ToInt32(table.Rows[0]["cantidad"]);
            }
            else
            {
                SalidaDetalle = null;
            }

            return SalidaDetalle;
        }

        public List<MDSalidaDetalle> Select()
        {
            string query = $"SELECT * FROM SalidaDetalle";

            DataTable table = Conexion.Select(query);
            List<MDSalidaDetalle> lista = new List<MDSalidaDetalle>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    SalidaDetalle = new MDSalidaDetalle();
                    SalidaDetalle.Cod_salida = Convert.ToInt32(row["cod_salida"]);
                    SalidaDetalle.Id_producto = Convert.ToInt32(row["id_producto"]);
                    SalidaDetalle.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(SalidaDetalle);
                }

            }

            SalidaDetalle = null;

            return lista;
        }


        public bool Insert(MDSalidaDetalle nuevoSalidaDetalle)
        {
            return Insert(nuevoSalidaDetalle.Cod_salida, nuevoSalidaDetalle.Id_producto, nuevoSalidaDetalle.Cantidad);
        }

        public bool Insert(int cod_salida, int id_producto, int cantidad)
        {
            string nonQuery = $"INSERT INTO SalidaDetalle (cod_salida, id_producto, cantidad) VALUES " +
                $"({cod_salida}, {id_producto}, {cantidad})";
            return Conexion.NonQuery(nonQuery);
        }
    }
}
