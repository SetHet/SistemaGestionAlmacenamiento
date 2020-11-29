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
    public partial class VentanaTransaccionSalida : Form
    {
        #region Parametros

        #endregion

        #region Propiedades

        #endregion

        public VentanaTransaccionSalida()
        {
            InitializeComponent();
        }

        #region Funciones

        #endregion

        #region Eventos

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }



        #endregion

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
    }
}
