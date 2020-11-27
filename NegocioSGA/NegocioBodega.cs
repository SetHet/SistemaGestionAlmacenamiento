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
    public class NegocioBodega
    {
        private ConexionSQLServer conexion;
        private MDBodega bodega;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDBodega Bodega { get => bodega; set => bodega = value; }

        public NegocioBodega()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }

        public MDBodega Select(int id)
        {
            string query = $"SELECT TOP (1) * FROM Bodega WHERE id_bodega = {id}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                Bodega = new MDBodega();
                Bodega.IdBodega = Convert.ToInt32(table.Rows[0]["id_bodega"]);
                Bodega.Nombre = table.Rows[0]["nombre_Bodega"].ToString();
                Bodega.Direccion = table.Rows[0]["direccion_bodega"].ToString();
            }
            else
            {
                Bodega = null;
            }

            return Bodega;
        }

        public List<MDBodega> Select()
        {
            string query = $"SELECT * FROM Bodega";

            DataTable table = Conexion.Select(query);
            List<MDBodega> lista = new List<MDBodega>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Bodega = new MDBodega();
                    Bodega.IdBodega = Convert.ToInt32(row["id_bodega"]);
                    Bodega.Nombre = row["nombre_Bodega"].ToString();
                    Bodega.Direccion = row["direccion_bodega"].ToString();
                    lista.Add(Bodega);
                }

            }

            Bodega = null;

            return lista;
        }

        public bool Delete(int id)
        {
            string nonQuery = $"DELETE FROM Bodega WHERE id_bodega = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDBodega nuevoBodega)
        {
            string nonQuery = $"INSERT INTO Bodega (nombre_bodega,direccion_bodega) VALUES ('{nuevoBodega.Nombre}','{nuevoBodega.Direccion}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(string nombre, string direccion)
        {
            MDBodega auxBodega = new MDBodega();
            auxBodega.IdBodega = 0;
            auxBodega.Nombre = nombre;
            auxBodega.Direccion = direccion;
            return Insert(auxBodega);
        }

        public bool Update(int id, string nombre, string direccion)
        {
            string nonQuery = $"UPDATE Bodega SET nombre_bodega = '{nombre}', direccion_bodega = '{direccion}' WHERE id_bodega = {id}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDBodega editableBodega)
        {
            return Update(editableBodega.IdBodega, editableBodega.Nombre, editableBodega.Direccion);
        }
    }
}
