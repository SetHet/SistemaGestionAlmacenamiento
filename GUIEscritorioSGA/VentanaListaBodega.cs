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
    public partial class VentanaListaBodega : Form
    {
        public VentanaListaBodega()
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
            ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega = new ServiceBodega.WebServiceBodegaSoapClient();
            List<ServiceBodega.MDBodega> listaBodega;
            listaBodega = auxServiceBodega.BuscarAll().ToList();

            DataGridView_ListaBodega.DataSource = listaBodega;
        }

        private void DataGridView_ListaBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
