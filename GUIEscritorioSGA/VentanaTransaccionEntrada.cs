using GUIEscritorioSGA.ServiceBodega;
using GUIEscritorioSGA.ServiceEntrada;
using GUIEscritorioSGA.ServiceProducto;
using GUIEscritorioSGA.ServiceProveedor;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIEscritorioSGA
{
    public partial class VentanaTransaccionEntrada : Form
    {
        #region Parametros
        private ServiceEntrada.WebServiceEntradaSoapClient auxServiceEntrada;
        private ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega;
        private ServiceProveedor.WebServiceProveedorSoapClient auxServiceProveedor;
        private ServiceProducto.WebServiceProductoSoapClient auxServiceProducto;

        private List<ServiceBodega.MDBodega> listaBodegas;
        private List<string> listaBodegasString;

        private List<ServiceProveedor.MDProveedor> listaProveedores;
        private List<string> listaProveedoresString;

        private List<ServiceProducto.MDProducto> listaProductos;
        private List<DataIDProductoCantidad> listaIDProductoCantidad;

        private List<ServiceEntrada.DProductoCantidad> listaProductoCantidad;
        #endregion

        #region Propiedades

        public WebServiceEntradaSoapClient AuxServiceEntrada { get => auxServiceEntrada; set => auxServiceEntrada = value; }
        public WebServiceBodegaSoapClient AuxServiceBodega { get => auxServiceBodega; set => auxServiceBodega = value; }
        public WebServiceProveedorSoapClient AuxServiceProveedor { get => auxServiceProveedor; set => auxServiceProveedor = value; }
        public WebServiceProductoSoapClient AuxServiceProducto { get => auxServiceProducto; set => auxServiceProducto = value; }
        public List<MDBodega> ListaBodegas { get => listaBodegas; set => listaBodegas = value; }
        public List<string> ListaBodegasString { get => listaBodegasString; set => listaBodegasString = value; }
        public List<MDProveedor> ListaProveedores { get => listaProveedores; set => listaProveedores = value; }
        public List<string> ListaProveedoresString { get => listaProveedoresString; set => listaProveedoresString = value; }
        public List<MDProducto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        private List<DataIDProductoCantidad> ListaIDProductoCantidad { get => listaIDProductoCantidad; set => listaIDProductoCantidad = value; }
        public List<ServiceEntrada.DProductoCantidad> ListaProductoCantidad { get => listaProductoCantidad; set => listaProductoCantidad = value; }

        #endregion

        #region Estructuras
        private class DataIDProductoCantidad
        {
            private int id;
            private string nombre;
            private int cantidad;

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Cantidad { get => cantidad; set => cantidad = value; }
        }
        #endregion

        public VentanaTransaccionEntrada()
        {
            InitializeComponent();

            CargarContenido();
        }

        #region Funciones

        private void CargarContenido()
        {
            AuxServiceEntrada = new WebServiceEntradaSoapClient();
            AuxServiceBodega = new WebServiceBodegaSoapClient();
            AuxServiceProveedor = new WebServiceProveedorSoapClient();
            AuxServiceProducto = new WebServiceProductoSoapClient();

            RellenarComboBoxBodegas();
            RellenarComboBoxProveedores();
            RellenarTxtEmpleado();
            RellenarProductos();
        }
        
        private void RellenarComboBoxBodegas()
        {
            ListaBodegas = AuxServiceBodega.BuscarAll().ToList();
            ListaBodegasString = new List<string>();

            foreach (var bodega in ListaBodegas)
            {
                ListaBodegasString.Add(bodega.Nombre);
                
            }

            ComboBox_Bodega.DataSource = ListaBodegasString;
        }

        private void RellenarComboBoxProveedores()
        {
            ListaProveedores = AuxServiceProveedor.BuscarAll().ToList();
            ListaProveedoresString = new List<string>();

            foreach (var proveedor in ListaProveedores)
            {
                ListaProveedoresString.Add(proveedor.Nombre);
            }

            ComboBox_Proveedor.DataSource = ListaProveedoresString;
        }

        private void RellenarTxtEmpleado()
        {
            Txt_Empleado.Text = EmpleadoLogueado.Empleado.Rut;
        }

        private void RellenarProductos()
        {
            ListaProductos = AuxServiceProducto.BuscarAll().ToList();
            ListaIDProductoCantidad = new List<DataIDProductoCantidad>();
            DataIDProductoCantidad auxDataIDProductoCantidad;
            
            foreach (var producto in ListaProductos)
            {
                auxDataIDProductoCantidad = new DataIDProductoCantidad();
                auxDataIDProductoCantidad.Id = producto.IdProducto;
                auxDataIDProductoCantidad.Nombre = producto.Nombre;
                auxDataIDProductoCantidad.Cantidad = 0;
                ListaIDProductoCantidad.Add(auxDataIDProductoCantidad);
            }

            ActualizarListaProductosCantidad();
        }

        private void ActualizarListaProductosCantidad()
        {
            DataGridView_ProductosCantidad.DataSource = ListaIDProductoCantidad;
            DataGridView_ProductosCantidad.Update();
            DataGridView_ProductosCantidad.Refresh();
        }

        private bool isSelectedProducto()
        {
            return DataGridView_ProductosCantidad.SelectedRows.Count > 0;
        }

        private int SelectedProducto()
        {
            if (isSelectedProducto())
            {
                return DataGridView_ProductosCantidad.SelectedRows[0].Index;
            }
            return -1;
        }

        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Btn_Completar_Click(object sender, EventArgs e)
        {
            ListaProductoCantidad = new List<ServiceEntrada.DProductoCantidad>();
            ServiceEntrada.DProductoCantidad auxProductoCantidad;

            foreach (var itemIDProductoCantidad in ListaIDProductoCantidad)
            {
                if (itemIDProductoCantidad.Cantidad > 0)
                {
                    auxProductoCantidad = new ServiceEntrada.DProductoCantidad();
                    auxProductoCantidad.Cantidad = itemIDProductoCantidad.Cantidad;
                    auxProductoCantidad.IdProducto = itemIDProductoCantidad.Id;
                    ListaProductoCantidad.Add(auxProductoCantidad);
                }
            }

            int id_bodega = ListaBodegas[ComboBox_Bodega.SelectedIndex].IdBodega;
            int id_proveedor = ListaProveedores[ComboBox_Proveedor.SelectedIndex].IdProveedor;
            string rut_empleado = Txt_Empleado.Text;

            if (ListaProductoCantidad.Count <= 0)
            {
                MessageBox.Show("Se han seleccionado 0 productos, Ingrese alguno para poder completar la entrada");
                return;
            }

            bool resultadoGuardado = AuxServiceEntrada.Guardar(id_proveedor, id_bodega, rut_empleado, ListaProductoCantidad.ToArray());

            if (resultadoGuardado)
            {
                MessageBox.Show("Se han guardado toda la Entrada de Productos");
                CargarContenido();
            }
            else
            {
                MessageBox.Show("No se han guardado toda la Entrada de Productos");
            }
        }

        private void Btn_Cant_0_Click(object sender, EventArgs e)
        {
            if (isSelectedProducto())
            {
                int index = SelectedProducto();
                ListaIDProductoCantidad[index].Cantidad = 0;
                ActualizarListaProductosCantidad();
            }
        }

        private void Btn_Cant_menos10_Click(object sender, EventArgs e)
        {
            if (isSelectedProducto())
            {
                int index = SelectedProducto();
                ListaIDProductoCantidad[index].Cantidad -= 10;
                if (ListaIDProductoCantidad[index].Cantidad < 0)
                {
                    ListaIDProductoCantidad[index].Cantidad = 0;
                }
                ActualizarListaProductosCantidad();
            }
        }

        private void Btn_Cant_menos1_Click(object sender, EventArgs e)
        {
            if (isSelectedProducto())
            {
                int index = SelectedProducto();
                ListaIDProductoCantidad[index].Cantidad -= 1;
                if (ListaIDProductoCantidad[index].Cantidad < 0)
                {
                    ListaIDProductoCantidad[index].Cantidad = 0;
                }
                ActualizarListaProductosCantidad();
            }
        }

        private void Btn_Cant_mas1_Click(object sender, EventArgs e)
        {
            if (isSelectedProducto())
            {
                int index = SelectedProducto();
                ListaIDProductoCantidad[index].Cantidad += 1;
                ActualizarListaProductosCantidad();
            }
        }

        private void Btn_Cant_mas10_Click(object sender, EventArgs e)
        {
            if (isSelectedProducto())
            {
                int index = SelectedProducto();
                ListaIDProductoCantidad[index].Cantidad += 10;
                ActualizarListaProductosCantidad();
            }
        }

        private void ComboBox_Proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
