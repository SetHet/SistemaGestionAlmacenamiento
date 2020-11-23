using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDEstado
    {
        private int idEstado;
        private string nombreEstado;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
    }
}
