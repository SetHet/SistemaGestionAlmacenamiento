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
    public partial class VentanaListaTipoProducto : Form
    {
        public VentanaListaTipoProducto()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            ServiceTipoProducto.WebServiceTipoProductoSoapClient auxServiceTipoProducto = new ServiceTipoProducto.WebServiceTipoProductoSoapClient();
            List<ServiceTipoProducto.MDTipoProducto> listaTipos;
            listaTipos = auxServiceTipoProducto.BuscarAll().ToList();

            DataGridView_ListaTipoProducto.DataSource = listaTipos;
        }

        private void DataGridView_ListaTipoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
