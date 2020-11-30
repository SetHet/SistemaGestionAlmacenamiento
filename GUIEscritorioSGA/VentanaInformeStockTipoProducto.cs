using GUIEscritorioSGA.ServiceBodega;
using GUIEscritorioSGA.ServiceTipoProducto;
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
    public partial class VentanaInformeStockTipoProducto : Form
    {
        #region Parametros
        private ServiceTipoProducto.WebServiceTipoProductoSoapClient auxServiceTipoProducto;
        private ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega;

        private List<ServiceBodega.MDBodega> listaBodegas;
        private List<string> listaBodegasString;

        private List<ServiceTipoProducto.MDTipoProducto> listaTipoProducto;
        private List<ServiceTipoProducto.DTipoProductoCantidad> listaTipoProductoCantidad;
        private List<IDTipoProductoCantidad> listaIDTipoProductoCantidad;
        private Dictionary<int, int> diccTipoProductoCantidad;

        #endregion

        #region Propiedades
        public WebServiceTipoProductoSoapClient AuxServiceTipoProducto { get => auxServiceTipoProducto; set => auxServiceTipoProducto = value; }
        public WebServiceBodegaSoapClient AuxServiceBodega { get => auxServiceBodega; set => auxServiceBodega = value; }
        public List<MDBodega> ListaBodegas { get => listaBodegas; set => listaBodegas = value; }
        public List<string> ListaBodegasString { get => listaBodegasString; set => listaBodegasString = value; }
        public List<MDTipoProducto> ListaTipoProducto { get => listaTipoProducto; set => listaTipoProducto = value; }
        public List<DTipoProductoCantidad> ListaTipoProductoCantidad { get => listaTipoProductoCantidad; set => listaTipoProductoCantidad = value; }
        public List<IDTipoProductoCantidad> ListaIDTipoProductoCantidad { get => listaIDTipoProductoCantidad; set => listaIDTipoProductoCantidad = value; }
        public Dictionary<int, int> DiccTipoProductoCantidad { get => diccTipoProductoCantidad; set => diccTipoProductoCantidad = value; }

        #endregion

        #region Estructuras
        public class IDTipoProductoCantidad
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

        #region Constructores

        public VentanaInformeStockTipoProducto()
        {
            InitializeComponent();
            CargarContenido();
        }

        #endregion

        #region Funciones

        private void CargarContenido()
        {
            AuxServiceBodega = new WebServiceBodegaSoapClient();
            AuxServiceTipoProducto = new WebServiceTipoProductoSoapClient();

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

        private void CargarTiposProducto()
        {
            ListaTipoProducto = AuxServiceTipoProducto.BuscarAll().ToList();
            ListaIDTipoProductoCantidad = new List<IDTipoProductoCantidad>();
            DiccTipoProductoCantidad = new Dictionary<int, int>();
            IDTipoProductoCantidad auxIDTipoProductoCantidad;

            if (ComboBox_Bodegas.SelectedIndex <= 0)
            {
                //Todas las bodegas
                ListaTipoProductoCantidad = AuxServiceTipoProducto.GetCantidadTipoProductoActual().ToList();
            }
            else
            {
                //Bodega Especifica
                int id_bodega = ListaBodegas[ComboBox_Bodegas.SelectedIndex - 1].IdBodega;
                ListaTipoProductoCantidad = AuxServiceTipoProducto.GetCantidadTipoProductoActualByBodega(id_bodega).ToList();
            }

            //Rellenar Diccionario de cantidades
            foreach (var tipoProducto_cantidad in ListaTipoProductoCantidad)
            {
                DiccTipoProductoCantidad[tipoProducto_cantidad.Id_tipo_producto] = tipoProducto_cantidad.Cantidad;
            }

            //Rellenar lista de productos
            foreach (var tipoProducto in ListaTipoProducto)
            {
                auxIDTipoProductoCantidad = new IDTipoProductoCantidad();
                auxIDTipoProductoCantidad.Top = 0;
                auxIDTipoProductoCantidad.Id = tipoProducto.IdTipoProducto;
                auxIDTipoProductoCantidad.Nombre = tipoProducto.NombreTipo;
                if (DiccTipoProductoCantidad.ContainsKey(tipoProducto.IdTipoProducto))
                {
                    auxIDTipoProductoCantidad.Cantidad = DiccTipoProductoCantidad[tipoProducto.IdTipoProducto];
                }
                else
                {
                    auxIDTipoProductoCantidad.Cantidad = 0;
                }
                ListaIDTipoProductoCantidad.Add(auxIDTipoProductoCantidad);
            }

            //Ordenar Lista
            ListaIDTipoProductoCantidad = ListaIDTipoProductoCantidad.OrderByDescending(registro => registro.Cantidad).ToList();
            int posicion = 1;
            foreach (var id_tipoProducto_cantidad in ListaIDTipoProductoCantidad)
            {
                id_tipoProducto_cantidad.Top = posicion;
                posicion++;
            }

            //Ingresar en la DataGridView
            DataGridView_ListaTipoProductos.DataSource = ListaIDTipoProductoCantidad;
        }

        #endregion

        #region Eventos

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarTiposProducto();
        }

        private void ComboBox_Bodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTiposProducto();
        }
        #endregion
    }
}
