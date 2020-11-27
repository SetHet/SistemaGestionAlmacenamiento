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
    /// Descripción breve de WebServiceSucursal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProveedor : System.Web.Services.WebService
    {

        [WebMethod]
        public MDProveedor Buscar(int id)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Select(id);
        }

        [WebMethod]
        public List<MDProveedor> BuscarAll()
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Select();
        }

        [WebMethod]
        public bool Delete(int id)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Delete(id);
        }

        [WebMethod]
        public bool InsertWithValues(string nombre, string direccion)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Insert(nombre, direccion);
        }

        [WebMethod]
        public bool Insert(MDProveedor nuevoProveedor)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Insert(nuevoProveedor);
        }

        [WebMethod]
        public bool UpdateWithValues(int id, string nombre, string direccion)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Update(id, nombre, direccion);
        }

        [WebMethod]
        public bool Update(MDProveedor editableProveedor)
        {
            NegocioProveedor negocioProveedor = new NegocioProveedor();

            return negocioProveedor.Update(editableProveedor);
        }
    }
}
