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
    public class WebServiceSucursal : System.Web.Services.WebService
    {

        [WebMethod]
        public MDSucursal Buscar(int id)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Select(id);
        }

        [WebMethod]
        public List<MDSucursal> BuscarAll()
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Select();
        }

        [WebMethod]
        public bool Delete(int id)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Delete(id);
        }

        [WebMethod]
        public bool InsertWithValues(string nombre, string direccion)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Insert(nombre,direccion);
        }

        [WebMethod]
        public bool Insert(MDSucursal nuevoTipoProducto)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Insert(nuevoTipoProducto);
        }

        [WebMethod]
        public bool UpdateWithValues(int id, string nombre, string direccion)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Update(id, nombre,direccion);
        }

        [WebMethod]
        public bool Update(MDSucursal editableSucursal)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            return negocioSucursal.Update(editableSucursal);
        }
    }
}
