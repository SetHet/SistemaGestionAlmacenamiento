using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatosSGA;
using ConexionBD;
using System.Data;

namespace NegocioSGA
{
    public class NegocioEmpleado
    {
        private ConexionSQLServer conexion;
        private MDEmpleado bodega;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDEmpleado Empleado { get => bodega; set => bodega = value; }

        public NegocioEmpleado()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = ConfiguracionNegocioSGA.Server;
            Conexion.DataBase = ConfiguracionNegocioSGA.DataBase;
            Conexion.Conectar();
        }
        public void NewEmpleado()
        {
            Empleado = new MDEmpleado();
        }

        public MDEmpleado Login(string rut, string password)
        {
            string query = $"SELECT TOP (1) * FROM Empleado WHERE rut_empleado = '{rut}' AND password = '{password}'";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                NewEmpleado();

                Empleado.Rut = table.Rows[0]["rut_empleado"].ToString();
                Empleado.Nombre = table.Rows[0]["nombre"].ToString();
                Empleado.Apellido = table.Rows[0]["apellido"].ToString();
                Empleado.Password = table.Rows[0]["password"].ToString();

                return Empleado;
            }
            else
            {
                return null;
            }
        }

        public MDEmpleado Select(string rut)
        {
            string query = $"SELECT TOP (1) * FROM Empleado WHERE rut_empleado = {rut}";

            DataTable table = Conexion.Select(query);

            if (table != null && table.Rows.Count > 0)
            {
                Empleado = new MDEmpleado();             
                Empleado.Rut = table.Rows[0]["rut_empleado"].ToString();
                Empleado.Nombre = table.Rows[0]["nombre"].ToString();
                Empleado.Apellido = table.Rows[0]["apellido"].ToString();
                Empleado.Password = table.Rows[0]["password"].ToString();
            }
            else
            {
                Empleado = null;
            }

            return Empleado;
        }

        public List<MDEmpleado> Select()
        {
            string query = $"SELECT * FROM Empleado";

            DataTable table = Conexion.Select(query);
            List<MDEmpleado> lista = new List<MDEmpleado>();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Empleado = new MDEmpleado();
                    Empleado.Rut = row["rut_empleado"].ToString();
                    Empleado.Nombre = row["nombre"].ToString();
                    Empleado.Apellido = row["apellido"].ToString();
                    Empleado.Password = row["password"].ToString();
                    lista.Add(Empleado);
                }

            }

            Empleado = null;

            return lista;
        }

        public bool Delete(string rut)
        {
            string nonQuery = $"DELETE FROM Empleado WHERE rut_empleado = {rut}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(MDEmpleado nuevoEmpleado)
        {
            string nonQuery = $"INSERT INTO Empleado (rut_empleado,nombre,apellido,password) VALUES ('{nuevoEmpleado.Rut}','{nuevoEmpleado.Nombre}','{nuevoEmpleado.Apellido}','{nuevoEmpleado.Password}')";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Insert(string rut , string nombre, string apellido, string password)
        {
            MDEmpleado auxEmpleado = new MDEmpleado();
            auxEmpleado.Rut = rut;
            auxEmpleado.Nombre = nombre;
            auxEmpleado.Apellido = apellido;
            auxEmpleado.Password = password;
            return Insert(auxEmpleado);
        }

        public bool Update(string rut, string nombre, string apellido, string password)
        {
            string nonQuery = $"UPDATE Empleado SET rut_empleado = '{rut}',nombre = '{nombre}', apellido = '{apellido}',password = '{password}' WHERE rut_empleado = {rut}";
            return Conexion.NonQuery(nonQuery);
        }

        public bool Update(MDEmpleado editableEmpleado)
        {
            return Update(editableEmpleado.Rut, editableEmpleado.Apellido, editableEmpleado.Nombre, editableEmpleado.Password);
        }
    }
}
