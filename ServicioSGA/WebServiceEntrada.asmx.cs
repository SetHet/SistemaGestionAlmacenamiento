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
    /// Descripción breve de WebServiceEntrada
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceEntrada : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Guardar(int id_proveedor, int id_bodega, string rut_empleado, DProductoCantidad[] listaProductoCantidad)
        {
            NegocioEntrada negocioEntrada = new NegocioEntrada();
            return negocioEntrada.Guardar(id_proveedor, id_bodega, rut_empleado, listaProductoCantidad);
        }
    }
}
