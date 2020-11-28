using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NegocioSGA;
using ModeloDatosSGA;

namespace ServicioSGA
{
    /// <summary>
    /// Descripción breve de WebServiceSalida
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSalida : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Guardar(int id_sucursal, int id_bodega, string rut_empleado, DProductoCantidad[] listaProductoCantidad)
        {
            NegocioSalida negocioSalida = new NegocioSalida();
            return negocioSalida.Guardar(id_sucursal, id_bodega, rut_empleado, listaProductoCantidad);
        }
    }
}
