using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ModeloDatosSGA;
using NegocioSGA;

namespace ServicioSGA
{
    /// <summary>
    /// Descripción breve de WebServiceEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceEmpleado : System.Web.Services.WebService
    {

        [WebMethod]
        public MDEmpleado Login(string rut, string password)
        {
            NegocioEmpleado negEmpleado = new NegocioEmpleado();
            MDEmpleado empleado = negEmpleado.Login(rut, password);
            return empleado;
        }
    

    [WebMethod]
        public MDEmpleado Buscar(string rut)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Select(rut);
        }

        [WebMethod]
        public List<MDEmpleado> BuscarAll()
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Select();
        }

        [WebMethod]
        public bool Delete(string rut)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Delete(rut);
        }

        [WebMethod]
        public bool InsertWithValues(string rut, string nombre, string apellido, string password)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Insert(rut , nombre, apellido , password);
        }

        [WebMethod]
        public bool Insert(MDEmpleado nuevoEmpleado)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Insert(nuevoEmpleado);
        }

        [WebMethod]
        public bool UpdateWithValues(string rut, string nombre, string apellido, string password)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Update(rut, nombre, apellido,password);
        }

        [WebMethod]
        public bool Update(MDEmpleado editableEmpleado)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();

            return auxEmpleado.Update(editableEmpleado);
        }
    }
}
