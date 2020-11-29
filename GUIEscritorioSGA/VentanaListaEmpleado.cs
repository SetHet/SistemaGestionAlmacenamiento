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
    public partial class VentanaListaEmpleado : Form
    {
        public VentanaListaEmpleado()
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
            ServiceEmpleado.WebServiceEmpleadoSoapClient auxServiceEmpleado = new ServiceEmpleado.WebServiceEmpleadoSoapClient();
            List<ServiceEmpleado.MDEmpleado> listaEmpleado;
            listaEmpleado = auxServiceEmpleado.BuscarAll().ToList();

            DataGridView_ListaEmpleado.DataSource = listaEmpleado;
        }

        private void DataGridView_ListaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
