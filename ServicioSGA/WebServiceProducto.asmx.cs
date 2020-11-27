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
    /// Descripción breve de WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public MDProducto Buscar(int id)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Select(id);
        }

        [WebMethod]
        public List<MDProducto> BuscarAll()
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Select();
        }

        [WebMethod]
        public bool Delete(int id)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Delete(id);
        }

        [WebMethod]
        public bool InsertWithValues(int  id_tipo ,string nombre, string descripcion)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Insert(id_tipo ,nombre, descripcion);
        }

        [WebMethod]
        public bool Insert(MDProducto nuevoProducto)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Insert(nuevoProducto);
        }

        [WebMethod]
        public bool UpdateWithValues(int id, int id_tipo, string nombre, string descripcion)
        {
            //FALTA ID TIPO PRODUCTO QUE ES FORANEO
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Update(id, id_tipo, nombre, descripcion);
        }

        [WebMethod]
        public bool Update(MDProducto editableProducto)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            return negocioProducto.Update(editableProducto);
        }
    }
}
