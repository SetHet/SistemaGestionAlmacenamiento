using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatosSGA
{
    public class MDEmpleado
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string password;
        

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        
    }
}
