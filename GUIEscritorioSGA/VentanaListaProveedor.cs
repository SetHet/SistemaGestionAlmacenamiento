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
    public partial class VentanaListaProveedor : Form
    {
        public VentanaListaProveedor()
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
            ServiceProveedor.WebServiceProveedorSoapClient auxServiceProveedor = new ServiceProveedor.WebServiceProveedorSoapClient();
            List<ServiceProveedor.MDProveedor> listaProveedor;
            listaProveedor = auxServiceProveedor.BuscarAll().ToList();

            DataGridView_ListaProveedor.DataSource = listaProveedor;
        }

       

        private void DataGridView_ListaProveedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
