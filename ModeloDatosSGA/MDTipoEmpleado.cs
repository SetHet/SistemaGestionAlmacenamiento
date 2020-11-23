using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDTipoEmpleado
    {
        private int idTipoEmpleado;
        private string nombreTipo;

        public int IdTipoEmpleado { get => idTipoEmpleado; set => idTipoEmpleado = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
