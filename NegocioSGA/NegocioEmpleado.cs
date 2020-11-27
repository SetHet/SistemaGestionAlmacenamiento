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
        private MDEmpleado empleado;

        public ConexionSQLServer Conexion { get => conexion; set => conexion = value; }
        public MDEmpleado Empleado { get => empleado; set => empleado = value; }

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

    }
}
