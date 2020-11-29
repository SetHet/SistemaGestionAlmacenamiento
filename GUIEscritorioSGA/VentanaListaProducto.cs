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
    public partial class VentanaListaProducto : Form
    {
        public VentanaListaProducto()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void ActualizarLista()
        {
            ServiceProducto.WebServiceProductoSoapClient auxServiceProducto = new ServiceProducto.WebServiceProductoSoapClient();
            List<ServiceProducto.MDProducto> listaProducto;
            listaProducto = auxServiceProducto.BuscarAll().ToList();

            DataGridView_ListaProducto.DataSource = listaProducto;
        }



        private void DataGridView_ListaProducto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }
    }
}
