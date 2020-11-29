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
    /// Descripción breve de WebServiceBodega
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBodega : System.Web.Services.WebService
    {

        [WebMethod]
        public MDBodega Buscar(int id)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Select(id);
        }

        [WebMethod]
        public List<MDBodega> BuscarAll()
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Select();
        }

        [WebMethod]
        public bool Delete(int id)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Delete(id);
        }

        [WebMethod]
        public bool InsertWithValues(string nombre, string direccion)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Insert(nombre, direccion);
        }

        [WebMethod]
        public bool Insert(MDBodega nuevoTipoProducto)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Insert(nuevoTipoProducto);
        }

        [WebMethod]
        public bool UpdateWithValues(int id, string nombre, string direccion)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Update(id, nombre, direccion);
        }

        [WebMethod]
        public bool Update(MDBodega editableBodega)
        {
            NegocioBodega auxBodega = new NegocioBodega();

            return auxBodega.Update(editableBodega);
        }
    }
}
