using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatosSGA;


namespace NegocioSGA
{
    public class NegocioSalida
    {
        public bool Guardar(int id_sucursal, int id_bodega, string rut_empleado, DProductoCantidad[] listaProductoCantidad)
        {
            NegocioSalidaCabecera negSalidaCabecera = new NegocioSalidaCabecera();
            NegocioSalidaDetalle negSalidaDetalle = new NegocioSalidaDetalle();
            MDSalidaCabecera salidaCabecera = new MDSalidaCabecera();
            MDSalidaDetalle salidaDetalle;

            salidaCabecera.Fecha = DateTime.Now;
            salidaCabecera.Id_bodega = id_bodega;
            salidaCabecera.Id_sucursal = id_sucursal;
            salidaCabecera.Rut_empleado = rut_empleado;

            if (!negSalidaCabecera.Insert(salidaCabecera))
            {
                Console.WriteLine("No se pudo Guardar el registro de salida");
                return false;
            }

            int cod_salida = negSalidaCabecera.SelectLast().Cod_salida;


            foreach (var itemProdCant in listaProductoCantidad)
            {
                if (itemProdCant.Cantidad > 0)
                {
                    salidaDetalle = new MDSalidaDetalle();
                    salidaDetalle.Cantidad = itemProdCant.Cantidad;
                    salidaDetalle.Id_producto = itemProdCant.IdProducto;
                    salidaDetalle.Cod_salida = cod_salida;
                    if (!negSalidaDetalle.Insert(salidaDetalle))
                    {
                        Console.WriteLine("No se pudo Guardar el registro de salida del producto " + itemProdCant.IdProducto);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
