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
    /// Descripción breve de WebServiceTipoProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTipoProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public MDTipoProducto Buscar(int id)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Select(id);
        }

        [WebMethod]
        public List<MDTipoProducto> BuscarAll()
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Select();
        }

        [WebMethod]
        public bool Delete(int id)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Delete(id);
        }

        [WebMethod]
        public bool InsertWithValues(string nombre)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Insert(nombre);
        }

        [WebMethod]
        public bool Insert(MDTipoProducto nuevoTipoProducto)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Insert(nuevoTipoProducto);
        }

        [WebMethod]
        public bool UpdateWithValues(int id, string nombre)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Update(id, nombre);
        }

        [WebMethod]
        public bool Update(MDTipoProducto editableTipoProducto)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.Update(editableTipoProducto);
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoActual()
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoActual();
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoActualByBodega(int id_bodega)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoActualByBodega(id_bodega);
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoEntrada()
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoEntrada();
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoEntradaByBodega(int id_bodega)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoEntradaByBodega(id_bodega);
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoSalida()
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoSalida();
        }

        [WebMethod]
        public List<DTipoProductoCantidad> GetCantidadTipoProductoSalidaByBodega(int id_bodega)
        {
            NegocioTipoProducto negocioTipoProducto = new NegocioTipoProducto();

            return negocioTipoProducto.GetCantidadTipoProductoSalidaByBodega(id_bodega);
        }
    }
}
