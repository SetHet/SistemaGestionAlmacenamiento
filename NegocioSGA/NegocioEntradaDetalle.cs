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
    public class NegocioEntradaDetalle
    {
        private ConexionSQLServer conexion;
        private MDEntradaDetalle entradaDetalle;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDEntradaDetalle EntradaDetalle { get => entradaDetalle; set => entradaDetalle = value; }

        public NegocioEntradaDetalle()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDEntradaDetalle Select(int cod_entrada, int id_producto)
        {
            string query = $"SELECT TOP (1) * FROM EntradaDetalle WHERE cod_entrada = {cod_entrada} AND id_producto = {id_producto}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                EntradaDetalle = new MDEntradaDetalle();
                EntradaDetalle.Cod_entrada = Convert.ToInt32(table.Rows[0]["cod_entrada"]);
                EntradaDetalle.Id_producto = Convert.ToInt32(table.Rows[0]["id_producto"]);
                EntradaDetalle.Cantidad = Convert.ToInt32(table.Rows[0]["cantidad"]);
            }
            else
            {
                EntradaDetalle = null;
            }

            return EntradaDetalle;
        }

        public List<MDEntradaDetalle> Select()
        {
            string query = $"SELECT * FROM EntradaDetalle";

            DataTable table = Conexion.Select(query);
            List<MDEntradaDetalle> lista = new List<MDEntradaDetalle>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EntradaDetalle = new MDEntradaDetalle();
                    EntradaDetalle.Cod_entrada = Convert.ToInt32(row["cod_entrada"]);
                    EntradaDetalle.Id_producto = Convert.ToInt32(row["id_producto"]);
                    EntradaDetalle.Cantidad = Convert.ToInt32(row["cantidad"]);
                    lista.Add(EntradaDetalle);
                }

            }

            EntradaDetalle = null;

            return lista;
        }


        public bool Insert(MDEntradaDetalle nuevoEntradaCabecera)
        {
            return Insert(nuevoEntradaCabecera.Cod_entrada, nuevoEntradaCabecera.Id_producto, nuevoEntradaCabecera.Cantidad);
        }

        public bool Insert(int cod_entrada, int id_producto, int cantidad)
        {
            string nonQuery = $"INSERT INTO EntradaDetalle (cod_entrada, id_producto, cantidad) VALUES " +
                $"({cod_entrada}, {id_producto}, {cantidad})";
            return Conexion.NonQuery(nonQuery);
        }
    }
}
