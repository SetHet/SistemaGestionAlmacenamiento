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
    public class NegocioProveedor
    {
        private ConexionSQLServer conexion;
        private MDProveedor proveedor;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDProveedor Proveedor { get => proveedor; set => proveedor = value; }

        public NegocioProveedor()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDProveedor Select(int id)
        {
            string query = $"SELECT TOP (1) * FROM Proveedor WHERE id_proveedor = {id}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                Proveedor = new MDProveedor();
                Proveedor.IdProveedor = Convert.ToInt32(table.Rows[0]["id_proveedor"]);
                Proveedor.Nombre = table.Rows[0]["nombre"].ToString();
                Proveedor.Direccion = table.Rows[0]["direccion"].ToString();
            }
            else
            {
                Proveedor = null;
            }

            return Proveedor;
        }

        public List<MDProveedor> Select()
        {
            string query = $"SELECT * FROM Proveedor";

            DataTable table = Conexion.Select(query);
            List<MDProveedor> lista = new List<MDProveedor>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Proveedor = new MDProveedor();
                    Proveedor.IdProveedor = Convert.ToInt32(row["id_proveedor"]);
                    Proveedor.Nombre = row["nombre"].ToString();
                    Proveedor.Direccion = row["direccion"].ToString();
                    lista.Add(Proveedor);
                }

            }

            Proveedor = null;

            return lista;
        }

        public bool Delete(int id)
        {
            string nonQuery = $"DELETE FROM Proveedor WHERE id_proveedor = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDProveedor nuevoProveedor)
        {
            string nonQuery = $"INSERT INTO Proveedor (nombre,direccion) VALUES ('{nuevoProveedor.Nombre}','{nuevoProveedor.Direccion}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(string nombre, string direccion)
        {
            MDProveedor auxProveedor = new MDProveedor();
            auxProveedor.IdProveedor = 0;
            auxProveedor.Nombre = nombre;
            auxProveedor.Direccion = direccion;
            return Insert(auxProveedor);
        }

        public bool Update(int id, string nombre, string direccion)
        {
            string nonQuery = $"UPDATE Proveedor SET nombre = '{nombre}', direccion = '{direccion}' WHERE id_proveedor = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDProveedor editableProveedor)
        {
            return Update(editableProveedor.IdProveedor, editableProveedor.Nombre, editableProveedor.Direccion);
        }
    }
}
