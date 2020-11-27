using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatosSGA;
using ConexionBD;

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



            return null;
        }

    }
}
