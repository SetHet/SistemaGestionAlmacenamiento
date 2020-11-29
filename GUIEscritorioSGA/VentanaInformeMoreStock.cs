using GUIEscritorioSGA.ServiceBodega;
using GUIEscritorioSGA.ServiceProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIEscritorioSGA
{
    public partial class VentanaInformeMoreStock : Form
    {
        #region Parametros
        private ServiceProducto.WebServiceProductoSoapClient auxServiceProducto;
        private ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega;

        private List<ServiceBodega.MDBodega> listaBodegas;
        private List<string> listaBodegasString;

        private List<ServiceProducto.MDProducto> listaProductos;
        private List<ServiceProducto.DProductoCantidad> listaProductoCantidad;
        private List<IDProductoCantidad> listaIDProductoCantidad;
        private Dictionary<int, int> diccProductoCantidad;



        #endregion

        #region Propiedades
        public WebServiceProductoSoapClient AuxServiceProducto { get => auxServiceProducto; set => auxServiceProducto = value; }
        public WebServiceBodegaSoapClient AuxServiceBodega { get => auxServiceBodega; set => auxServiceBodega = value; }
        public List<MDBodega> ListaBodegas { get => listaBodegas; set => listaBodegas = value; }
        public List<string> ListaBodegasString { get => listaBodegasString; set => listaBodegasString = value; }
        public List<MDProducto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public List<DProductoCantidad> ListaProductoCantidad { get => listaProductoCantidad; set => listaProductoCantidad = value; }
        public List<IDProductoCantidad> ListaIDProductoCantidad { get => listaIDProductoCantidad; set => listaIDProductoCantidad = value; }
        public Dictionary<int, int> DiccProductoCantidad { get => diccProductoCantidad; set => diccProductoCantidad = value; }


        #endregion

        #region Estructuras
        public class IDProductoCantidad
        {
            private int top;
            private int id;
            private string nombre;
            private int cantidad;

            public int Top { get => top; set => top = value; }
            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Cantidad { get => cantidad; set => cantidad = value; }
        }
        #endregion

        public VentanaInformeMoreStock()
        {
            InitializeComponent();
            CargarContenido();
        }

        #region Funciones
        private void CargarContenido()
        {
            AuxServiceBodega = new WebServiceBodegaSoapClient();
            AuxServiceProducto = new WebServiceProductoSoapClient();

            CargarBodegas();
        }

        private void CargarBodegas()
        {
            ListaBodegas = AuxServiceBodega.BuscarAll().ToList();
            ListaBodegasString = new List<string>();

            ListaBodegasString.Add("TODAS");

            foreach (var bodega in ListaBodegas)
            {
                ListaBodegasString.Add(bodega.Nombre);
            }

            ComboBox_Bodegas.DataSource = ListaBodegasString;
        }

        private void CargarProductos()
        {
            ListaProductos = AuxServiceProducto.BuscarAll().ToList();
            ListaIDProductoCantidad = new List<IDProductoCantidad>();
            DiccProductoCantidad = new Dictionary<int, int>();
            IDProductoCantidad auxIdProductoCantidad;

            if (ComboBox_Bodegas.SelectedIndex <= 0)
            {
                //Todas las Bodegas
                ListaProductoCantidad = AuxServiceProducto.GetCantidadProductoDifferencia().ToList();
            }
            else
            {
                //Bodega especificada
                int id_bodega = ListaBodegas[ComboBox_Bodegas.SelectedIndex - 1].IdBodega;
                ListaProductoCantidad = AuxServiceProducto.GetCantidadProductoDifferenciaByBodega(id_bodega).ToList();
            }

            //Rellenar Diccionario de cantidades
            foreach (var prod_cant in ListaProductoCantidad)
            {
                DiccProductoCantidad[prod_cant.IdProducto] = prod_cant.Cantidad;
            }

            //Rellenar lista de productos
            foreach (var producto in ListaProductos)
            {
                auxIdProductoCantidad = new IDProductoCantidad();
                auxIdProductoCantidad.Top = 0;
                auxIdProductoCantidad.Id = producto.IdProducto;
                auxIdProductoCantidad.Nombre = producto.Nombre;
                if (DiccProductoCantidad.ContainsKey(producto.IdProducto))
                {
                    auxIdProductoCantidad.Cantidad = DiccProductoCantidad[producto.IdProducto];
                }
                else
                {
                    auxIdProductoCantidad.Cantidad = 0;
                }
                ListaIDProductoCantidad.Add(auxIdProductoCantidad);
            }

            //Ordenar lista
            ListaIDProductoCantidad = ListaIDProductoCantidad.OrderByDescending(registro => registro.Cantidad).ToList();
            int posicion = 1;
            foreach (var id_prod_cant in ListaIDProductoCantidad)
            {
                id_prod_cant.Top = posicion;
                posicion++;
            }

            //Ingresar en la DataGridView
            DataGridView_ListaProductos.DataSource = ListaIDProductoCantidad;
            //DataGridView_ListaProductos.Sort(DataGridView_ListaProductos.Columns[2], ListSortDirection.Descending);
        }
        #endregion


        #region Eventos

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void ComboBox_Bodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        #endregion
    }
}
