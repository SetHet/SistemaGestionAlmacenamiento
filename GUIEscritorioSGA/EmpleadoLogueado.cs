using GUIEscritorioSGA.ServiceEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUIEscritorioSGA
{
    public class EmpleadoLogueado
    {
        private static ServiceEmpleado.MDEmpleado empleado;

        public static MDEmpleado Empleado { get => empleado; set => empleado = value; }
    }
}
