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



        #endregion

        public VentanaTransaccionSalida()
        {
            InitializeComponent();
            CargarContenido();
        }

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
            //Cargar los productos
        }

        #endregion
    }
}
