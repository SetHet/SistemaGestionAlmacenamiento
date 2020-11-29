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
    public partial class VentanaListaSucursal : Form
    {
        public VentanaListaSucursal()
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
            ServiceSucursal.WebServiceSucursalSoapClient auxServiceSucursal = new ServiceSucursal.WebServiceSucursalSoapClient();
            List<ServiceSucursal.MDSucursal> listaSucursal;
            listaSucursal = auxServiceSucursal.BuscarAll().ToList();

            DataGridView_ListaSucursal.DataSource = listaSucursal;
        }



        private void DataGridView_ListaSucursal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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