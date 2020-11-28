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
    public class NegocioSucursal
    {
        private ConexionSQLServer conexion;
        private MDSucursal sucursal;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDSucursal Sucursal { get => sucursal; set => sucursal = value; }

        public NegocioSucursal()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDSucursal Select(int id)
        {
            string query = $"SELECT TOP (1) * FROM Sucursal WHERE id_sucursal = {id}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                Sucursal = new MDSucursal();
                Sucursal.IdSucursal = Convert.ToInt32(table.Rows[0]["id_sucursal"]);
                Sucursal.Nombre = table.Rows[0]["nombre"].ToString();
                Sucursal.Direccion = table.Rows[0]["direccion"].ToString();
            }
            else
            {
                Sucursal= null;
            }

            return Sucursal;
        }

        public List<MDSucursal> Select()
        {
            string query = $"SELECT * FROM Sucursal";

            DataTable table = Conexion.Select(query);
            List<MDSucursal> lista = new List<MDSucursal>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Sucursal = new MDSucursal();
                    Sucursal.IdSucursal = Convert.ToInt32(row["id_sucursal"]);
                    Sucursal.Nombre = row["nombre"].ToString();
                    Sucursal.Direccion = row["direccion"].ToString();
                    lista.Add(Sucursal);
                }

            }

            Sucursal = null;

            return lista;
        }

        public bool Delete(int id)
        {
            string nonQuery = $"DELETE FROM Sucursal WHERE id_sucursal = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDSucursal nuevoSucursal)
        {
            string nonQuery = $"INSERT INTO Sucursal (nombre, direccion) VALUES ('{nuevoSucursal.Nombre}', '{nuevoSucursal.Direccion}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(string nombre,string direccion)
        {
            MDSucursal auxSucursal = new MDSucursal();
            auxSucursal.IdSucursal = 0;
            auxSucursal.Nombre = nombre;
            auxSucursal.Direccion = direccion;
            return Insert(auxSucursal);
        }

        public bool Update(int id, string nombre, string direccion)
        {
            string nonQuery = $"UPDATE Sucursal SET nombre = '{nombre}', direccion = '{direccion}' WHERE id_sucursal = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDSucursal editableSucursal)
        {
            return Update(editableSucursal.IdSucursal, editableSucursal.Nombre, editableSucursal.Direccion);
        }
    }
}
