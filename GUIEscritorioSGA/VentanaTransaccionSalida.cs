using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceBodega;
using GUIEscritorioSGA.ServiceProducto;
using GUIEscritorioSGA.ServiceSalida;
using GUIEscritorioSGA.ServiceSucursal;

namespace GUIEscritorioSGA
{
    public partial class VentanaTransaccionSalida : Form
    {
        #region Parametros
        private ServiceSucursal.WebServiceSucursalSoapClient auxServiceSucursal;
        private ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega;
        private ServiceProducto.WebServiceProductoSoapClient auxServiceProducto;
        private ServiceSalida.WebServiceSalidaSoapClient auxServiceSalida;

        private List<ServiceSucursal.MDSucursal> listaSucursales;
        private List<string> listaSucursalesString;

        private List<ServiceBodega.MDBodega> listaBodegas;
        private List<string> listaBodegasString;

        private List<ServiceProducto.MDProducto> listaProductos;
        private List<ServiceProducto.DProductoCantidad> listaProductoCantidadMaxima;
        private List<StructIDProductoMaxCantidad> listaProductoCantidad;

        private List<ServiceSalida.DProductoCantidad> listaProductoCantidadSalida;
        #endregion

        #region Propiedades
        public WebServiceSucursalSoapClient AuxServiceSucursal { get => auxServiceSucursal; set => auxServiceSucursal = value; }
        public WebServiceBodegaSoapClient AuxServiceBodega { get => auxServiceBodega; set => auxServiceBodega = value; }
        public WebServiceProductoSoapClient AuxServiceProducto { get => auxServiceProducto; set => auxServiceProducto = value; }
        public WebServiceSalidaSoapClient AuxServiceSalida { get => auxServiceSalida; set => auxServiceSalida = value; }
        public List<MDSucursal> ListaSucursales { get => listaSucursales; set => listaSucursales = value; }
        public List<string> ListaSucursalesString { get => listaSucursalesString; set => listaSucursalesString = value; }
        public List<MDBodega> ListaBodegas { get => listaBodegas; set => listaBodegas = value; }
        public List<string> ListaBodegasString { get => listaBodegasString; set => listaBodegasString = value; }
        public List<MDProducto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public List<ServiceProducto.DProductoCantidad> ListaProductoCantidadMaxima { get => listaProductoCantidadMaxima; set => listaProductoCantidadMaxima = value; }
        public List<StructIDProductoMaxCantidad> ListaProductoCantidad { get => listaProductoCantidad; set => listaProductoCantidad = value; }
        public List<ServiceSalida.DProductoCantidad> ListaProductoCantidadSalida { get => listaProductoCantidadSalida; set => listaProductoCantidadSalida = value; }



        #endregion

        public VentanaTransaccionSalida()
        {
            InitializeComponent();
            CargarContenido();
        }

        #region Estructuras
        public class StructIDProductoMaxCantidad
        {
            private int id;
            private string nombre;
            private int max;
            private int cantidad;

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Max { get => max; set => max = value; }
            public int Cantidad { get => cantidad; set => cantidad = value; }
        }
        #endregion

        #region Funciones

        private void CargarContenido()
        {
            AuxServiceSucursal = new WebServiceSucursalSoapClient();
            AuxServiceBodega = new WebServiceBodegaSoapClient();
            AuxServiceProducto = new WebServiceProductoSoapClient();
            AuxServiceSalida = new WebServiceSalidaSoapClient();

            CargarSucursales();
            CargarBodegas();
            CargarEmpleado();
        }

        public void CargarSucursales()
        {
            ListaSucursales = AuxServiceSucursal.BuscarAll().ToList();
            ListaSucursalesString = new List<string>();

            foreach (var sucursal in ListaSucursales)
            {
                ListaSucursalesString.Add(sucursal.Nombre);
            }

            ComboBox_Sucursal.DataSource = ListaSucursalesString;
        }

        public void CargarBodegas()
        {
            ListaBodegas = AuxServiceBodega.BuscarAll().ToList();
            ListaBodegasString = new List<string>();

            foreach (var bodega in ListaBodegas)
            {
                ListaBodegasString.Add(bodega.Nombre);
            }

            ComboBox_Bodega.DataSource = ListaBodegasString;
        }

        public void CargarEmpleado()
        {
            Txt_Empleado.Text = EmpleadoLogueado.Empleado.Rut;
        }



        #endregion

        #region Eventos

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }



        

        private void Btn_Completar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_0_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_menos10_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_menos1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_mas1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_mas10_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_max_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaProductos = AuxServiceProducto.BuscarAll().ToList();
            int id_bodega = ListaBodegas[ComboBox_Bodega.SelectedIndex].IdBodega;
            ListaProductoCantidadMaxima = AuxServiceProducto.GetCantidadProductoDifferenciaByBodega(id_bodega).ToList();
            ListaProductoCantidad = new List<StructIDProductoMaxCantidad>();
            StructIDProductoMaxCantidad auxIDProductoMaxCantidad;
            Dictionary<int, int> diccProductoCantidadMaxima = new Dictionary<int, int>();

            //Pasar los valores maximos al dicc
            foreach (var productoCantidadMax in ListaProductoCantidadMaxima)
            {
                diccProductoCantidadMaxima[productoCantidadMax.IdProducto] = productoCantidadMax.Cantidad;
            }

            //Crear la lista de productos con stock
            foreach (var producto in ListaProductos)
            {
                if (diccProductoCantidadMaxima.ContainsKey(producto.IdProducto))
                {
                    auxIDProductoMaxCantidad = new StructIDProductoMaxCantidad();
                    auxIDProductoMaxCantidad.Id = producto.IdProducto;
                    auxIDProductoMaxCantidad.Nombre = producto.Nombre;
                    auxIDProductoMaxCantidad.Max = diccProductoCantidadMaxima[producto.IdProducto];
                    auxIDProductoMaxCantidad.Cantidad = 0;
                    ListaProductoCantidad.Add(auxIDProductoMaxCantidad);
                }
            }

            //Asignar al data grid view
            DataGridView_ProductosCantidad.DataSource = ListaProductoCantidad;
        }

        #endregion
    }
}
