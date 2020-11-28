using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatosSGA;
using System.Windows.Forms;

namespace NegocioSGA
{
    public class NegocioEntrada
    {
        
        public bool Guardar(int id_proveedor, int id_bodega, string rut_empleado, DProductoCantidad[] listaProductoCantidad)
        {
            NegocioEntradaCabecera negEntradaCabecera = new NegocioEntradaCabecera();
            NegocioEntradaDetalle negEntradaDetalle = new NegocioEntradaDetalle();
            MDEntradaCabecera entradaCabecera = new MDEntradaCabecera();
            MDEntradaDetalle entradaDetalle;
            
            entradaCabecera.Fecha = DateTime.Now;
            entradaCabecera.Id_bodega = id_bodega;
            entradaCabecera.Id_proveedor = id_proveedor;
            entradaCabecera.Rut_empleado = rut_empleado;

            if (!negEntradaCabecera.Insert(entradaCabecera))
            {
                MessageBox.Show("No se pudo Guardar el registro de entrada");
                return false;
            }

            int cod_entrada = negEntradaCabecera.SelectLast().Cod_entrada;


            foreach (var itemProdCant in listaProductoCantidad)
            {
                if (itemProdCant.Cantidad > 0)
                {
                    entradaDetalle = new MDEntradaDetalle();
                    entradaDetalle.Cantidad = itemProdCant.Cantidad;
                    entradaDetalle.Id_producto = itemProdCant.IdProducto;
                    entradaDetalle.Cod_entrada = cod_entrada;
                    if (!negEntradaDetalle.Insert(entradaDetalle))
                    {
                        MessageBox.Show("No se pudo Guardar el registro de entrada del producto " + itemProdCant.IdProducto);
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
